using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Windows.Forms;

using ActUtlTypeLib;
using LibLog;
using MySql.Data.MySqlClient;

namespace CurvedSpringFatigueTester
{
    public static class GlobalFunction
    {
        public static bool CheckProcess(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            return (processes.Length > 1 ? false : true);
        }

        public static void DoubleBuffered(Control control, bool value)
        {
            Type type = control.GetType();
            PropertyInfo propertyInfo = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            propertyInfo.SetValue(control, value);
        }

        public static string[] GetNames(e_Parameter parameter)
        {
            string[] result = null;
            // TODO : e_Parameter
            switch (parameter)
            {
                case e_Parameter.System:       result = Enum.GetNames(typeof(e_Parameter_System));     break;
                case e_Parameter.Recipe:       result = Enum.GetNames(typeof(e_Parameter_Recipe));     break;

                case e_Parameter.DB:           result = Enum.GetNames(typeof(e_Parameter_DB));         break;
                case e_Parameter.Log:          result = Enum.GetNames(typeof(e_Parameter_Log));        break;
                case e_Parameter.PLC:          result = Enum.GetNames(typeof(e_Parameter_PLC));        break;
                case e_Parameter.PLC_B_IN:
                case e_Parameter.PLC_B_OUT:
                case e_Parameter.PLC_F_Alarm:
                case e_Parameter.PLC_R_IN:
                case e_Parameter.PLC_R_OUT:    result = Enum.GetNames(typeof(e_Parameter_PLC_Param));  break;
                case e_Parameter.RMC:          result = Enum.GetNames(typeof(e_Parameter_RMC));        break;
                case e_Parameter.RMC_IN:
                case e_Parameter.RMC_OUT:      result = Enum.GetNames(typeof(e_Parameter_RMC_Param));  break;
            }
            return result;
        }
        public static string[] GetNames(e_Command command)
        {
            string[] result = null;
            // TODO : e_Command
            switch (command)
            {
                case e_Command.Ramp: result = Enum.GetNames(typeof(e_Command_Ramp)); break;
                case e_Command.Test: result = Enum.GetNames(typeof(e_Command_Test)); break;
                case e_Command.Link: result = Enum.GetNames(typeof(e_Command_Link)); break;
            }
            return result;
        }

        public static string GetString(Exception ex)
        {
            return string.Format("try catch error (message=[{0}])", ex);
        }
        public static string GetString(object value)
        {
            return string.Format("{0}", value);
        }

        public static bool LoadParameter()
        {
            bool result = false;

            for (int i = (int)e_Parameter.System; i <= (int)e_Parameter.Recipe; i++)
            {
                if ((e_Parameter)i == e_Parameter.Recipe)
                {
                    result = LoadParameter((e_Parameter)i, GlobalValue.Parameter[(int)e_Parameter.System]["1"][(int)e_Parameter_System.LastFileName]);
                }
                else
                {
                    result = LoadParameter((e_Parameter)i);
                }

                if (result == false)
                {
                    if ((e_Parameter)i == e_Parameter.Recipe)
                    {
                        result = true;

                        GlobalValue.PCAlarm[(int)e_PCAlarm.ERROR_LOADING_PARAMETER_RECIPE] = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return result;
        }
        public static bool LoadParameter(e_Parameter parameter, string recipeFileName = "")
        {
            bool result = false;
            try
            {
                if (GlobalValue.Parameter[(int)parameter] == null)
                {
                    GlobalValue.Parameter[(int)parameter] = new Dictionary<string, string[]>();
                }

                string fileName = (parameter == e_Parameter.Recipe ? recipeFileName : string.Format("{0}\\{1}.dat", GlobalValue.Directory.Parameter, parameter));
                if (File.Exists(fileName))
                {
                    GlobalValue.Parameter[(int)parameter].Clear();

                    using (StreamReader streamReader = new StreamReader(fileName, Encoding.UTF8))
                    {
                        string line;
                        string[] vs;
                        int num = 0;

                        while (!streamReader.EndOfStream)
                        {
                            // step.1
                            line = streamReader.ReadLine();
                            // step.2
                            line = line.Replace("\t", "");
                            // step.3
                            vs = line.Split(',');
                            // step.4
                            for (int i = 0; i < vs.Length; i++)
                            {
                                vs[i] = vs[i].Trim();
                            }
                            // step.5
                            if (int.TryParse(vs[0], out num))
                            {
                                GlobalValue.Parameter[(int)parameter].Add(vs[0], vs);
                            }
                        }
                    }

                    result = (GlobalValue.Parameter[(int)parameter].Count > 0 ? true : false);
                }
                else
                {
                    Log.Write(MethodBase.GetCurrentMethod().Name, string.Format("{0} 파일을 찾을 수 없습니다", fileName));
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GetString(ex));
            }
            if (result == false)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, string.Format("{0} Parameter loading NG", parameter));
            }
            // 다음에는 Recipe_Copy 사용하지 말 것
            if (parameter == e_Parameter.Recipe)
            {
                if (CopyRecipe() == false)
                {
                    GlobalValue.PCAlarm[(int)e_PCAlarm.ERROR_COPY_RECIPE] = true;
                }
            }
            return result;
        }

        public static bool SaveParameter(e_Parameter parameter, string recipeFileName = "")
        {
            bool result = false;
            try
            {
                string fileName = (parameter == e_Parameter.Recipe ? GlobalValue.Parameter[(int)e_Parameter.System]["1"][(int)e_Parameter_System.LastFileName] : string.Format("{0}\\{1}.dat", GlobalValue.Directory.Parameter, parameter));
                if (BackupParameter(parameter, fileName) == false)
                {
                    GlobalValue.PCAlarm[(int)e_PCAlarm.ERROR_BACKUP_PARAMETER] = true;
                }

                if (parameter == e_Parameter.Recipe)
                {
                    if (recipeFileName != "")
                    {
                        fileName = recipeFileName;
                    }
                }

                if (File.Exists(fileName))
                {
                    File.SetAttributes(fileName, FileAttributes.Normal);
                    File.Delete(fileName);
                }

                using (StreamWriter streamWriter = new StreamWriter(new FileStream(fileName, FileMode.Append), Encoding.UTF8))
                {
                    streamWriter.WriteLine("==================================================");
                    streamWriter.WriteLine(string.Format("{0} ({1})", parameter, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
                    streamWriter.WriteLine("==================================================");

                    string[] vs = GetNames(parameter);

                    string line = string.Empty;
                    for (int i = 0; i < vs.Length; i++)
                    {
                        line += vs[i];
                        if (i < vs.Length - 1)
                        {
                            line += ",";
                        }
                    }
                    streamWriter.WriteLine(line);

                    line = string.Empty;
                    for (int i = 1; i <= GlobalValue.Parameter[(int)parameter].Count; i++)
                    {
                        for (int j = 0; j < vs.Length; j++)
                        {
                            line += GlobalValue.Parameter[(int)parameter][i.ToString()][j];
                            if (j < vs.Length - 1)
                            {
                                line += ",";
                            }
                        }
                        line += Environment.NewLine;
                    }
                    streamWriter.Write(line);
                }

                result = true;
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GetString(ex));
            }
            if (result == false)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, string.Format("{0} Parameter save NG", parameter));
            }
            return result;
        }
        private static bool BackupParameter(e_Parameter parameter, string sourceFileName)
        {
            bool result = false;
            try
            {
                if (File.Exists(sourceFileName))
                {
                    string path = (parameter == e_Parameter.Recipe ? GlobalValue.Directory.bakRecipe : GlobalValue.Directory.bakParameter);
                    DateTime now = DateTime.Now;
                    path += string.Format("\\{0}", now.ToString("yyyy-MM-dd"));
                    string name = Path.GetFileNameWithoutExtension(sourceFileName);
                    string destFileName = string.Format("{0}\\{1}_{2}.bak", path, name, now.ToString("HHmmss"));

                    if (Directory.Exists(path) == false)
                    {
                        Directory.CreateDirectory(path);
                    }

                    File.SetAttributes(sourceFileName, FileAttributes.Normal);
                    File.Copy(sourceFileName, destFileName, true);

                    result = true;
                }
                else
                {
                    Log.Write(MethodBase.GetCurrentMethod().Name, string.Format("{0} 파일을 찾을 수 없습니다", sourceFileName));
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GetString(ex));
            }
            if (result == false)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, string.Format("{0} Parameter backup NG", parameter));
            }
            return result;
        }

        public static DialogResult MessageBox(string call, string text, MessageBoxButtons buttons, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            Log.Write(call, string.Format("MessageBox=[{0}]", text.Replace(Environment.NewLine, " ")));

            DialogResult result = System.Windows.Forms.MessageBox.Show(text, "DAECO", buttons, icon);

            Log.Write(call, string.Format("[{0}]=[{1}]", buttons, result));

            return result;
        }

        /// <summary>
        /// Recipe -> Recipe_Copy
        /// </summary>
        public static bool CopyRecipe()
        {
            bool result = false;
            try
            {
                if (GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy] == null)
                {
                    GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy] = new Dictionary<string, string[]>();
                }

                GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Clear();

                for (int i = 0; i < GlobalValue.Parameter[(int)e_Parameter.Recipe].Count; i++)
                {
                    string[] vs = GetNames(e_Parameter.Recipe);

                    Array.Copy(GlobalValue.Parameter[(int)e_Parameter.Recipe][(i + 1).ToString()], vs, vs.Length);

                    GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Add((i + 1).ToString(), vs);
                }

                result = true;
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GetString(ex));
            }
            if (result == false)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, "Recipe copy NG");
            }
            return result;
        }
        /// <summary>
        /// Recipe_Copy -> Recipe
        /// </summary>
        public static bool UpdateRecipe()
        {
            bool result = false;
            try
            {
                GlobalValue.Parameter[(int)e_Parameter.Recipe].Clear();

                for (int i = 0; i < GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Count; i++)
                {
                    string[] vs = GetNames(e_Parameter.Recipe);

                    Array.Copy(GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(i + 1).ToString()], vs, vs.Length);

                    GlobalValue.Parameter[(int)e_Parameter.Recipe].Add((i + 1).ToString(), vs);
                }

                result = true;
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GetString(ex));
            }
            if (result == false)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, "Recipe update NG");
            }
            return result;
        }

        /// <summary>
        /// PingTest
        /// </summary>
        /// <param name="IP">hostNameOrAddress</param>
        /// <param name="timeout">msec</param>
        /// <returns></returns>
        public static bool PingTest(string IP, int timeout)
        {
            bool result = false;
            try
            {
                Ping pingSender = new Ping();

                // Create a buffer of 32 bytes of data to be transmitted.
                string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);

                // Set options for transmission:
                // The data can go through 64 gateways or routers
                // before it is destroyed, and the data packet
                // cannot be fragmented.
                PingOptions options = new PingOptions(64, true);

                // Send the request.
                PingReply reply = pingSender.Send(IP, timeout, buffer, options);

                result = (reply.Status == IPStatus.Success ? true : false);
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GetString(ex));
            }
            return result;
        }

        public static class DataGridView
        {
            public static void SetProperties(System.Windows.Forms.DataGridView dgv)
            {
                DoubleBuffered(dgv, true);

                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;
                dgv.AllowUserToOrderColumns = false;
                dgv.AllowUserToResizeColumns = false;
                dgv.AllowUserToResizeRows = false;

                if (dgv.Name != "dgv_Command_Param")
                {
                    dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; // 홀수 번호 행에 적용되는 기본 셀 스타일을 설정
                }

                DataGridViewCellStyle defaultCellStyle = new DataGridViewCellStyle();
                defaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                defaultCellStyle.Font = new Font(e_Font.Tahoma.ToString(), 11F);
                dgv.DefaultCellStyle = defaultCellStyle;

                dgv.RowHeadersVisible = false;

                dgv.RowHeadersWidth = 60;
                dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                DataGridViewRow rowTemplate = new DataGridViewRow();
                rowTemplate.Height = 30;
                dgv.RowTemplate = rowTemplate;
            }

            public static void AddColumns(System.Windows.Forms.DataGridView dgv, string[] columns)
            {
                dgv.Columns.Clear();

                for (int i = 0; i < columns.Length; i++)
                {
                    dgv.Columns.Add(columns[i], columns[i].Replace("_", " "));

                    dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

                    #region dgv 및 column 별 설정
                    switch (dgv.Name)
                    {
                        case "dgv_Recipe_Copy":
                            #region ReadOnly
                            if ((e_Parameter_Recipe)i != e_Parameter_Recipe.Skip)
                            {
                                dgv.Columns[i].ReadOnly = true;
                            }
                            #endregion
                            #region Visible
                            if ((e_Parameter_Recipe)i == e_Parameter_Recipe.Skip ||
                                (e_Parameter_Recipe)i >= e_Parameter_Recipe.Param0
                               )
                            {
                                dgv.Columns[i].Visible = false;
                            }
                            #endregion
                            break;


                        case "dgv_Command_Param":
                            #region ReadOnly
                            if ((e_Command_Param)i != e_Command_Param._____Data_____)
                            {
                                dgv.Columns[i].ReadOnly = true;
                            }
                            #endregion
                            #region Visible
                            if ((e_Command_Param)i == e_Command_Param.Index ||
                                (e_Command_Param)i == e_Command_Param.Offset ||
                                (e_Command_Param)i == e_Command_Param.DataType
                               )
                            {
                                dgv.Columns[i].Visible = false;
                            }
                            #endregion
                            break;


                        case "dgv_PLC_R_OUT":
                            #region ReadOnly
                            if (i != (int)e_Parameter_PLC_Param.No + 1)
                            {
                                dgv.Columns[i].ReadOnly = true;
                            }
                            #endregion
                            break;


                        case "dgv_RMC_IN":
                        case "dgv_RMC_OUT":
                            #region ReadOnly
                            dgv.Columns[i].ReadOnly = true;
                            #endregion
                            break;


                        default:
                            dgv.Columns[i].ReadOnly = true;
                            break;
                    }
                    #endregion
                }

                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                cellStyle.BackColor = Color.DimGray;
                cellStyle.ForeColor = Color.White;
                //cellStyle.Font = new Font(e_Font.Tahoma.ToString(), 11F);
                if (dgv.Name == "dgv_Recipe_Copy" ||
                    dgv.Name == "dgv_Command_Param"
                   )
                {
                    cellStyle.Font = new Font(e_Font.Tahoma.ToString(), 16F);
                    dgv.ColumnHeadersHeight = 40;
                }
                else
                {
                    cellStyle.Font = new Font(e_Font.Tahoma.ToString(), 11F);
                    dgv.ColumnHeadersHeight = 30;
                }
                dgv.ColumnHeadersDefaultCellStyle = cellStyle;

                //dgv.ColumnHeadersHeight = 30;
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

                dgv.EnableHeadersVisualStyles = false;

                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

            public static void AddRows(System.Windows.Forms.DataGridView dgv, e_Parameter parameter)
            {
                dgv.Rows.Clear();

                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                try
                {
                    if (GlobalValue.Parameter[(int)parameter] != null)
                    {
                        #region row 추가
                        for (int i = 0; i < GlobalValue.Parameter[(int)parameter].Count; i++)
                        {
                            // TODO : e_Parameter
                            switch (parameter)
                            {
                                case e_Parameter.PLC_B_IN:
                                case e_Parameter.PLC_B_OUT:
                                case e_Parameter.PLC_F_Alarm:
                                case e_Parameter.PLC_R_IN:
                                case e_Parameter.PLC_R_OUT:
                                    dgv.Rows.Add(GlobalValue.Parameter[(int)parameter][(i + 1).ToString()][(int)e_Parameter_PLC_Param.No],
                                                 string.Empty,
                                                 GlobalValue.Parameter[(int)parameter][(i + 1).ToString()][(int)e_Parameter_PLC_Param.Address],
                                                 GlobalValue.Parameter[(int)parameter][(i + 1).ToString()][(int)e_Parameter_PLC_Param.Comment]
                                                );
                                    break;


                                case e_Parameter.RMC_IN:
                                case e_Parameter.RMC_OUT:
                                    dgv.Rows.Add(GlobalValue.Parameter[(int)parameter][(i + 1).ToString()][(int)e_Parameter_RMC_Param.No],
                                                 string.Empty,
                                                 GlobalValue.Parameter[(int)parameter][(i + 1).ToString()][(int)e_Parameter_RMC_Param.Bit],
                                                 GlobalValue.Parameter[(int)parameter][(i + 1).ToString()][(int)e_Parameter_RMC_Param.Tag_Name]
                                                );
                                    break;


                                default:
                                    dgv.Rows.Add(GlobalValue.Parameter[(int)parameter][(i + 1).ToString()]);
                                    break;
                            }
                        }
                        #endregion

                        #region row 별 설정
                        // TODO : e_Parameter
                        switch (parameter)
                        {
                            case e_Parameter.Recipe_Copy:
                                for (int i = 0; i < dgv.Rows.Count; i++)
                                {
                                    #region ComboBox
                                    DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();

                                    //comboBoxCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

                                    comboBoxCell.Items.Add("0");
                                    comboBoxCell.Items.Add("1");

                                    comboBoxCell.Value = GlobalValue.Parameter[(int)parameter][(i + 1).ToString()][(int)e_Parameter_Recipe.Skip];

                                    dgv.Rows[i].Cells[(int)e_Parameter_Recipe.Skip] = comboBoxCell;
                                    #endregion
                                }
                                break;
                        }
                        #endregion
                    }
                }
                catch (Exception ex)
                {
                    Log.Write(MethodBase.GetCurrentMethod().Name, GetString(ex));
                }
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        public static class DB
        {
            public static class MySQL
            {
                private static string GetConnectionString()
                {
                    string result = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};Connection Timeout={5}", GlobalValue.Parameter[(int)e_Parameter.DB]["1"][(int)e_Parameter_DB.Server],
                                                                                                                             GlobalValue.Parameter[(int)e_Parameter.DB]["1"][(int)e_Parameter_DB.Port],
                                                                                                                             GlobalValue.Parameter[(int)e_Parameter.DB]["1"][(int)e_Parameter_DB.Database],
                                                                                                                             GlobalValue.Parameter[(int)e_Parameter.DB]["1"][(int)e_Parameter_DB.Uid],
                                                                                                                             GlobalValue.Parameter[(int)e_Parameter.DB]["1"][(int)e_Parameter_DB.Pwd],
                                                                                                                             GlobalValue.Parameter[(int)e_Parameter.DB]["1"][(int)e_Parameter_DB.ConnectionTimeout_sec]
                                                 );
                    //Log.Write(MethodBase.GetCurrentMethod().Name, string.Format("Connection String=[{0}]", result));
                    return result;
                }

                public static DataTable GetDataTable(string cmdText)
                {
                    DataTable result = new DataTable();
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(GetConnectionString()))
                        {
                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();

                                //Log.Write(MethodBase.GetCurrentMethod().Name, string.Format("Query=[{0}]", cmdText));

                                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmdText, connection))
                                {
                                    dataAdapter.Fill(result);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Write(MethodBase.GetCurrentMethod().Name, GetString(ex));
                    }
                    //Log.Write(MethodBase.GetCurrentMethod().Name, (result.Rows.Count > 0 ? "Query OK" : "Query NG"));
                    if (result.Rows.Count == 0)
                    {
                        Log.Write(MethodBase.GetCurrentMethod().Name, string.Format("Query NG=[{0}]", cmdText));
                    }
                    return result;
                }

                public static bool Query(string cmdText)
                {
                    bool result = false;
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(GetConnectionString()))
                        {
                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();

                                //Log.Write(MethodBase.GetCurrentMethod().Name, string.Format("Query=[{0}]", cmdText));

                                using (MySqlCommand command = new MySqlCommand(cmdText, connection))
                                {
                                    result = (command.ExecuteNonQuery() > 0 ? true : false);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Write(MethodBase.GetCurrentMethod().Name, GetString(ex));
                    }
                    //Log.Write(MethodBase.GetCurrentMethod().Name, (result ? "Query OK" : "Query NG"));
                    if (result == false)
                    {
                        Log.Write(MethodBase.GetCurrentMethod().Name, string.Format("Query NG=[{0}]", cmdText));
                    }
                    return result;
                }
            }
        }
    }

    public static class GlobalDevice
    {
        public static class PLC
        {
            #region MELSEC (MX Component)
            public static ActUtlType MX = null;
            // Returned value
            public static int Status = -1;

            public struct TBit
            {
                public string StartAddress;
                public int Count;
                public short[] Value;
                public bool[] Data;
                public string[] Comment;
            }
            public static TBit B_IN;
            public static TBit B_OUT;
            public static TBit F_Alarm;

            public struct TWord
            {
                public string StartAddress;
                public int Count;
                public short[] Value;
                public string[] Comment;
            }
            public static TWord R_IN;
            public static TWord R_OUT;
            #endregion
        }

        public static class RMC
        {
            public static CRMC Instance = null;
        }

        public static bool Start()
        {
            bool result = false;

            for (int i = 0; i < Enum.GetNames(typeof(e_Device)).Length; i++)
            {
                result = Start((e_Device)i);

                if (result == false)
                {
                    break;
                }
            }

            return result;
        }
        public static bool Start(e_Device device)
        {
            bool result = false;
            try
            {
                Stop(device);

                switch (device)
                {
                    case e_Device.PLC:
                        PLC.MX = new ActUtlType();

                        int count;

                        #region B_IN
                        PLC.B_IN.StartAddress = GlobalValue.Parameter[(int)e_Parameter.PLC_B_IN]["1"][(int)e_Parameter_PLC_Param.Address];
                        count = GlobalValue.Parameter[(int)e_Parameter.PLC_B_IN].Count;
                        PLC.B_IN.Count = count;
                        PLC.B_IN.Value = new short[count / 16];
                        PLC.B_IN.Data = new bool[count];
                        PLC.B_IN.Comment = new string[count];
                        for (int i = 0; i < count; i++)
                        {
                            PLC.B_IN.Comment[i] = GlobalValue.Parameter[(int)e_Parameter.PLC_B_IN][(i + 1).ToString()][(int)e_Parameter_PLC_Param.Comment];
                        }
                        #endregion
                        #region B_OUT
                        PLC.B_OUT.StartAddress = GlobalValue.Parameter[(int)e_Parameter.PLC_B_OUT]["1"][(int)e_Parameter_PLC_Param.Address];
                        count = GlobalValue.Parameter[(int)e_Parameter.PLC_B_OUT].Count;
                        PLC.B_OUT.Count = count;
                        PLC.B_OUT.Value = new short[count / 16];
                        PLC.B_OUT.Data = new bool[count];
                        PLC.B_OUT.Comment = new string[count];
                        for (int i = 0; i < count; i++)
                        {
                            PLC.B_OUT.Comment[i] = GlobalValue.Parameter[(int)e_Parameter.PLC_B_OUT][(i + 1).ToString()][(int)e_Parameter_PLC_Param.Comment];
                        }
                        #endregion
                        #region F_Alarm
                        PLC.F_Alarm.StartAddress = GlobalValue.Parameter[(int)e_Parameter.PLC_F_Alarm]["1"][(int)e_Parameter_PLC_Param.Address];
                        count = GlobalValue.Parameter[(int)e_Parameter.PLC_F_Alarm].Count;
                        PLC.F_Alarm.Count = count;
                        PLC.F_Alarm.Value = new short[count / 16];
                        PLC.F_Alarm.Data = new bool[count];
                        PLC.F_Alarm.Comment = new string[count];
                        for (int i = 0; i < count; i++)
                        {
                            PLC.F_Alarm.Comment[i] = GlobalValue.Parameter[(int)e_Parameter.PLC_F_Alarm][(i + 1).ToString()][(int)e_Parameter_PLC_Param.Comment];
                        }
                        #endregion
                        #region R_IN
                        PLC.R_IN.StartAddress = GlobalValue.Parameter[(int)e_Parameter.PLC_R_IN]["1"][(int)e_Parameter_PLC_Param.Address];
                        count = GlobalValue.Parameter[(int)e_Parameter.PLC_R_IN].Count;
                        PLC.R_IN.Count = count;
                        PLC.R_IN.Value = new short[count];
                        PLC.R_IN.Comment = new string[count];
                        for (int i = 0; i < count; i++)
                        {
                            PLC.R_IN.Comment[i] = GlobalValue.Parameter[(int)e_Parameter.PLC_R_IN][(i + 1).ToString()][(int)e_Parameter_PLC_Param.Comment];
                        }
                        #endregion
                        #region R_OUT
                        PLC.R_OUT.StartAddress = GlobalValue.Parameter[(int)e_Parameter.PLC_R_OUT]["1"][(int)e_Parameter_PLC_Param.Address];
                        count = GlobalValue.Parameter[(int)e_Parameter.PLC_R_OUT].Count;
                        PLC.R_OUT.Count = count;
                        PLC.R_OUT.Value = new short[count];
                        PLC.R_OUT.Comment = new string[count];
                        for (int i = 0; i < count; i++)
                        {
                            PLC.R_OUT.Comment[i] = GlobalValue.Parameter[(int)e_Parameter.PLC_R_OUT][(i + 1).ToString()][(int)e_Parameter_PLC_Param.Comment];
                        }
                        #endregion

                        result = true;
                        break;


                    case e_Device.RMC:
                        RMC.Instance = new CRMC();

                        result = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
            return result;
        }

        public static void Stop()
        {
            for (int i = 0; i < Enum.GetNames(typeof(e_Device)).Length; i++)
            {
                Stop((e_Device)i);
            }
        }
        public static void Stop(e_Device device)
        {
            switch (device)
            {
                case e_Device.PLC:
                    if (PLC.MX != null)
                    {
                        PLC.MX.Close();
                    }
                    break;


                case e_Device.RMC:
                    if (RMC.Instance != null)
                    {
                        RMC.Instance.Dispose(); // StopThread
                        RMC.Instance.Disconnect();
                        RMC.Instance = null;
                    }
                    break;
            }
        }
    }
}

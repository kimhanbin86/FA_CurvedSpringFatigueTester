using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;

using LibLog;

namespace CurvedSpringFatigueTester
{
    public partial class FrmMain : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private enum e_TabPage // 스레드에서 TabControl.SelectedIndex 참조 시에 오류 발생하여 변수 참조
        {
            _00_Home,      // HOME
            _01_Graph,     // GRAPH
            _02_Signal,    // IN/OUT
            _03_Zero,      // ZERO Set
            _04_Parameter  // PARAMETER Set
        }
        private e_TabPage tabPage = e_TabPage._00_Home;

        #region Flag

        // TODO : GlobalDevice.RMC.IN
        private int RMC_IN;
        public bool isAuto          = false;
        public bool isManual        = false;
        public bool isTestStart     = false;
        public bool isTestStop      = false;
        public bool isEmergency     = false;

        // TODO : GlobalDevice.RMC.OUT
        private int RMC_OUT;
        public bool isReady         = false;
        public bool isHomePosOK     = false;
        public bool isTestComplete  = false;

        // TODO : GlobalDevice.RMC.Flag
        private int RMC_Flag;
        public bool isGraphOn       = false;
        public bool isGraphClear    = false;
        public bool isTestOK        = false;
        public bool isTestNG        = false;
        public bool isPosPosLimit   = false;
        public bool isPosFrcLimit   = false;
        public bool isNegPosLimit   = false;
        public bool isNegFrcLimit   = false;

        public bool TestStop
        {
            get
            {
                return isManual || isTestStop || isTestComplete;
            }
        }
        public bool TestStart
        {
            get
            {
                return isAuto && isTestStart && !isTestStop && !isTestComplete;
            }
        }

        #endregion

        #region Thread

        private Stopwatch swTestTime = new Stopwatch(); // Test Start ~ Stop or Complete

        public int TestCount;

        private System.Threading.Thread threadUpdate = null;
        private bool isThreadUpdate = false;
        private void ProcessUpdate()
        {
            while (isThreadUpdate)
            {
                try
                {
                    #region 현재 시간 /  PLC, RMC 연결 상태 출력

                    //Invoke(new MethodInvoker(delegate () { Text = GlobalValue.Parameter[(int)e_Parameter.System]["1"][(int)e_Parameter_System.Name]; }));

                    SetToolLabelText(lbl_DateTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    SetToolLabelBackColor(conn_PLC, GlobalDevice.PLC.Status == 0 ? Color.Lime : Color.Red);

                    if (GlobalDevice.RMC.Instance != null)
                    {
                        SetToolLabelBackColor(conn_RMC, GlobalDevice.RMC.Instance.IsConnected ? Color.Lime : Color.Red);
                    }

                    #endregion

                    #region 수동에 따른 ZERO Set 탭 설정

                    if (isManual)
                    {
                        SetControlVisible(tableLayoutPanel23, true);

                        SetControlVisible(panel4, false);
                    }
                    else
                    {
                        SetControlVisible(tableLayoutPanel23, false);

                        SetControlVisible(panel4, true);

                        if (panel4.Dock != DockStyle.Fill)
                        {
                            SetControlDock(panel4, DockStyle.Fill);
                        }
                    }

                    #endregion

                    #region 탭별 모니터링

                    if (tabPage == e_TabPage._00_Home)
                    {
                        SetLabelText(lbl_RecipeName, Path.GetFileName(GlobalValue.Parameter[(int)e_Parameter.System]["1"][(int)e_Parameter_System.LastFileName]));
                    }
                    else if (tabPage == e_TabPage._01_Graph)
                    {
                        if (GlobalDevice.RMC.Instance != null)
                        {
                            SetLabelText(lbl_Axis0_Pos, string.Format("{0:F3}", Convert.ToSingle(GlobalDevice.RMC.Instance.Axis_Status[(int)e_Axis.Axis0, (int)e_Axis_Status_Registers.Actual_Position])));
                            SetLabelText(lbl_Axis0_Frc, string.Format("{0:F3}", Convert.ToSingle(GlobalDevice.RMC.Instance.Axis_Status[(int)e_Axis.Axis0, (int)e_Axis_Status_Registers.Actual_Force   ])));

                            SetLabelText(lbl_Count, TestCount.ToString());

                            try
                            {
                                if (ct_Graph.Series[(int)e_Chart_Series.ActualPosition].Points.Count > 0)
                                {
                                    SetLabelText(lbl_Min_Pos, string.Format("{0:F3}", ct_Graph.Series[(int)e_Chart_Series.ActualPosition].Points.FindMinByValue().YValues[0]));
                                    SetLabelText(lbl_Max_Pos, string.Format("{0:F3}", ct_Graph.Series[(int)e_Chart_Series.ActualPosition].Points.FindMaxByValue().YValues[0]));
                                }
                                else
                                {
                                    SetLabelText(lbl_Min_Pos, "0.000");
                                    SetLabelText(lbl_Max_Pos, "0.000");
                                }

                                if (ct_Graph.Series[(int)e_Chart_Series.ActualForce].Points.Count > 0)
                                {
                                    SetLabelText(lbl_Min_Frc, string.Format("{0:F3}", ct_Graph.Series[(int)e_Chart_Series.ActualForce].Points.FindMinByValue().YValues[0]));
                                    SetLabelText(lbl_Max_Frc, string.Format("{0:F3}", ct_Graph.Series[(int)e_Chart_Series.ActualForce].Points.FindMaxByValue().YValues[0]));
                                }
                                else
                                {
                                    SetLabelText(lbl_Min_Frc, "0.000");
                                    SetLabelText(lbl_Max_Frc, "0.000");
                                }
                            }
                            catch
                            {
                                SetLabelText(lbl_Min_Pos, "0.000");
                                SetLabelText(lbl_Max_Pos, "0.000");

                                SetLabelText(lbl_Min_Frc, "0.000");
                                SetLabelText(lbl_Max_Frc, "0.000");
                            }

                            SetLabelBackColor(lbl_isAuto     , isAuto      ? Color.Lime : SystemColors.Control);
                            SetLabelBackColor(lbl_isManual   , isManual    ? Color.Red  : SystemColors.Control);
                            SetLabelBackColor(lbl_isTestStart, isTestStart ? Color.Lime : SystemColors.Control);
                            SetLabelBackColor(lbl_isTestStop , isTestStop  ? Color.Lime : SystemColors.Control);
                            SetLabelBackColor(lbl_isEmergency, isEmergency ? Color.Red  : SystemColors.Control);

                            SetLabelBackColor(lbl_isReady       , isReady        ? Color.Lime : SystemColors.Control);
                            SetLabelBackColor(lbl_isHomePosOK   , isHomePosOK    ? Color.Lime : SystemColors.Control);
                            SetLabelBackColor(lbl_isTestComplete, isTestComplete ? Color.Lime : SystemColors.Control);

                            SetLabelBackColor(lbl_isGraphOn    , isGraphOn     ? Color.Lime : SystemColors.Control);
                            SetLabelBackColor(lbl_isGraphClear , isGraphClear  ? Color.Lime : SystemColors.Control);
                            SetLabelBackColor(lbl_isTestOK     , isTestOK      ? Color.Lime : SystemColors.Control);
                            SetLabelBackColor(lbl_isTestNG     , isTestNG      ? Color.Red  : SystemColors.Control);
                            SetLabelBackColor(lbl_isPosPosLimit, isPosPosLimit ? Color.Red  : SystemColors.Control);
                            SetLabelBackColor(lbl_isPosFrcLimit, isPosFrcLimit ? Color.Red  : SystemColors.Control);
                            SetLabelBackColor(lbl_isNegPosLimit, isNegPosLimit ? Color.Red  : SystemColors.Control);
                            SetLabelBackColor(lbl_isNegFrcLimit, isNegFrcLimit ? Color.Red  : SystemColors.Control);
                        }

                        SetLabelText(lbl_Time, (swTestTime.ElapsedMilliseconds / 1000.0F).ToString());
                    }
                    else if (tabPage == e_TabPage._03_Zero)
                    {
                        if (tableLayoutPanel23.Visible)
                        {
                            SetLabelText(lbl_Axis0_Actual_Pos, string.Format("{0:F3}", Convert.ToSingle(GlobalDevice.RMC.Instance.Axis_Status[(int)e_Axis.Axis0, (int)e_Axis_Status_Registers.Actual_Position])));
                            SetLabelText(lbl_Axis0_Actual_Frc, string.Format("{0:F3}", Convert.ToSingle(GlobalDevice.RMC.Instance.Axis_Status[(int)e_Axis.Axis0, (int)e_Axis_Status_Registers.Actual_Force   ])));
                        }
                    }

                    #endregion
                }
                catch (Exception ex)
                {
                    Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
                }

                System.Threading.Thread.Sleep(100);
            }
        }

        private System.Threading.Thread threadAlarm = null;
        private bool isThreadAlarm = false;
        private void ProcessAlarm()
        {
            bool[] prevF_Alarm = new bool[GlobalDevice.PLC.F_Alarm.Count];
            bool[] prevPCAlarm = new bool[GlobalValue.PCAlarm.Length];

            string cmdText = string.Empty;

            string alarmTime;

            while (isThreadAlarm)
            {
                try
                {
                    if (prevF_Alarm != null)
                    {
                        if (prevF_Alarm.Length != GlobalDevice.PLC.F_Alarm.Count)
                        {
                            prevF_Alarm = new bool[GlobalDevice.PLC.F_Alarm.Count];
                        }
                    }

                    // PLC
                    for (int i = 0; i < GlobalDevice.PLC.F_Alarm.Count; i++)
                    {
                        if (prevF_Alarm[i] != GlobalDevice.PLC.F_Alarm.Data[i])
                        {
                            prevF_Alarm[i] = GlobalDevice.PLC.F_Alarm.Data[i];

                            if (prevF_Alarm[i])
                            {
                                alarmTime = DateTime.Now.ToString("yyyyMMddHHmmss");

                                ShowAlarmForm(alarmTime,
                                              GlobalValue.Parameter[(int)e_Parameter.PLC_F_Alarm][(i + 1).ToString()][(int)e_Parameter_PLC_Param.Address],
                                              GlobalValue.Parameter[(int)e_Parameter.PLC_F_Alarm][(i + 1).ToString()][(int)e_Parameter_PLC_Param.Comment]
                                             );

                                cmdText = string.Format("INSERT INTO {0}({1},{2},{3}) VALUES('{4}','{5}','{6}')", e_DBTable.Alarm,
                                                                                                                  e_DBTable_Alarm.StartTime,
                                                                                                                  e_DBTable_Alarm.Code,
                                                                                                                  e_DBTable_Alarm.Name,
                                                                                                                  alarmTime,
                                                                                                                  GlobalValue.Parameter[(int)e_Parameter.PLC_F_Alarm][(i + 1).ToString()][(int)e_Parameter_PLC_Param.Address],
                                                                                                                  GlobalValue.Parameter[(int)e_Parameter.PLC_F_Alarm][(i + 1).ToString()][(int)e_Parameter_PLC_Param.Comment]
                                                       );

                                GlobalFunction.DB.MySQL.Query(cmdText);
                            }
                            else
                            {
                                cmdText = string.Format("UPDATE {0} SET {1}='{2}' WHERE {3} IS NULL AND {4}='{5}'", e_DBTable.Alarm,
                                                                                                                    e_DBTable_Alarm.EndTime, DateTime.Now.ToString("yyyyMMddHHmmss"),
                                                                                                                    e_DBTable_Alarm.EndTime,
                                                                                                                    e_DBTable_Alarm.Code, GlobalValue.Parameter[(int)e_Parameter.PLC_F_Alarm][(i + 1).ToString()][(int)e_Parameter_PLC_Param.Address]
                                                       );

                                GlobalFunction.DB.MySQL.Query(cmdText);
                            }
                        }
                    }

                    // PC
                    for (int i = 0; i < GlobalValue.PCAlarm.Length; i++)
                    {
                        if (prevPCAlarm[i] != GlobalValue.PCAlarm[i])
                        {
                            prevPCAlarm[i] = GlobalValue.PCAlarm[i];

                            if (prevPCAlarm[i])
                            {
                                alarmTime = DateTime.Now.ToString("yyyyMMddHHmmss");

                                ShowAlarmForm(alarmTime,
                                              string.Format("PC{0}", i),
                                              ((e_PCAlarm)i).ToString().Replace("_", " ")
                                             );

                                cmdText = string.Format("INSERT INTO {0}({1},{2},{3}) VALUES('{4}','{5}','{6}')", e_DBTable.Alarm,
                                                                                                                  e_DBTable_Alarm.StartTime,
                                                                                                                  e_DBTable_Alarm.Code,
                                                                                                                  e_DBTable_Alarm.Name,
                                                                                                                  alarmTime,
                                                                                                                  string.Format("PC{0}", i),
                                                                                                                  ((e_PCAlarm)i).ToString().Replace("_", " ")
                                                       );

                                GlobalFunction.DB.MySQL.Query(cmdText);
                            }
                            else
                            {
                                cmdText = string.Format("UPDATE {0} SET {1}='{2}' WHERE {3} IS NULL AND {4}='{5}'", e_DBTable.Alarm,
                                                                                                                    e_DBTable_Alarm.EndTime, DateTime.Now.ToString("yyyyMMddHHmmss"),
                                                                                                                    e_DBTable_Alarm.EndTime,
                                                                                                                    e_DBTable_Alarm.Code, string.Format("PC{0}", i)
                                                       );

                                GlobalFunction.DB.MySQL.Query(cmdText);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
                }

                System.Threading.Thread.Sleep(100);
            }
        }

        #region PLC
        private System.Threading.Thread threadPLC = null;
        private bool isThreadPLC = false;
        private void ProcessPLC()
        {
            const short mask = 0x0001;
            short value;

            Stopwatch stopwatch = new Stopwatch();

            while (isThreadPLC)
            {
                try
                {
                    if (GlobalDevice.PLC.Status != 0)
                    {
                        btn_Disconnect_PLC_Click(null, null);

                        btn_Connect_PLC_Click(null, null);
                    }
                    else
                    {
                        stopwatch.Restart();

                        #region F_Alarm
                        GlobalDevice.PLC.Status = GlobalDevice.PLC.MX.ReadDeviceBlock2(GlobalDevice.PLC.F_Alarm.StartAddress,
                                                                                       GlobalDevice.PLC.F_Alarm.Value.Length,
                                                                                   out GlobalDevice.PLC.F_Alarm.Value[0]
                                                                                      );

                        if (GlobalDevice.PLC.Status != 0) continue;

                        for (int word = 0; word < GlobalDevice.PLC.F_Alarm.Value.Length; word++)
                        {
                            for (int bit = 0; bit < 16; bit++)
                            {
                                GlobalDevice.PLC.F_Alarm.Data[word * 16 + bit] = (((GlobalDevice.PLC.F_Alarm.Value[word] >> bit) & mask) == mask ? true : false);
                            }
                        }
                        #endregion
                        #region B_IN
                        GlobalDevice.PLC.Status = GlobalDevice.PLC.MX.ReadDeviceBlock2(GlobalDevice.PLC.B_IN.StartAddress,
                                                                                       GlobalDevice.PLC.B_IN.Value.Length,
                                                                                   out GlobalDevice.PLC.B_IN.Value[0]
                                                                                      );

                        if (GlobalDevice.PLC.Status != 0) continue;

                        for (int word = 0; word < GlobalDevice.PLC.B_IN.Value.Length; word++)
                        {
                            for (int bit = 0; bit < 16; bit++)
                            {
                                GlobalDevice.PLC.B_IN.Data[word * 16 + bit] = (((GlobalDevice.PLC.B_IN.Value[word] >> bit) & mask) == mask ? true : false);
                            }
                        }
                        #endregion
                        #region B_OUT
                        for (int word = 0; word < GlobalDevice.PLC.B_OUT.Value.Length; word++)
                        {
                            value = 0;
                            for (int bit = 0; bit < 16; bit++)
                            {
                                value += (short)((GlobalDevice.PLC.B_OUT.Data[word * 16 + bit] ? 1 : 0) * Math.Pow(2, bit));
                            }
                            GlobalDevice.PLC.B_OUT.Value[word] = value;
                        }

                        GlobalDevice.PLC.Status = GlobalDevice.PLC.MX.WriteDeviceBlock2(GlobalDevice.PLC.B_OUT.StartAddress,
                                                                                        GlobalDevice.PLC.B_OUT.Value.Length,
                                                                                    ref GlobalDevice.PLC.B_OUT.Value[0]
                                                                                       );

                        if (GlobalDevice.PLC.Status != 0) continue;
                        #endregion
                        #region R_IN
                        GlobalDevice.PLC.Status = GlobalDevice.PLC.MX.ReadDeviceBlock2(GlobalDevice.PLC.R_IN.StartAddress,
                                                                                       GlobalDevice.PLC.R_IN.Value.Length,
                                                                                   out GlobalDevice.PLC.R_IN.Value[0]
                                                                                      );

                        if (GlobalDevice.PLC.Status != 0) continue;
                        #endregion
                        #region R_OUT
                        GlobalDevice.PLC.Status = GlobalDevice.PLC.MX.WriteDeviceBlock2(GlobalDevice.PLC.R_OUT.StartAddress,
                                                                                        GlobalDevice.PLC.R_OUT.Value.Length,
                                                                                    ref GlobalDevice.PLC.R_OUT.Value[0]
                                                                                       );
                        #endregion

                        SetToolLabelText(conn_PLC_time, string.Format("{0} [msec]", stopwatch.ElapsedMilliseconds));
                    }
                }
                catch (Exception ex)
                {
                    Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
                }

                System.Threading.Thread.Sleep(100);
            }
        }

        private System.Threading.Thread threadPLCAlive = null;
        private bool isThreadPLCAlive = false;
        private void ProcessPLCAlive()
        {
            while (isThreadPLCAlive)
            {
                try
                {
                    if (GlobalDevice.PLC.R_OUT.Value[(int)e_Device_PLC_R_OUT.R1600_ALIVE] == 0)
                    {
                        GlobalDevice.PLC.R_OUT.Value[(int)e_Device_PLC_R_OUT.R1600_ALIVE] = 1;
                    }
                    else
                    {
                        GlobalDevice.PLC.R_OUT.Value[(int)e_Device_PLC_R_OUT.R1600_ALIVE] = 0;
                    }
                }
                catch (Exception ex)
                {
                    Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
                }

                System.Threading.Thread.Sleep(1000);
            }
        }
        #endregion

        #region RMC
        private System.Threading.Thread threadRMC = null;
        private bool isThreadRMC = false;
        private void ProcessRMC()
        {
            #region var

            // common
            int fileOffset = 0;
            int startElement = 50;
            int element;

            // download
            string value;

            // upload
            int TestCnt = 0;
            Dictionary<string, string[]> backup = new Dictionary<string, string[]>();

            #endregion

            while (isThreadRMC)
            {
                try
                {
                    if (GlobalDevice.RMC.Instance != null)
                    {
                        if (GlobalDevice.RMC.Instance.IsConnected)
                        {
                            if (isDownload ||
                                isUpload
                               )
                            {
                                try
                                {
                                    if (isDownload)
                                    {
                                        SetToolProgressBarMinMax(pb_RMC, 0, 10);

                                        #region Initialize
                                        for (int i = 0; i < 10; i++)
                                        {
                                            #region fileOffset, startElement set
                                                 if (i == 0) { fileOffset = 0; startElement =  50; }
                                            else if (i == 1) { fileOffset = 0; startElement = 100; }
                                            else if (i == 2) { fileOffset = 0; startElement = 150; }
                                            else if (i == 3) { fileOffset = 0; startElement = 200; }
                                            else if (i == 4) { fileOffset = 0; startElement = 250; }
                                            else if (i == 5) { fileOffset = 1; startElement =  44; }
                                            else if (i == 6) { fileOffset = 1; startElement =  94; }
                                            else if (i == 7) { fileOffset = 1; startElement = 144; }
                                            else if (i == 8) { fileOffset = 1; startElement = 194; }
                                            else if (i == 9) { fileOffset = 1; startElement = 244; }
                                            #endregion

                                            for (int j = 0; j < 50; j++)
                                            {
                                                element = startElement + j;
                                                if (element > 255)
                                                {
                                                    fileOffset++;
                                                    element -= 256;
                                                }

                                                GlobalDevice.RMC.Instance.SetCurValue(fileOffset, element, "0.0");
                                            }

                                            SetToolProgressBarValue(pb_RMC, i + 1);
                                        }
                                        #endregion

                                        if (GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Count > 0)
                                        {
                                            SetToolProgressBarMinMax(pb_RMC, 0, GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Count);
                                        }

                                        for (int i = 0; i < GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Count; i++)
                                        {
                                            #region fileOffset, startElement set
                                                 if (i == 0) { fileOffset = 0; startElement =  50; }
                                            else if (i == 1) { fileOffset = 0; startElement = 100; }
                                            else if (i == 2) { fileOffset = 0; startElement = 150; }
                                            else if (i == 3) { fileOffset = 0; startElement = 200; }
                                            else if (i == 4) { fileOffset = 0; startElement = 250; }
                                            else if (i == 5) { fileOffset = 1; startElement =  44; }
                                            else if (i == 6) { fileOffset = 1; startElement =  94; }
                                            else if (i == 7) { fileOffset = 1; startElement = 144; }
                                            else if (i == 8) { fileOffset = 1; startElement = 194; }
                                            else if (i == 9) { fileOffset = 1; startElement = 244; }
                                            #endregion

                                            int cmdIdx = Array.IndexOf(Enum.GetNames(typeof(e_Command)), GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(i + 1).ToString()][(int)e_Parameter_Recipe.Command]);
                                            if (cmdIdx < 0)
                                            {
                                                GlobalValue.PCAlarm[(int)e_PCAlarm.ERROR_DOWNLOAD_COMMAND] = true;
                                                break;
                                            }

                                            #region SetCurrentValue (Axis, Command)
                                            GlobalDevice.RMC.Instance.SetCurValue(fileOffset, startElement, GetAxis().ToString());

                                            element = startElement + 1;
                                            if (element > 255)
                                            {
                                                fileOffset++;
                                                element -= 256;
                                            }

                                            GlobalDevice.RMC.Instance.SetCurValue(fileOffset, element, GetCommand(cmdIdx).ToString());
                                            #endregion

                                            string[] vs1 = GlobalFunction.GetNames((e_Command)cmdIdx);

                                            for (int j = 0; j < vs1.Length; j++)
                                            {
                                                string[] vs2 = vs1[j].Split('_');

                                                if (vs2[(int)e_Command_Param.Offset] != "Offset" &&
                                                    vs2[(int)e_Command_Param._____Name_____] != "Name"
                                                   )
                                                {
                                                    if (vs2[(int)e_Command_Param.DataType] == "ComboBox")
                                                    {
                                                        int comboBoxIdx = Array.IndexOf(vs2, GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(i + 1).ToString()][(int)e_Parameter_Recipe.Param0 + j]) - ((int)e_Command_Param.DataType + 1);

                                                        value = comboBoxIdx.ToString();
                                                    }
                                                    else if (vs2[(int)e_Command_Param.DataType] == "CheckBox")
                                                    {
                                                        value = (GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(i + 1).ToString()][(int)e_Parameter_Recipe.Param0 + j] == "False" ? "0" : "1");
                                                    }
                                                    else
                                                    {
                                                        value = GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(i + 1).ToString()][(int)e_Parameter_Recipe.Param0 + j];
                                                    }

                                                    // TODO : e_Command
                                                    switch ((e_Command)cmdIdx)
                                                    {
                                                        // TODO : e_Command_Ramp
                                                        case e_Command.Ramp:
                                                            break;
                                                        // TODO : e_Command_Test
                                                        case e_Command.Test:
                                                            if (vs2[(int)e_Command_Param._____Name_____] == "Type")
                                                            {
                                                                value = GetType(GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(i + 1).ToString()][(int)e_Parameter_Recipe.Param0 + j]).ToString();
                                                            }
                                                            else if (vs2[(int)e_Command_Param._____Name_____] == "Mode")
                                                            {
                                                                value = GetMode(GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(i + 1).ToString()][(int)e_Parameter_Recipe.Param0 + j]).ToString();
                                                            }
                                                            else if (vs2[(int)e_Command_Param._____Name_____] == "LowerSpaceLimitSpaceCheck")
                                                            {
                                                                value = GetLowerLimitCheck(GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(i + 1).ToString()][(int)e_Parameter_Recipe.Param0 + j]).ToString();
                                                            }
                                                            break;
                                                        // TODO : e_Command_Link
                                                        case e_Command.Link:
                                                            break;
                                                    }

                                                    element = startElement + Convert.ToInt32(vs2[(int)e_Command_Param.Offset]);
                                                    if (element > 255)
                                                    {
                                                        fileOffset++;
                                                        element -= 256;
                                                    }

                                                    GlobalDevice.RMC.Instance.SetCurValue(fileOffset, element, value);
                                                }
                                            }

                                            SetToolProgressBarValue(pb_RMC, i + 1);
                                        }

                                        GlobalDevice.RMC.Instance.SetCurValue(0, 49, GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Count.ToString()); // TestCnt download
                                    }
                                    else if (isUpload)
                                    {
                                        TestCnt = Convert.ToInt32(GlobalDevice.RMC.Instance.GetCurValueR(0, 49));

                                        if (TestCnt > 0)
                                        {
                                            #region 백업
                                            backup.Clear();
                                            foreach (string key in GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Keys)
                                            {
                                                backup.Add(key, GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][key]);
                                            }
                                            #endregion

                                            GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Clear();

                                            SetToolProgressBarMinMax(pb_RMC, 0, TestCnt);

                                            for (int i = 0; i < TestCnt; i++)
                                            {
                                                #region fileOffset, startElement set
                                                     if (i == 0) { fileOffset = 0; startElement =  50; }
                                                else if (i == 1) { fileOffset = 0; startElement = 100; }
                                                else if (i == 2) { fileOffset = 0; startElement = 150; }
                                                else if (i == 3) { fileOffset = 0; startElement = 200; }
                                                else if (i == 4) { fileOffset = 0; startElement = 250; }
                                                else if (i == 5) { fileOffset = 1; startElement =  44; }
                                                else if (i == 6) { fileOffset = 1; startElement =  94; }
                                                else if (i == 7) { fileOffset = 1; startElement = 144; }
                                                else if (i == 8) { fileOffset = 1; startElement = 194; }
                                                else if (i == 9) { fileOffset = 1; startElement = 244; }
                                                #endregion

                                                #region Get Command
                                                element = startElement + 1;
                                                if (element > 255)
                                                {
                                                    fileOffset++;
                                                    element -= 256;
                                                }

                                                int cmdIdx = UploadCommand(GlobalDevice.RMC.Instance.GetCurValueD(fileOffset, element));
                                                if (cmdIdx < 0)
                                                {
                                                    GlobalValue.PCAlarm[(int)e_PCAlarm.ERROR_UPLOAD_COMMAND] = true;
                                                    break;
                                                }
                                                #endregion

                                                #region vs1
                                                string[] vs1 = GlobalFunction.GetNames(e_Parameter.Recipe); // value

                                                // value 초기화
                                                for (int idx = 0; idx < vs1.Length; idx++)
                                                {
                                                    vs1[idx] = "0";
                                                }

                                                vs1[(int)e_Parameter_Recipe.No] = (GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Count + 1).ToString(); // key
                                                vs1[(int)e_Parameter_Recipe.Command] = Enum.GetNames(typeof(e_Command))[cmdIdx]; // cmd
                                                #endregion

                                                string[] vs2 = GlobalFunction.GetNames((e_Command)cmdIdx);

                                                for (int j = 0; j < vs2.Length; j++)
                                                {
                                                    string[] vs3 = vs2[j].Split('_');

                                                    if (vs3[(int)e_Command_Param.Offset] != "Offset" &&
                                                        vs3[(int)e_Command_Param._____Name_____] != "Name"
                                                       )
                                                    {
                                                        element = startElement + Convert.ToInt32(vs3[(int)e_Command_Param.Offset]);
                                                        if (element > 255)
                                                        {
                                                            fileOffset++;
                                                            element -= 256;
                                                        }

                                                        if (vs3[(int)e_Command_Param.DataType] == "CheckBox")
                                                        {
                                                            vs1[(int)e_Parameter_Recipe.Param0 + j] = (GlobalDevice.RMC.Instance.GetCurValueR(fileOffset, element) < 1 ? "False" : "True");
                                                        }
                                                        else
                                                        {
                                                            vs1[(int)e_Parameter_Recipe.Param0 + j] = GlobalDevice.RMC.Instance.GetCurValueR(fileOffset, element).ToString();
                                                        }

                                                        // TODO : e_Command
                                                        switch ((e_Command)cmdIdx)
                                                        {
                                                            // TODO : e_Command_Ramp
                                                            case e_Command.Ramp:
                                                                break;
                                                            // TODO : e_Command_Test
                                                            case e_Command.Test:
                                                                if (vs3[(int)e_Command_Param._____Name_____] == "Type")
                                                                {
                                                                    vs1[(int)e_Parameter_Recipe.Param0 + j] = UploadType(GlobalDevice.RMC.Instance.GetCurValueD(fileOffset, element));
                                                                }
                                                                else if (vs3[(int)e_Command_Param._____Name_____] == "Mode")
                                                                {
                                                                    vs1[(int)e_Parameter_Recipe.Param0 + j] = UploadMode(GlobalDevice.RMC.Instance.GetCurValueD(fileOffset, element));
                                                                }
                                                                else if (vs3[(int)e_Command_Param._____Name_____] == "LowerSpaceLimitSpaceCheck")
                                                                {
                                                                    vs1[(int)e_Parameter_Recipe.Param0 + j] = UploadLowerLimitCheck(GlobalDevice.RMC.Instance.GetCurValueD(fileOffset, element));
                                                                }
                                                                break;
                                                            // TODO : e_Command_Link
                                                            case e_Command.Link:
                                                                break;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (vs3[(int)e_Command_Param.DataType] == "Title")
                                                        {
                                                            vs1[(int)e_Parameter_Recipe.Param0 + j] = string.Empty;
                                                        }
                                                    }

                                                    // TODO : e_Command
                                                    switch ((e_Command)cmdIdx)
                                                    {
                                                        // TODO : e_Command_Ramp
                                                        case e_Command.Ramp:
                                                            break;
                                                        // TODO : e_Command_Test
                                                        case e_Command.Test:
                                                            if (vs3[(int)e_Command_Param._____Name_____] == "Amplitude")
                                                            {
                                                                double offset = Convert.ToDouble(vs1[(int)e_Parameter_Recipe.Param0 + (int)e_Index_Test.Offset]);
                                                                double amplitude = Convert.ToDouble(vs1[(int)e_Parameter_Recipe.Param0 + (int)e_Index_Test.Amplitude]);

                                                                vs1[(int)e_Parameter_Recipe.Param0 + (int)e_Index_Test.CWTarget] = (amplitude + offset).ToString();
                                                                vs1[(int)e_Parameter_Recipe.Param0 + (int)e_Index_Test.CCWTarget] = (-amplitude + offset).ToString();
                                                            }
                                                            break;
                                                        // TODO : e_Command_Link
                                                        case e_Command.Link:
                                                            break;
                                                    }
                                                }

                                                GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Add(vs1[(int)e_Parameter_Recipe.No], vs1);

                                                SetToolProgressBarValue(pb_RMC, i + 1);
                                            }
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));

                                    if (isUpload) // 업로드 중에 catch가 발생하였으면 데이터를 원복 해주기 위함
                                    {
                                        GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Clear();
                                        foreach (string key in backup.Keys)
                                        {
                                            GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Add(key, backup[key]);
                                        }
                                    }
                                }

                                if (isDownload) isDownload  = false;

                                if (isUpload) // 업로드 완료 시, dgv 갱신
                                {
                                    isUpload = false;

                                    UploadDataGridView();
                                }
                            }
                            else
                            {
                                TestCount = Convert.ToInt32(GlobalDevice.RMC.Instance.GetCurValueR(0, 8));

                                if (GlobalDevice.RMC.Instance != null)
                                {
                                    RMC_IN = GlobalDevice.RMC.Instance.GetCurValueD(0, 0);

                                    isAuto        = (RMC_IN & (1 << 0)) != 0 ? true : false;
                                    isManual      = (RMC_IN & (1 << 1)) != 0 ? true : false;
                                    isTestStart   = (RMC_IN & (1 << 2)) != 0 ? true : false;
                                    isTestStop    = (RMC_IN & (1 << 3)) != 0 ? true : false;
                                    isEmergency   = (RMC_IN & (1 << 4)) != 0 ? true : false;
                                }

                                if (GlobalDevice.RMC.Instance != null)
                                {
                                    RMC_OUT = GlobalDevice.RMC.Instance.GetCurValueD(0, 1);

                                    isReady         = (RMC_OUT & (1 <<  0)) != 0 ? true : false;
                                    isHomePosOK     = (RMC_OUT & (1 <<  1)) != 0 ? true : false;
                                    isTestComplete  = (RMC_OUT & (1 <<  4)) != 0 ? true : false;
                                }

                                #region 테스트 Time 측정 시작 및 중지

                                if (isEmergency)
                                {
                                    if (swTestTime.IsRunning) { swTestTime.Stop(); }
                                }
                                else
                                {
                                    if (TestStop)
                                    {
                                        if (swTestTime.IsRunning) { swTestTime.Stop(); }
                                    }
                                    else if (TestStart)
                                    {
                                        if (swTestTime.IsRunning == false) { swTestTime.Restart(); }
                                    }
                                }

                                #endregion

                                if (GlobalDevice.RMC.Instance != null)
                                {
                                    RMC_Flag = GlobalDevice.RMC.Instance.GetCurValueD(0, 2);

                                    isGraphOn     = (RMC_Flag & (1 <<  0)) != 0 ? true : false;
                                    isGraphClear  = (RMC_Flag & (1 <<  1)) != 0 ? true : false;
                                    isTestOK      = (RMC_Flag & (1 <<  2)) != 0 ? true : false;
                                    isTestNG      = (RMC_Flag & (1 <<  3)) != 0 ? true : false;
                                    isPosPosLimit = (RMC_Flag & (1 << 18)) != 0 ? true : false;
                                    isPosFrcLimit = (RMC_Flag & (1 << 19)) != 0 ? true : false;
                                    isNegPosLimit = (RMC_Flag & (1 << 16)) != 0 ? true : false;
                                    isNegFrcLimit = (RMC_Flag & (1 << 17)) != 0 ? true : false;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
                }

                System.Threading.Thread.Sleep(10);
            }
        }

        private int GetAxis()
        {
            int result = 0;
            result |= (1 << 0); // Axis0
            return result;
        }
        private int GetCommand(int value)
        {
            int result = 0;
            // TODO : e_Command
            switch ((e_Command)value)
            {
                case e_Command.Ramp: result |= (1 << 1); break;
                case e_Command.Test: result |= (1 << 5); break;
                case e_Command.Link: result |= (1 << 3); break;
            }
            return result;
        }
        private int GetType(string value)
        {
            int result = 0;
            // TODO : GetType
            switch (value)
            {
                case "Sine":      result |= (1 << 0); break;
                //case "Triangle":  result |= (1 << 1); break;
                case "Square":    result |= (1 << 2); break;
                //case "Complex":   result |= (1 << 3); break;
            }
            return result;
        }
        private int GetMode(string value)
        {
            int result = 0;
            // TODO : GetMode
            switch (value)
            {
                case "Position":  result |= (1 << 0); break;
                case "Force":     result |= (1 << 1); break;
            }
            return result;
        }
        private int GetLowerLimitCheck(string value)
        {
            int result = 0;
            // TODO : GetLowerLimitCheck
            switch (value)
            {
                case "Position": result |= (1 << 0); break;
                case "Force": result |= (1 << 1); break;
            }
            return result;
        }

        private int UploadCommand(int value)
        {
            int result = -1;
            // TODO : e_Command
            if (value == (1 << 1))
            {
                result = (int)e_Command.Ramp;
            }
            else if (value == (1 << 5))
            {
                result = (int)e_Command.Test;
            }
            else if (value == (1 << 3))
            {
                result = (int)e_Command.Link;
            }
            return result;
        }
        private string UploadType(int value)
        {
            string result = string.Empty;
            // TODO : GetType
            if (value == (1 << 0))
            {
                result = "Sine";
            }
            //else if (value == (1 << 1))
            //{
            //    result = "Triangle";
            //}
            else if (value == (1 << 2))
            {
                result = "Square";
            }
            //else if (value == (1 << 3))
            //{
            //    result = "Complex";
            //}
            return result;
        }
        private string UploadMode(int value)
        {
            string result = string.Empty;
            // TODO : GetMode
            if (value == (1 << 0))
            {
                result = "Position";
            }
            else if (value == (1 << 1))
            {
                result = "Force";
            }
            return result;
        }
        private string UploadLowerLimitCheck(int value)
        {
            string result = string.Empty;
            // TODO : GetLowerLimitCheck
            if (value == (1 << 0))
            {
                result = "Position";
            }
            else if (value == (1 << 1))
            {
                result = "Force";
            }
            else
            {
                result = "None";
            }
            return result;
        }
        #endregion

        #region GRAPH

        private System.Threading.Thread threadUpdateGraph = null;
        private bool isThreadUpdateGraph = false;
        private void ProcessUpdateGraph()
        {
            GraphData graphData;

            bool edgeGraphClear = false;

            while (isThreadUpdateGraph)
            {
                try
                {
                    if (isGraphClear)
                    {
                        if (GlobalDevice.RMC.Instance.GraphDatasByDateTime[(int)e_Axis.Axis0].Count > 0) { GlobalDevice.RMC.Instance.GraphDatasByDateTime[(int)e_Axis.Axis0].Clear(); }

                        if (ct_Graph.Series[(int)e_Chart_Series.ActualPosition].Points.Count > 0) { ClearChartPoints(ct_Graph, (int)e_Chart_Series.ActualPosition); }
                        if (ct_Graph.Series[(int)e_Chart_Series.ActualForce   ].Points.Count > 0) { ClearChartPoints(ct_Graph, (int)e_Chart_Series.ActualForce   ); }

                        if (edgeGraphClear != isGraphClear)
                        {
                            edgeGraphClear = isGraphClear;

                            if (edgeGraphClear)
                            {
                                if (GlobalValue.Parameter[(int)e_Parameter.Log]["1"][(int)e_Parameter_Log.ActualPosFrc] == "1")
                                {
                                    Log.Write(MethodBase.GetCurrentMethod().Name, "======================================================================");
                                }
                            }
                        }
                    }
                    else
                    {
                        // RMC 클래스 내 스레드에서 조건 확인 후 큐에 데이터를 추가하기 때문에 카운트만 확인하면 됨
                        if (GlobalDevice.RMC.Instance.GraphDatasByDateTime[(int)e_Axis.Axis0].Count > 0)
                        {
                            graphData = GlobalDevice.RMC.Instance.GraphDatasByDateTime[(int)e_Axis.Axis0].Dequeue();

                            AddPointToChart(ct_Graph, (int)e_Chart_Series.ActualPosition, graphData.dateTime.ToOADate(), graphData.actualPos);
                            AddPointToChart(ct_Graph, (int)e_Chart_Series.ActualForce   , graphData.dateTime.ToOADate(), graphData.actualFrc);

                            if (GlobalValue.Parameter[(int)e_Parameter.Log]["1"][(int)e_Parameter_Log.ActualPosFrc] == "1")
                            {
                                Log.Write(MethodBase.GetCurrentMethod().Name, string.Format("{0}\t{1}", graphData.actualPos, graphData.actualFrc));
                            }
                        }
                    }

                    System.Threading.Thread.Sleep(Convert.ToInt32(GlobalValue.Parameter[(int)e_Parameter.RMC]["1"][(int)e_Parameter_RMC.Interval_Graph_msec]));
                }
                catch (Exception ex)
                {
                    Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
                }

                //System.Threading.Thread.Sleep(Convert.ToInt32(GlobalValue.Parameter[(int)e_Parameter.RMC]["1"][(int)e_Parameter_RMC.Interval_Graph_msec]));
            }
        }

        #endregion

        #region Invoke

        private void ShowAlarmForm(string alarmTime, string alarmCode, string alarmName)
        {
            try
            {
                Log.Write("Alarm", string.Format("Code=[{0}] /  Name=[{1}]", alarmCode, alarmName));

                if (GlobalValue.Form.FormAlarm == null)
                {
                    GlobalValue.Form.FormAlarm = new FrmAlarm(alarmTime, alarmCode, alarmName);

                    Invoke(new MethodInvoker(GlobalValue.Form.FormAlarm.Show));
                }
                else
                {
                    GlobalValue.Form.FormAlarm.AlarmCode = alarmCode;
                    GlobalValue.Form.FormAlarm.AlarmName = alarmName;

                    GlobalValue.Form.FormAlarm.AlarmTime = alarmTime;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }

        private void SetToolLabelText(ToolStripStatusLabel label, string text)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate () { SetToolLabelText(label, text); }));
                }
                else
                {
                    label.Text = text;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }

        private void SetToolProgressBarMinMax(ToolStripProgressBar progressBar, int min, int max)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate () { SetToolProgressBarMinMax(progressBar, min, max); }));
                }
                else
                {
                    progressBar.Minimum = min;
                    progressBar.Maximum = max;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }
        private void SetToolProgressBarValue(ToolStripProgressBar progressBar, int value)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate () { SetToolProgressBarValue(progressBar, value); }));
                }
                else
                {
                    progressBar.Value = value;

                    SetToolLabelText(pb_RMC_percent, string.Format("{0:0.00} [%]", (double)progressBar.Value / progressBar.Maximum * 100));

                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }

        private void UploadDataGridView()
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate () { UploadDataGridView(); }));
                }
                else
                {
                    dgv_Recipe_Copy.Rows.Clear();

                    dgv_Recipe_Copy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                    for (int i = 0; i < GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Count; i++)
                    {
                        dgv_Recipe_Copy.Rows.Add(GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(i + 1).ToString()]);

                        #region ComboBox
                        DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();

                        //comboBoxCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

                        comboBoxCell.Items.Add("0");
                        comboBoxCell.Items.Add("1");

                        comboBoxCell.Value = GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(i + 1).ToString()][(int)e_Parameter_Recipe.Skip];

                        dgv_Recipe_Copy.Rows[i].Cells[(int)e_Parameter_Recipe.Skip] = comboBoxCell;
                        #endregion
                    }

                    dgv_Recipe_Copy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    dgv_Command_Param.Rows.Clear();

                    InitializeGraphPreview();
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }

        private void SetToolLabelBackColor(ToolStripStatusLabel label, Color color)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate () { SetToolLabelBackColor(label, color); }));
                }
                else
                {
                    label.BackColor = color;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }

        private void SetControlVisible(Control control, bool value)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate () { SetControlVisible(control, value); }));
                }
                else
                {
                    control.Visible = value;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }
        private void SetControlDock(Control control, DockStyle style)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate () { SetControlDock(control, style); }));
                }
                else
                {
                    control.Dock = style;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }

        private void SetLabelText(Label label, string text)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate () { SetLabelText(label, text); }));
                }
                else
                {
                    label.Text = text;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }
        private void SetLabelBackColor(Label label, Color color)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate () { SetLabelBackColor(label, color); }));
                }
                else
                {
                    label.BackColor = color;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }

        private void ClearChartPoints(Chart chart, int series)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate () { ClearChartPoints(chart, series); }));
                }
                else
                {
                    chart.Series[series].Points.Clear();
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }

        private void AddPointToChart(Chart chart, int series, double xValue, double yValue)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate () { AddPointToChart(chart, series, xValue, yValue); }));
                }
                else
                {
                    if (series == (int)e_Chart_Series.ActualPosition)
                    {
                        DateTime minimum = DateTime.FromOADate(chart.ChartAreas[0].AxisX.Minimum);
                        DateTime current = DateTime.FromOADate(xValue);

                        TimeSpan diff = current - minimum;

                        if (diff.TotalSeconds >= range)
                        {
                            //double value = diff.TotalSeconds - range;

                            //chart.ChartAreas[0].AxisX.Minimum = DateTime.FromOADate(chart.ChartAreas[0].AxisX.Minimum).AddSeconds(value).ToOADate();
                            //chart.ChartAreas[0].AxisX.Maximum = DateTime.FromOADate(chart.ChartAreas[0].AxisX.Minimum).AddSeconds(range).ToOADate();

                            chart.ChartAreas[0].AxisX.Minimum = xValue;
                            chart.ChartAreas[0].AxisX.Maximum = DateTime.FromOADate(chart.ChartAreas[0].AxisX.Minimum).AddSeconds(range).ToOADate();

                            chart.Series[(int)e_Chart_Series.ActualPosition].Points.Clear();
                            chart.Series[(int)e_Chart_Series.ActualForce].Points.Clear();
                        }
                    }

                    chart.Series[series].Points.AddXY(xValue, yValue);
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }

        #endregion

        private void StartThread()
        {
            threadPLC = new System.Threading.Thread(ProcessPLC);
            threadPLC.IsBackground = true;
            isThreadPLC = true;
            threadPLC.Start();

            threadPLCAlive = new System.Threading.Thread(ProcessPLCAlive);
            threadPLCAlive.IsBackground = true;
            isThreadPLCAlive = true;
            threadPLCAlive.Start();

            threadRMC = new System.Threading.Thread(ProcessRMC);
            threadRMC.IsBackground = true;
            isThreadRMC = true;
            threadRMC.Start();

            threadUpdate = new System.Threading.Thread(ProcessUpdate);
            threadUpdate.IsBackground = true;
            isThreadUpdate = true;
            threadUpdate.Start();

            threadUpdateGraph = new System.Threading.Thread(ProcessUpdateGraph);
            threadUpdateGraph.IsBackground = true;
            threadUpdateGraph.Priority = System.Threading.ThreadPriority.Highest;
            isThreadUpdateGraph = true;
            threadUpdateGraph.Start();
        }
        private void StopThread()
        {
            isThreadAlarm        = false; try { threadAlarm      ?.Join(1000); } catch { } // FrmMain_Load에서 Start
                                                                 
            isThreadPLC          = false; try { threadPLC        ?.Join(1000); } catch { }
            isThreadPLCAlive     = false; try { threadPLCAlive   ?.Join(1000); } catch { }
            isThreadRMC          = false; try { threadRMC        ?.Join(1000); } catch { }
                                                                 
            isThreadUpdate       = false; try { threadUpdate     ?.Join(1000); } catch { }

            isThreadUpdateGraph  = false; try { threadUpdateGraph?.Join(1000); } catch { }
        }

        #endregion

        #region Timer

        #region IN/OUT
        private Timer timerUpdateInOut = null;
        private void TickUpdateInOut(object sender, EventArgs e)
        {
            timerUpdateInOut?.Stop();
            try
            {
                if (tabPage == e_TabPage._02_Signal)
                {
                    if (tabControl2.SelectedIndex == 0) // PLC
                    {
                        for (int i = 0; i < GlobalDevice.PLC.F_Alarm.Count; i++)
                        {
                            dgv_PLC_F_Alarm.Rows[i].Cells[(int)e_Parameter_PLC_Param.No + 1].Value = GlobalDevice.PLC.F_Alarm.Data[i];

                            dgv_PLC_F_Alarm.Rows[i].Cells[(int)e_Parameter_PLC_Param.No + 1].Style.BackColor = (GlobalDevice.PLC.F_Alarm.Data[i] ? Color.Lime : Color.Gainsboro);
                        }

                        for (int i = 0; i < GlobalDevice.PLC.B_IN.Count; i++)
                        {
                            dgv_PLC_B_IN.Rows[i].Cells[(int)e_Parameter_PLC_Param.No + 1].Value = GlobalDevice.PLC.B_IN.Data[i];

                            dgv_PLC_B_IN.Rows[i].Cells[(int)e_Parameter_PLC_Param.No + 1].Style.BackColor = (GlobalDevice.PLC.B_IN.Data[i] ? Color.Lime : Color.Gainsboro);
                        }

                        for (int i = 0; i < GlobalDevice.PLC.B_OUT.Count; i++)
                        {
                            dgv_PLC_B_OUT.Rows[i].Cells[(int)e_Parameter_PLC_Param.No + 1].Value = GlobalDevice.PLC.B_OUT.Data[i];

                            dgv_PLC_B_OUT.Rows[i].Cells[(int)e_Parameter_PLC_Param.No + 1].Style.BackColor = (GlobalDevice.PLC.B_OUT.Data[i] ? Color.Lime : Color.Gainsboro);
                        }

                        for (int i = 0; i < GlobalDevice.PLC.R_IN.Count; i++)
                        {
                            dgv_PLC_R_IN.Rows[i].Cells[(int)e_Parameter_PLC_Param.No + 1].Value = GlobalDevice.PLC.R_IN.Value[i];

                            dgv_PLC_R_IN.Rows[i].Cells[(int)e_Parameter_PLC_Param.No + 1].Style.BackColor = (GlobalDevice.PLC.R_IN.Value[i] != 0? Color.Lime : Color.Gainsboro);
                        }

                        for (int i = 0; i < GlobalDevice.PLC.R_OUT.Count; i++)
                        {
                            dgv_PLC_R_OUT.Rows[i].Cells[(int)e_Parameter_PLC_Param.No + 1].Value = GlobalDevice.PLC.R_OUT.Value[i];

                            dgv_PLC_R_OUT.Rows[i].Cells[(int)e_Parameter_PLC_Param.No + 1].Style.BackColor = (GlobalDevice.PLC.R_OUT.Value[i] != 0 ? Color.Lime : Color.Gainsboro);
                        }
                    }
                    else if (tabControl2.SelectedIndex == 1) // RMC
                    {
                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Command_Position].Cells[(int)e_dgv_col_RMC_Status.__Value__].Value = string.Format("{0:F3}", Convert.ToSingle(GlobalDevice.RMC.Instance.Axis_Status[(int)e_Axis.Axis0, (int)e_Axis_Status_Registers.Command_Position]));
                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Command_Position].Cells[(int)e_dgv_col_RMC_Status.Unit].Value = "[deg]";

                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Target_Position].Cells[(int)e_dgv_col_RMC_Status.__Value__].Value = string.Format("{0:F3}", Convert.ToSingle(GlobalDevice.RMC.Instance.Axis_Status[(int)e_Axis.Axis0, (int)e_Axis_Status_Registers.Target_Position]));
                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Target_Position].Cells[(int)e_dgv_col_RMC_Status.Unit].Value = "[deg]";

                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Actual_Position].Cells[(int)e_dgv_col_RMC_Status.__Value__].Value = string.Format("{0:F3}", Convert.ToSingle(GlobalDevice.RMC.Instance.Axis_Status[(int)e_Axis.Axis0, (int)e_Axis_Status_Registers.Actual_Position]));
                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Actual_Position].Cells[(int)e_dgv_col_RMC_Status.Unit].Value = "[deg]";

                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Command_Velocity].Cells[(int)e_dgv_col_RMC_Status.__Value__].Value = string.Format("{0:F3}", Convert.ToSingle(GlobalDevice.RMC.Instance.Axis_Status[(int)e_Axis.Axis0, (int)e_Axis_Status_Registers.Command_Velocity]));
                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Command_Velocity].Cells[(int)e_dgv_col_RMC_Status.Unit].Value = "[deg/s]";

                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Target_Velocity].Cells[(int)e_dgv_col_RMC_Status.__Value__].Value = string.Format("{0:F3}", Convert.ToSingle(GlobalDevice.RMC.Instance.Axis_Status[(int)e_Axis.Axis0, (int)e_Axis_Status_Registers.Target_Velocity]));
                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Target_Velocity].Cells[(int)e_dgv_col_RMC_Status.Unit].Value = "[deg/s]";

                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Actual_Velocity].Cells[(int)e_dgv_col_RMC_Status.__Value__].Value = string.Format("{0:F3}", Convert.ToSingle(GlobalDevice.RMC.Instance.Axis_Status[(int)e_Axis.Axis0, (int)e_Axis_Status_Registers.Actual_Velocity]));
                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Actual_Velocity].Cells[(int)e_dgv_col_RMC_Status.Unit].Value = "[deg/s]";

                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Command_Force].Cells[(int)e_dgv_col_RMC_Status.__Value__].Value = string.Format("{0:F3}", Convert.ToSingle(GlobalDevice.RMC.Instance.Axis_Status[(int)e_Axis.Axis0, (int)e_Axis_Status_Registers.Command_Force]));
                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Command_Force].Cells[(int)e_dgv_col_RMC_Status.Unit].Value = "[Nm]";

                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Target_Force].Cells[(int)e_dgv_col_RMC_Status.__Value__].Value = string.Format("{0:F3}", Convert.ToSingle(GlobalDevice.RMC.Instance.Axis_Status[(int)e_Axis.Axis0, (int)e_Axis_Status_Registers.Target_Force]));
                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Target_Force].Cells[(int)e_dgv_col_RMC_Status.Unit].Value = "[Nm]";

                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Actual_Force].Cells[(int)e_dgv_col_RMC_Status.__Value__].Value = string.Format("{0:F3}", Convert.ToSingle(GlobalDevice.RMC.Instance.Axis_Status[(int)e_Axis.Axis0, (int)e_Axis_Status_Registers.Actual_Force]));
                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Actual_Force].Cells[(int)e_dgv_col_RMC_Status.Unit].Value = "[Nm]";

                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Control_Output].Cells[(int)e_dgv_col_RMC_Status.__Value__].Value = string.Format("{0:F3}", Convert.ToSingle(GlobalDevice.RMC.Instance.Axis_Status[(int)e_Axis.Axis0, (int)e_Axis_Status_Registers.Control_Output]));
                        dgv_Axis0_Status.Rows[(int)e_dgv_row_RMC_Status.Control_Output].Cells[(int)e_dgv_col_RMC_Status.Unit].Value = "[V]";

                        for (int i = 0; i < Enum.GetNames(typeof(e_dgv_row_RMC_StatusBits)).Length; i++)
                        {
                            UpdateBit(dgv_Axis0_StatusBits, Convert.ToInt32(GlobalDevice.RMC.Instance.Axis_Status[(int)e_Axis.Axis0, (int)e_Axis_Status_Registers.Status_Bits]), i);
                        }

                        for (int i = 0; i < Enum.GetNames(typeof(e_dgv_row_RMC_ErrorBits)).Length; i++)
                        {
                            UpdateBit(dgv_Axis0_ErrorBits, Convert.ToInt32(GlobalDevice.RMC.Instance.Axis_Status[(int)e_Axis.Axis0, (int)e_Axis_Status_Registers.Error_Bits]), i);
                        }

                        for (int row = 0; row < 32; row++)
                        {
                            UpdateBit(dgv_RMC_IN, RMC_IN, row);
                            UpdateBit(dgv_RMC_OUT, RMC_OUT, row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
            finally
            {
                timerUpdateInOut?.Start();
            }
        }
        private void UpdateBit(DataGridView dgv, int data, int bit)
        {
            try
            {
                dgv.Rows[bit].Cells[(int)e_dgv_col_RMC_Bits.Value].Value = ((data & (1 << bit)) != 0 ? "ON" : "OFF");

                dgv.Rows[bit].Cells[(int)e_dgv_col_RMC_Bits.Value].Style.BackColor = ((data & (1 << bit)) != 0 ? Color.Lime : Color.Gainsboro);
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }
        #endregion

        private void StartTimer()
        {
            timerUpdateInOut = new Timer();
            timerUpdateInOut.Tick += new EventHandler(TickUpdateInOut);
            timerUpdateInOut.Interval = 100;
            timerUpdateInOut.Start();
        }
        private void StopTimer()
        {
            if (timerUpdateInOut != null)
            {
                if (timerUpdateInOut.Enabled)
                    timerUpdateInOut.Stop();
                timerUpdateInOut.Dispose();
                timerUpdateInOut = null;
            }
        }
        #endregion

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log.Dispose();
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GlobalFunction.MessageBox(MethodBase.GetCurrentMethod().Name, "프로그램을 종료하시겠습니까?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

            if (e.Cancel == false)
            {
                StopTimer();
                StopThread();

                GlobalDevice.Stop();
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (GlobalFunction.CheckProcess(Process.GetCurrentProcess().ProcessName))
            {
                GlobalValue.Form.FormMain = this;

                Log.MsgEvent += new Log.MsgEventHandler(LogMsgEvent);

                if (GlobalFunction.LoadParameter())
                {
                    threadAlarm = new System.Threading.Thread(ProcessAlarm);
                    threadAlarm.IsBackground = true;
                    isThreadAlarm = true;
                    threadAlarm.Start();

                    if (GlobalDevice.Start())
                    {
                        InitializeHome();
                        InitializeGraph(ct_Graph);
                        InitializeINOUT();
                        InitializeParameterSet();
                        InitializeGraphPreview();

                        StartThread();
                        StartTimer();

                        Text = GlobalValue.Parameter[(int)e_Parameter.System]["1"][(int)e_Parameter_System.Name] + $"     Version=[{Assembly.GetExecutingAssembly().GetName().Version}]";
                    }
                    else
                    {
                        GlobalValue.PCAlarm[(int)e_PCAlarm.ERROR_START_DEVICE] = true;
                    }
                }
                else
                {
                    GlobalValue.PCAlarm[(int)e_PCAlarm.ERROR_LOADING_PARAMETER] = true;
                }
            }
            else
            {
                GlobalFunction.MessageBox(MethodBase.GetCurrentMethod().Name, "프로그램이 이미 실행 중입니다", MessageBoxButtons.OK);

                exitToolStripMenuItem_Click(null, null);
            }
        }

        #region FrmMain

        private void LogMsgEvent(Log.Msg msg)
        {
            listViewLog1.AddListViewItem(msg);
        }

        private void splitter1_DoubleClick(object sender, EventArgs e)
        {
            panel1.Height = 200;
        }
        private void splitter1_MouseUp(object sender, MouseEventArgs e)
        {
            panel1.Height = panel1.Height - e.Location.Y;
        }

        #endregion

        #region 메뉴

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logToolStripMenuItem.Checked = !logToolStripMenuItem.Checked;

            panel1.Visible = logToolStripMenuItem.Checked;

            if (panel1.Visible)
            {
                splitter1_DoubleClick(null, null);
            }
        }

        private void parameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalValue.Form.FormParameter == null)
            {
                GlobalValue.Form.FormParameter = new FrmParameter();

                GlobalValue.Form.FormParameter.ShowDialog();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalValue.Form.FormLogin == null)
            {
                GlobalValue.Form.FormLogin = new FrmLogin();

                if (GlobalValue.Form.FormLogin.ShowDialog() == DialogResult.OK)
                {
                    tabControl1.TabPages.Add(tabPage8);

                    loginToolStripMenuItem.Enabled = false;
                    logoutToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage8);

            loginToolStripMenuItem.Enabled = true;
            logoutToolStripMenuItem.Enabled = false;
        }

        private void 모니터2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalValue.Form.FormFrcByPos == null)
            {
                GlobalValue.Form.FormFrcByPos = new FrmFrcByPos();
                GlobalValue.Form.FormFrcByPos.Show();
            }
            else
            {
                GlobalValue.Form.FormFrcByPos.BringToFront();
            }
        }

        #endregion

        #region HOME

        private void InitializeHome()
        {
            #region listView_Command
            listView_Command.Items.Clear();

            string[] command = Enum.GetNames(typeof(e_Command));
            for (int i = 0; i < command.Length; i++)
            {
                listView_Command.Items.Add(command[i], i);
            }
            #endregion

            InitializeHome_DataGridView();
        }
        private void InitializeHome_DataGridView()
        {
            GlobalFunction.DataGridView.SetProperties(dgv_Recipe_Copy);
            GlobalFunction.DataGridView.SetProperties(dgv_Command_Param);

            GlobalFunction.DataGridView.AddColumns(dgv_Recipe_Copy, GlobalFunction.GetNames(e_Parameter.Recipe));
            GlobalFunction.DataGridView.AddColumns(dgv_Command_Param, Enum.GetNames(typeof(e_Command_Param)));

            GlobalFunction.DataGridView.AddRows(dgv_Recipe_Copy, e_Parameter.Recipe_Copy);
        }

        private void btn_RecipeOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                #region Properties
                dialog.InitialDirectory = GlobalValue.Directory.Recipe;
                dialog.Filter = "Recipe|*.dat|All|*.*";
                #endregion

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (GlobalFunction.LoadParameter(e_Parameter.Recipe, dialog.FileName))
                    {
                        #region LastFileName
                        if (GlobalValue.Parameter[(int)e_Parameter.System]["1"][(int)e_Parameter_System.LastFileName] != dialog.FileName)
                        {
                            GlobalValue.Parameter[(int)e_Parameter.System]["1"][(int)e_Parameter_System.LastFileName] = dialog.FileName;

                            if (GlobalFunction.SaveParameter(e_Parameter.System) == false)
                            {
                                GlobalValue.PCAlarm[(int)e_PCAlarm.ERROR_SAVE_PARAMETER] = true;
                            }
                        }
                        #endregion

                        GlobalFunction.DataGridView.AddRows(dgv_Recipe_Copy, e_Parameter.Recipe_Copy);

                        dgv_Command_Param.Rows.Clear();

                        InitializeGraphPreview();
                    }
                    else
                    {
                        GlobalValue.PCAlarm[(int)e_PCAlarm.ERROR_LOADING_PARAMETER_RECIPE] = true;
                    }
                }
            }
        }

        private void btn_RecipeSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                #region Properties
                dialog.DefaultExt = "dat";
                dialog.Filter = "Recipe|*.dat|All|*.*";
                #endregion

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (GlobalFunction.UpdateRecipe())
                    {
                        if (GlobalFunction.SaveParameter(e_Parameter.Recipe, dialog.FileName))
                        {
                            #region LastFileName
                            if (GlobalValue.Parameter[(int)e_Parameter.System]["1"][(int)e_Parameter_System.LastFileName] != dialog.FileName)
                            {
                                GlobalValue.Parameter[(int)e_Parameter.System]["1"][(int)e_Parameter_System.LastFileName] = dialog.FileName;

                                if (GlobalFunction.SaveParameter(e_Parameter.System) == false)
                                {
                                    GlobalValue.PCAlarm[(int)e_PCAlarm.ERROR_SAVE_PARAMETER] = true;
                                }
                            }
                            #endregion
                        }
                        else
                        {
                            GlobalValue.PCAlarm[(int)e_PCAlarm.ERROR_SAVE_PARAMETER] = true;
                        }
                    }
                    else
                    {
                        GlobalValue.PCAlarm[(int)e_PCAlarm.ERROR_UPDATE_RECIPE] = true;
                    }
                }
            }
        }

        private void listView_Command_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_Recipe_Copy.Rows.Count < 10) // Recipe Count 제한
            {
                try
                {
                    string[] vs1 = GlobalFunction.GetNames(e_Parameter.Recipe); // value

                    // value 초기화
                    for (int i = 0; i < vs1.Length; i++)
                    {
                        vs1[i] = "0";
                    }

                    vs1[(int)e_Parameter_Recipe.No] = (GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Count + 1).ToString(); // key
                    vs1[(int)e_Parameter_Recipe.Command] = Enum.GetNames(typeof(e_Command))[listView_Command.SelectedIndices[0]]; // cmd

                    string[] vs2 = GlobalFunction.GetNames((e_Command)listView_Command.SelectedIndices[0]);

                    for (int i = 0; i < vs2.Length; i++)
                    {
                        string[] vs3 = vs2[i].Split('_');
                        // TODO : e_Command_Param
                        switch (vs3[(int)e_Command_Param.DataType])
                        {
                            case "ComboBox":  vs1[(int)e_Parameter_Recipe.Param0 + i] = vs3[(int)e_Command_Param.DataType + 1]; break;
                            case "CheckBox":  vs1[(int)e_Parameter_Recipe.Param0 + i] = "True"; break;
                            case "Title":     vs1[(int)e_Parameter_Recipe.Param0 + i] = string.Empty; break;
                        }
                    }

                    GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Add(vs1[(int)e_Parameter_Recipe.No], vs1);

                    GlobalFunction.DataGridView.AddRows(dgv_Recipe_Copy, e_Parameter.Recipe_Copy);

                    dgv_Recipe_Copy.CurrentCell = dgv_Recipe_Copy[(int)e_Parameter_Recipe.Command, GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Count - 1];

                    dgv_Recipe_Copy_CellClick(null, new DataGridViewCellEventArgs(dgv_Recipe_Copy.CurrentCell.ColumnIndex, dgv_Recipe_Copy.CurrentCell.RowIndex));
                }
                catch (Exception ex)
                {
                    Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
                }
            }
        }

        private int recipeCopyKey; // dgv_Recipe_Copy.RowIndex 기록
        private void dgv_Recipe_Copy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if ((e_Parameter_Recipe)e.ColumnIndex == e_Parameter_Recipe.Command)
                {
                    recipeCopyKey = e.RowIndex + 1;

                    AddRowsCommandParam(dgv_Command_Param, GlobalFunction.GetNames((e_Command)Array.IndexOf(Enum.GetNames(typeof(e_Command)), GlobalFunction.GetString(dgv_Recipe_Copy.Rows[e.RowIndex].Cells[(int)e_Parameter_Recipe.Command].Value))));
                }
            }
        }
        private void AddRowsCommandParam(DataGridView dgv, string[] rows)
        {
            dgv.Rows.Clear();

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            try
            {
                string value;

                for (int i = 0; i < rows.Length; i++)
                {
                    dgv.Rows.Add();

                    string[] vs = rows[i].Split('_');

                    // TODO : e_Command_Param

                    #region Index
                    dgv.Rows[i].Cells[(int)e_Command_Param.Index].Value = vs[(int)e_Command_Param.Index];
                    #endregion
                    #region Offset
                    if (vs[(int)e_Command_Param.Offset] != "Offset")
                    {
                        dgv.Rows[i].Cells[(int)e_Command_Param.Offset].Value = vs[(int)e_Command_Param.Offset];
                    }
                    #endregion
                    #region Name
                    value = vs[(int)e_Command_Param._____Name_____];
                    value = value.Replace("Space", " ");
                    value = value.Replace("Minus", "-");
                    value = value.Replace("Plus", "+");
                    value = value.Replace("LSB", "[");
                    value = value.Replace("RSB", "]");

                    dgv.Rows[i].Cells[(int)e_Command_Param._____Name_____].Value = value;
                    #endregion
                    #region Unit
                    if (vs[(int)e_Command_Param.Unit] != "Unit")
                    {
                        value = vs[(int)e_Command_Param.Unit];
                        value = value.Replace("Per", "/");

                        dgv.Rows[i].Cells[(int)e_Command_Param.Unit].Value = string.Format("[{0}]", value);
                    }
                    #endregion
                    #region DataType
                    if (vs[(int)e_Command_Param.DataType] != "DataType")
                    {
                        dgv.Rows[i].Cells[(int)e_Command_Param.DataType].Value = vs[(int)e_Command_Param.DataType];
                    }
                    #endregion

                    if (vs[(int)e_Command_Param.DataType] == "ComboBox")
                    {
                        DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();

                        for (int j = (int)e_Command_Param.DataType + 1; j < vs.Length; j++)
                        {
                            comboBoxCell.Items.Add(vs[j]);
                        }

                        dgv.Rows[i].Cells[(int)e_Command_Param._____Data_____] = comboBoxCell;
                    }
                    else if (vs[(int)e_Command_Param.DataType] == "CheckBox")
                    {
                        DataGridViewCheckBoxCell checkBoxCell = new DataGridViewCheckBoxCell();

                        dgv.Rows[i].Cells[(int)e_Command_Param._____Data_____] = checkBoxCell;
                    }

                    #region Data
                    if (vs[(int)e_Command_Param.DataType] == "CheckBox")
                    {
                        dgv.Rows[i].Cells[(int)e_Command_Param._____Data_____].Value = (GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][recipeCopyKey.ToString()][(int)e_Parameter_Recipe.Param0 + i] == "False" ? false : true);
                    }
                    else
                    {
                        dgv.Rows[i].Cells[(int)e_Command_Param._____Data_____].Value = GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][recipeCopyKey.ToString()][(int)e_Parameter_Recipe.Param0 + i];
                    }
                    #endregion

                    if (GlobalFunction.GetString(dgv.Rows[i].Cells[(int)e_Command_Param._____Name_____].Value) == "Name")
                    {
                        dgv.Rows[i].Visible = false;
                    }

                    if (GlobalFunction.GetString(dgv.Rows[i].Cells[(int)e_Command_Param.DataType].Value) == "Title")
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = Color.Black;
                        dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Yellow;
                    }

                    // Test 명령어에 Offset, Amplitude 값은 수정하지 못하게
                    if (GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][recipeCopyKey.ToString()][(int)e_Parameter_Recipe.Command] == "Test")
                    {
                        if (GlobalFunction.GetString(dgv.Rows[i].Cells[(int)e_Command_Param._____Name_____].Value) == "Offset" ||
                            GlobalFunction.GetString(dgv.Rows[i].Cells[(int)e_Command_Param._____Name_____].Value) == "Amplitude"
                           )
                        {
                            dgv.Rows[i].ReadOnly = true;
                            dgv.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgv_Command_Param_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    #region 자릿수

                    if (e.ColumnIndex == (int)e_Command_Param._____Data_____)
                    {
                        double ret;

                        switch (GlobalFunction.GetString(dgv_Command_Param.Rows[e.RowIndex].Cells[(int)e_Command_Param.DataType].Value))
                        {
                            case "D":
                                if (double.TryParse(GlobalFunction.GetString(dgv_Command_Param.Rows[e.RowIndex].Cells[(int)e_Command_Param._____Data_____].Value), out ret))
                                {
                                    dgv_Command_Param.Rows[e.RowIndex].Cells[(int)e_Command_Param._____Data_____].Value = string.Format("{0:0.0}", ret);
                                }
                                else
                                {
                                    dgv_Command_Param.Rows[e.RowIndex].Cells[(int)e_Command_Param._____Data_____].Value = "0.0";
                                }
                                break;


                            case "N":
                                if (double.TryParse(GlobalFunction.GetString(dgv_Command_Param.Rows[e.RowIndex].Cells[(int)e_Command_Param._____Data_____].Value), out ret))
                                {
                                    dgv_Command_Param.Rows[e.RowIndex].Cells[(int)e_Command_Param._____Data_____].Value = Convert.ToInt32(ret);
                                }
                                else
                                {
                                    dgv_Command_Param.Rows[e.RowIndex].Cells[(int)e_Command_Param._____Data_____].Value = "0";
                                }
                                break;
                        }

                        GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][recipeCopyKey.ToString()][(int)e_Parameter_Recipe.Param0 + e.RowIndex] = GlobalFunction.GetString(dgv_Command_Param.Rows[e.RowIndex].Cells[(int)e_Command_Param._____Data_____].Value);
                    }

                    #endregion

                    if (dgv_Command_Param.Rows.Count < Enum.GetNames(typeof(e_Command_Test)).Length) return;

                    if (GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][recipeCopyKey.ToString()][(int)e_Parameter_Recipe.Command] == "Test")
                    {
                        #region Mode에 따른 값 설정

                        if (e.RowIndex == Enum.GetNames(typeof(e_Command_Test)).Length - 1 ||
                            e.RowIndex == (int)e_Index_Test.Mode
                           )
                        {
                            string unit = string.Empty;
                            // TODO : GetMode
                            switch (GlobalFunction.GetString(dgv_Command_Param.Rows[(int)e_Index_Test.Mode].Cells[(int)e_Command_Param._____Data_____].Value))
                            {
                                case "Position": unit = "[deg]"; break;
                                case "Force": unit = "[Nm]"; break;
                            }

                            dgv_Command_Param.Rows[(int)e_Index_Test.Offset].Cells[(int)e_Command_Param.Unit].Value = unit;
                            dgv_Command_Param.Rows[(int)e_Index_Test.Amplitude].Cells[(int)e_Command_Param.Unit].Value = unit;
                            dgv_Command_Param.Rows[(int)e_Index_Test.CWTarget].Cells[(int)e_Command_Param.Unit].Value = unit;
                            dgv_Command_Param.Rows[(int)e_Index_Test.CCWTarget].Cells[(int)e_Command_Param.Unit].Value = unit;
                        }

                        #endregion

                        #region CW, CCW Target 값에 따른 Offset, Amplitude 값 설정

                        if (e.RowIndex == (int)e_Index_Test.CWTarget ||
                            e.RowIndex == (int)e_Index_Test.CCWTarget
                           )
                        {
                            double cw = Convert.ToDouble(dgv_Command_Param.Rows[(int)e_Index_Test.CWTarget].Cells[(int)e_Command_Param._____Data_____].Value);
                            double ccw = Convert.ToDouble(dgv_Command_Param.Rows[(int)e_Index_Test.CCWTarget].Cells[(int)e_Command_Param._____Data_____].Value);

                            double amplitude = (Math.Abs(cw) + Math.Abs(ccw)) / 2;
                            double offset = cw - amplitude;

                            dgv_Command_Param.Rows[(int)e_Index_Test.Offset].Cells[(int)e_Command_Param._____Data_____].Value = offset;
                            dgv_Command_Param.Rows[(int)e_Index_Test.Amplitude].Cells[(int)e_Command_Param._____Data_____].Value = amplitude;
                        }

                        #endregion

                        #region ct_Preview

                        if (e.RowIndex == Enum.GetNames(typeof(e_Command_Test)).Length - 1 ||
                            e.RowIndex == (int)e_Index_Test.Type ||
                            e.RowIndex == (int)e_Index_Test.Mode ||
                            e.RowIndex == (int)e_Index_Test.Frequency ||
                            e.RowIndex == (int)e_Index_Test.CWTarget ||
                            e.RowIndex == (int)e_Index_Test.CCWTarget
                           )
                        {
                            if (dgv_Command_Param.Rows[(int)e_Index_Test.Type].Cells[(int)e_Command_Param._____Data_____].Value != null &&
                                dgv_Command_Param.Rows[(int)e_Index_Test.Mode].Cells[(int)e_Command_Param._____Data_____].Value != null &&
                                dgv_Command_Param.Rows[(int)e_Index_Test.Offset].Cells[(int)e_Command_Param._____Data_____].Value != null &&
                                dgv_Command_Param.Rows[(int)e_Index_Test.Amplitude].Cells[(int)e_Command_Param._____Data_____].Value != null &&
                                dgv_Command_Param.Rows[(int)e_Index_Test.Frequency].Cells[(int)e_Command_Param._____Data_____].Value != null &&
                                dgv_Command_Param.Rows[(int)e_Index_Test.CWTarget].Cells[(int)e_Command_Param._____Data_____].Value != null &&
                                dgv_Command_Param.Rows[(int)e_Index_Test.CCWTarget].Cells[(int)e_Command_Param._____Data_____].Value != null
                               )
                            {
                                InitializeGraphPreview(Convert.ToDouble(GlobalFunction.GetString(dgv_Command_Param.Rows[(int)e_Index_Test.CCWTarget].Cells[(int)e_Command_Param._____Data_____].Value)),
                                                       Convert.ToDouble(GlobalFunction.GetString(dgv_Command_Param.Rows[(int)e_Index_Test.CWTarget].Cells[(int)e_Command_Param._____Data_____].Value))
                                                      );

                                // TODO : GetMode
                                switch (GlobalFunction.GetString(dgv_Command_Param.Rows[(int)e_Index_Test.Mode].Cells[(int)e_Command_Param._____Data_____].Value))
                                {
                                    case "Position": ct_Preview.Series[0].Color = Color.Red; break;
                                    case "Force": ct_Preview.Series[0].Color = Color.Black; break;
                                }

                                double amplitude = Convert.ToDouble(GlobalFunction.GetString(dgv_Command_Param.Rows[(int)e_Index_Test.Amplitude].Cells[(int)e_Command_Param._____Data_____].Value));
                                double frequency = Convert.ToDouble(GlobalFunction.GetString(dgv_Command_Param.Rows[(int)e_Index_Test.Frequency].Cells[(int)e_Command_Param._____Data_____].Value));
                                double offset = Convert.ToDouble(GlobalFunction.GetString(dgv_Command_Param.Rows[(int)e_Index_Test.Offset].Cells[(int)e_Command_Param._____Data_____].Value));

                                for (double i = 0; i <= 1; i += 0.01)
                                {
                                    switch (GlobalFunction.GetString(dgv_Command_Param.Rows[(int)e_Index_Test.Type].Cells[(int)e_Command_Param._____Data_____].Value))
                                    {
                                        case "Sine":
                                            ct_Preview.Series[0].Points.AddXY(i, amplitude * Math.Sin(2 * Math.PI * frequency * i) + offset);
                                            break;


                                        case "Square":
                                            ct_Preview.Series[0].Points.AddXY(i, amplitude * Math.Sign(Math.Sin(2 * Math.PI * frequency * i)) + offset);
                                            break;
                                    }
                                }
                            }
                        }

                        #endregion
                    }
                    else
                    {
                        InitializeGraphPreview();
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }

        private void dgv_Recipe_Copy_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgv_Recipe_Copy.Rows[e.RowIndex].Cells[(int)e_Parameter_Recipe.Skip].Value != null)
                {
                    GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(e.RowIndex + 1).ToString()][(int)e_Parameter_Recipe.Skip] = GlobalFunction.GetString(dgv_Recipe_Copy.Rows[e.RowIndex].Cells[(int)e_Parameter_Recipe.Skip].Value);
                }
            }
        }

        private void btn_Recipe_Copy_Up_Click(object sender, EventArgs e)
        {
            if (GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Count > 1) // 항목이 2개 이상일 때
            {
                if (dgv_Recipe_Copy.CurrentRow.Index >= 1) // 첫 번째 항목은 더 올릴 수 없으므로
                {
                    try
                    {
                        string keyT = GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(dgv_Recipe_Copy.CurrentRow.Index + 0).ToString()][(int)e_Parameter_Recipe.No]; // Target key
                        string keyC = GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(dgv_Recipe_Copy.CurrentRow.Index + 1).ToString()][(int)e_Parameter_Recipe.No]; // Current key

                        // 복사본 생성
                        Dictionary<string, string[]> copy = new Dictionary<string, string[]>(GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy]);

                        // 원본 초기화
                        GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Clear();

                        for (int i = 0; i < copy.Count; i++)
                        {
                            #region Swap
                            if ((i + 1).ToString() == keyT)
                            {
                                GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Add((i + 1).ToString(), copy[keyC]);
                                GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(i + 1).ToString()][(int)e_Parameter_Recipe.No] = (i + 1).ToString();
                            }
                            else if ((i + 1).ToString() == keyC)
                            {
                                GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Add((i + 1).ToString(), copy[keyT]);
                                GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(i + 1).ToString()][(int)e_Parameter_Recipe.No] = (i + 1).ToString();
                            }
                            #endregion
                            else
                            {
                                GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Add((i + 1).ToString(), copy[(i + 1).ToString()]);
                            }
                        }

                        #region Update GUI
                        int idxCol = dgv_Recipe_Copy.CurrentCell.ColumnIndex;
                        int idxRow = dgv_Recipe_Copy.CurrentCell.RowIndex - 1;

                        GlobalFunction.DataGridView.AddRows(dgv_Recipe_Copy, e_Parameter.Recipe_Copy);

                        if (idxCol >= 0 &&
                            idxRow >= 0
                           )
                        {
                            dgv_Recipe_Copy.CurrentCell = dgv_Recipe_Copy[idxCol, idxRow];
                        }

                        dgv_Recipe_Copy_CellClick(sender, new DataGridViewCellEventArgs((int)e_Parameter_Recipe.Command, idxRow));
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
                    }
                }
            }
        }

        private void btn_Recipe_Copy_Down_Click(object sender, EventArgs e)
        {
            if (GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Count > 1) // 항목이 2개 이상일 때
            {
                if (dgv_Recipe_Copy.CurrentRow.Index + 1 < GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Count) // 마지막 항목은 더 내릴 수 없으므로
                {
                    try
                    {
                        string keyT = GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(dgv_Recipe_Copy.CurrentRow.Index + 2).ToString()][(int)e_Parameter_Recipe.No]; // Target key
                        string keyC = GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(dgv_Recipe_Copy.CurrentRow.Index + 1).ToString()][(int)e_Parameter_Recipe.No]; // Current key

                        // 복사본 생성
                        Dictionary<string, string[]> copy = new Dictionary<string, string[]>(GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy]);

                        // 원본 초기화
                        GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Clear();

                        for (int i = 0; i < copy.Count; i++)
                        {
                            #region Swap
                            if ((i + 1).ToString() == keyT)
                            {
                                GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Add((i + 1).ToString(), copy[keyC]);
                                GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(i + 1).ToString()][(int)e_Parameter_Recipe.No] = (i + 1).ToString();
                            }
                            else if ((i + 1).ToString() == keyC)
                            {
                                GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Add((i + 1).ToString(), copy[keyT]);
                                GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(i + 1).ToString()][(int)e_Parameter_Recipe.No] = (i + 1).ToString();
                            }
                            #endregion
                            else
                            {
                                GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Add((i + 1).ToString(), copy[(i + 1).ToString()]);
                            }
                        }

                        #region Update GUI
                        int idxCol = dgv_Recipe_Copy.CurrentCell.ColumnIndex;
                        int idxRow = dgv_Recipe_Copy.CurrentCell.RowIndex + 1;

                        GlobalFunction.DataGridView.AddRows(dgv_Recipe_Copy, e_Parameter.Recipe_Copy);

                        if (idxCol >= 0 &&
                            idxRow >= 0
                           )
                        {
                            dgv_Recipe_Copy.CurrentCell = dgv_Recipe_Copy[idxCol, idxRow];
                        }

                        dgv_Recipe_Copy_CellClick(sender, new DataGridViewCellEventArgs((int)e_Parameter_Recipe.Command, idxRow));
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
                    }
                }
            }
        }

        private void btn_Recipe_Copy_Delete_Click(object sender, EventArgs e)
        {
            if (GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Count > 0) // 항목이 하나라도 있을 때
            {
                if (dgv_Recipe_Copy.CurrentRow.Index >= 0)
                {
                    try
                    {
                        string keyC = GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][(dgv_Recipe_Copy.CurrentRow.Index + 1).ToString()][(int)e_Parameter_Recipe.No]; // Current key

                        // 복사본 생성
                        Dictionary<string, string[]> copy = new Dictionary<string, string[]>(GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy]);

                        // 원본 초기화
                        GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Clear();

                        int key = 1;

                        for (int i = 0; i < copy.Count; i++)
                        {
                            if ((i + 1).ToString() != keyC)
                            {
                                GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy].Add(key.ToString(), copy[(i + 1).ToString()]);
                                GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][key.ToString()][(int)e_Parameter_Recipe.No] = key.ToString();

                                key++;
                            }
                        }

                        #region Update GUI
                        int idxCol = dgv_Recipe_Copy.CurrentCell.ColumnIndex;
                        int idxRow = dgv_Recipe_Copy.CurrentCell.RowIndex - 1;

                        GlobalFunction.DataGridView.AddRows(dgv_Recipe_Copy, e_Parameter.Recipe_Copy);

                        if (idxCol >= 0 &&
                            idxRow >= 0
                           )
                        {
                            dgv_Recipe_Copy.CurrentCell = dgv_Recipe_Copy[idxCol, idxRow];
                        }

                        dgv_Command_Param.Rows.Clear();

                        InitializeGraphPreview();
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
                    }
                }
            }
        }

        public bool isDownload = false;
        public bool isUpload = false;
        private bool CheckRMC()
        {
            if (isDownload ||
                isUpload
               )
            {
                return false;
            }
            return true;
        }

        private void btn_DownloadToRMC_Click(object sender, EventArgs e)
        {
            if (CheckRMC())
            {
                if (GlobalFunction.MessageBox(MethodBase.GetCurrentMethod().Name, "레시피를 RMC로 다운로드 하시겠습니까?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    isDownload = true;
                }
            }
            else
            {
                GlobalFunction.MessageBox(MethodBase.GetCurrentMethod().Name, "현재 작업이 완료된 후에 재시도 해주세요", MessageBoxButtons.OK);
            }
        }

        private void btn_UploadFromRMC_Click(object sender, EventArgs e)
        {
            if (CheckRMC())
            {
                if (GlobalFunction.MessageBox(MethodBase.GetCurrentMethod().Name, "RMC로부터 레시피를 업로드 하시겠습니까?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    isUpload = true;
                }
            }
            else
            {
                GlobalFunction.MessageBox(MethodBase.GetCurrentMethod().Name, "현재 작업이 완료된 후에 재시도 해주세요", MessageBoxButtons.OK);
            }
        }

        private void InitializeGraphPreview()
        {
            if (ct_Preview.Legends.Count > 0)
            {
                ct_Preview.Legends.Clear();
            }

            if (ct_Preview.Series.Count > 0)
            {
                ct_Preview.Series.Clear();
            }
        }
        private void InitializeGraphPreview(double YMin, double YMax)
        {
            InitializeGraphPreview();

            ct_Preview.Series.Add("Preview");

            ct_Preview.Series[0].ChartType = SeriesChartType.Line;
            ct_Preview.Series[0].BorderWidth = 1;

            #region AxisX

            ct_Preview.ChartAreas[0].AxisX.Title = "[sec]";

            ct_Preview.ChartAreas[0].AxisX.Minimum   =  -1;
            ct_Preview.ChartAreas[0].AxisX.Maximum   =   2;
            ct_Preview.ChartAreas[0].AxisX.Interval  = 0.5;

            ct_Preview.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            #endregion

            #region AxisY

            if (GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][recipeCopyKey.ToString()][(int)e_Parameter_Recipe.Param1/*Mode*/] == "Position")
            {
                ct_Preview.ChartAreas[0].AxisY.Title = "[deg]";
            }
            else if (GlobalValue.Parameter[(int)e_Parameter.Recipe_Copy][recipeCopyKey.ToString()][(int)e_Parameter_Recipe.Param1/*Mode*/] == "Force")
            {
                ct_Preview.ChartAreas[0].AxisY.Title = "[Nm]";
            }

            ct_Preview.ChartAreas[0].AxisY.Minimum   = YMin - 10;
            ct_Preview.ChartAreas[0].AxisY.Maximum   = YMax + 10;
            if (Math.Abs(YMin) > 30 ||
                Math.Abs(YMax) > 70
               )
            {
                ct_Preview.ChartAreas[0].AxisY.Interval = (Math.Abs(YMax) + Math.Abs(YMin)) / 10;
            }
            else
            {
                ct_Preview.ChartAreas[0].AxisY.Interval = 5;
            }

            ct_Preview.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            #endregion
        }

        #endregion

        #region GRAPH

        private const double range = 10; // sec (그래프 X Axis 범위)

        private void InitializeGraph(Chart chart)
        {
            if (chart.Legends.Count > 0)
            {
                chart.Legends.Clear();
            }

            if (chart.Series.Count > 0)
            {
                chart.Series.Clear();

                for (int i = 0; i < Enum.GetNames(typeof(e_Chart_Series)).Length; i++)
                {
                    chart.Series.Add(i.ToString());
                }
                chart.Series[(int)e_Chart_Series.ActualForce].YAxisType = AxisType.Secondary;

                //chart.ChartAreas[0].AxisX.LabelStyle.Font = new Font(e_Font.Tahoma.ToString(), 11F);
                chart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";

                chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chart.ChartAreas[0].AxisX.Interval = 1;

                for (int i = 0; i < chart.Series.Count; i++)
                {
                    chart.Series[i].ChartType = SeriesChartType.FastLine;
                    chart.Series[i].BorderWidth = 1; // ChartType이 Line인 경우 굵기 수정

                    chart.Series[i].XValueType = ChartValueType.DateTime;

                    switch (i)
                    {
                        case 0: chart.Series[i].Color = Color.Red;    break;
                        case 1: chart.Series[i].Color = Color.Black;  break;
                    }
                }
            }

            chart.ChartAreas[0].AxisX .LineDashStyle = ChartDashStyle.Solid;
            chart.ChartAreas[0].AxisY .LineDashStyle = ChartDashStyle.Solid;
            chart.ChartAreas[0].AxisY2.LineDashStyle = ChartDashStyle.Solid;

            chart.ChartAreas[0].AxisX .LineWidth = 1;
            chart.ChartAreas[0].AxisY .LineWidth = 1;
            chart.ChartAreas[0].AxisY2.LineWidth = 1;

            chart.ChartAreas[0].AxisX .MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chart.ChartAreas[0].AxisY .MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chart.ChartAreas[0].AxisY2.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            chart.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chart.ChartAreas[0].AxisX.Maximum = DateTime.FromOADate(chart.ChartAreas[0].AxisX.Minimum).AddSeconds(range).ToOADate();

            chart.ChartAreas[0].AxisY.Minimum   = Convert.ToDouble(num_Main_Pos_Minimum.Value);
            chart.ChartAreas[0].AxisY.Maximum   = Convert.ToDouble(num_Main_Pos_Maximum.Value);
            chart.ChartAreas[0].AxisY.Interval  = Convert.ToDouble(num_Main_Pos_Interval.Value);

            chart.ChartAreas[0].AxisY2.Minimum   = Convert.ToDouble(num_Main_Frc_Minimum.Value);
            chart.ChartAreas[0].AxisY2.Maximum   = Convert.ToDouble(num_Main_Frc_Maximum.Value);
            chart.ChartAreas[0].AxisY2.Interval  = Convert.ToDouble(num_Main_Frc_Interval.Value);

            chart.ChartAreas[0].AxisX .Title = "[Time]";
            chart.ChartAreas[0].AxisY .Title = "[deg]";
            chart.ChartAreas[0].AxisY2.Title = "[Nm]";
        }

        private void btn_CountReset_Click(object sender, EventArgs e)
        {
            if (GlobalFunction.MessageBox(MethodBase.GetCurrentMethod().Name, "카운트를 초기화 하시겠습니까?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (GlobalDevice.RMC.Instance != null)
                {
                    GlobalDevice.RMC.Instance.SetCurValue(0, 5, "0.0");
                    GlobalDevice.RMC.Instance.SetCurValue(0, 8, "0.0");
                }
            }
        }

        private void chk_PosFrc_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;

            string name = chk.Name.Substring(chk.Name.IndexOf("_") + 1);

            switch (name)
            {
                case "Position": ct_Graph.Series[(int)e_Chart_Series.ActualPosition].Enabled = chk.Checked; break;
                case "Force": ct_Graph.Series[(int)e_Chart_Series.ActualForce].Enabled = chk.Checked; break;
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //num_Main_Pos_Minimum
                //num_Main_Pos_Maximum
                //num_Main_Pos_Interval

                //num_Main_Frc_Minimum
                //num_Main_Frc_Maximum
                //num_Main_Frc_Interval

                NumericUpDown num = sender as NumericUpDown;

                switch (num.Name.Substring(9, 3))
                {
                    case "Pos":
                        switch (num.Name.Substring(13))
                        {
                            case "Minimum":   ct_Graph.ChartAreas[0].AxisY.Minimum   = Convert.ToDouble(num_Main_Pos_Minimum.Value);   break;
                            case "Maximum":   ct_Graph.ChartAreas[0].AxisY.Maximum   = Convert.ToDouble(num_Main_Pos_Maximum.Value);   break;
                            case "Interval":  ct_Graph.ChartAreas[0].AxisY.Interval  = Convert.ToDouble(num_Main_Pos_Interval.Value);  break;
                        }
                        break;


                    case "Frc":
                        switch (num.Name.Substring(13))
                        {
                            case "Minimum":   ct_Graph.ChartAreas[0].AxisY2.Minimum   = Convert.ToDouble(num_Main_Frc_Minimum.Value);   break;
                            case "Maximum":   ct_Graph.ChartAreas[0].AxisY2.Maximum   = Convert.ToDouble(num_Main_Frc_Maximum.Value);   break;
                            case "Interval":  ct_Graph.ChartAreas[0].AxisY2.Interval  = Convert.ToDouble(num_Main_Frc_Interval.Value);  break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }

        #endregion

        #region IN/OUT

        private void InitializeINOUT()
        {
            InitializeINOUT_DataGridView();
        }
        private void InitializeINOUT_DataGridView()
        {
            #region PLC
            GlobalFunction.DataGridView.SetProperties(dgv_PLC_F_Alarm);
            GlobalFunction.DataGridView.SetProperties(dgv_PLC_B_IN);
            GlobalFunction.DataGridView.SetProperties(dgv_PLC_B_OUT);
            GlobalFunction.DataGridView.SetProperties(dgv_PLC_R_IN);
            GlobalFunction.DataGridView.SetProperties(dgv_PLC_R_OUT);

            string[] array = GlobalFunction.GetNames(e_Parameter.PLC_B_IN);
            int index = (int)e_Parameter_PLC_Param.No + 1;
            string item = "Value";

            GlobalFunction.DataGridView.AddColumns(dgv_PLC_F_Alarm, GetColumns(array, index, item));
            GlobalFunction.DataGridView.AddColumns(dgv_PLC_B_IN, GetColumns(array, index, item));
            GlobalFunction.DataGridView.AddColumns(dgv_PLC_B_OUT, GetColumns(array, index, item));
            GlobalFunction.DataGridView.AddColumns(dgv_PLC_R_IN, GetColumns(array, index, item));
            GlobalFunction.DataGridView.AddColumns(dgv_PLC_R_OUT, GetColumns(array, index, item));

            GlobalFunction.DataGridView.AddRows(dgv_PLC_F_Alarm, e_Parameter.PLC_F_Alarm);
            GlobalFunction.DataGridView.AddRows(dgv_PLC_B_IN, e_Parameter.PLC_B_IN);
            GlobalFunction.DataGridView.AddRows(dgv_PLC_B_OUT, e_Parameter.PLC_B_OUT);
            GlobalFunction.DataGridView.AddRows(dgv_PLC_R_IN, e_Parameter.PLC_R_IN);
            GlobalFunction.DataGridView.AddRows(dgv_PLC_R_OUT, e_Parameter.PLC_R_OUT);
            #endregion

            #region RMC
            GlobalFunction.DataGridView.SetProperties(dgv_RMC_IN);
            GlobalFunction.DataGridView.SetProperties(dgv_RMC_OUT);
            GlobalFunction.DataGridView.SetProperties(dgv_Axis0_Status);
            GlobalFunction.DataGridView.SetProperties(dgv_Axis0_StatusBits);
            GlobalFunction.DataGridView.SetProperties(dgv_Axis0_ErrorBits);

            array = GlobalFunction.GetNames(e_Parameter.RMC_IN);
            index = (int)e_Parameter_RMC_Param.No + 1;

            GlobalFunction.DataGridView.AddColumns(dgv_RMC_IN, GetColumns(array, index, item));
            GlobalFunction.DataGridView.AddColumns(dgv_RMC_OUT, GetColumns(array, index, item));

            GlobalFunction.DataGridView.AddColumns(dgv_Axis0_Status, Enum.GetNames(typeof(e_dgv_col_RMC_Status)));
            GlobalFunction.DataGridView.AddColumns(dgv_Axis0_StatusBits, Enum.GetNames(typeof(e_dgv_col_RMC_Bits)));
            GlobalFunction.DataGridView.AddColumns(dgv_Axis0_ErrorBits, Enum.GetNames(typeof(e_dgv_col_RMC_Bits)));

            GlobalFunction.DataGridView.AddRows(dgv_RMC_IN, e_Parameter.RMC_IN);
            GlobalFunction.DataGridView.AddRows(dgv_RMC_OUT, e_Parameter.RMC_OUT);

            AddRowsRMC(dgv_Axis0_Status, Enum.GetNames(typeof(e_dgv_row_RMC_Status)));
            AddRowsRMC(dgv_Axis0_StatusBits, Enum.GetNames(typeof(e_dgv_row_RMC_StatusBits)));
            AddRowsRMC(dgv_Axis0_ErrorBits, Enum.GetNames(typeof(e_dgv_row_RMC_ErrorBits)));
            #endregion
        }
        private string[] GetColumns(string[] array, int index, string item)
        {
            var list = array.ToList();
            list.Insert(index, item);
            return list.ToArray();
        }
        private void AddRowsRMC(DataGridView dgv, string[] rows)
        {
            dgv.Rows.Clear();

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            try
            {
                for (int i = 0; i < rows.Length; i++)
                {
                    dgv.Rows.Add(rows[i].Replace("_", " "));
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgv_PLC_B_OUT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == (int)e_Parameter_PLC_Param.No + 1) // Value
                {
                    GlobalDevice.PLC.B_OUT.Data[e.RowIndex] = !GlobalDevice.PLC.B_OUT.Data[e.RowIndex];
                }
            }
        }

        private void dgv_PLC_R_OUT_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.RowIndex >= 0)
            {
                if (dgv.Rows[e.RowIndex].Cells[(int)e_Parameter_PLC_Param.No + 1].Value != null)
                {
                    GlobalDevice.PLC.R_OUT.Value[e.RowIndex] = Convert.ToInt16(GlobalFunction.GetString(dgv.Rows[e.RowIndex].Cells[(int)e_Parameter_PLC_Param.No + 1].Value));
                }
            }
        }

        private void btn_Connect_PLC_Click(object sender, EventArgs e)
        {
            if (GlobalDevice.PLC.MX != null)
            {
                GlobalDevice.PLC.MX.Close();

                GlobalDevice.PLC.MX.ActLogicalStationNumber = Convert.ToInt32(GlobalValue.Parameter[(int)e_Parameter.PLC]["1"][(int)e_Parameter_PLC.ActLogicalStationNumber]);

                GlobalDevice.PLC.Status = GlobalDevice.PLC.MX.Open();
            }
        }

        private void btn_Disconnect_PLC_Click(object sender, EventArgs e)
        {
            if (GlobalDevice.PLC.MX != null)
            {
                GlobalDevice.PLC.MX.Close();
            }
        }

        private void btn_Connect_RMC_Click(object sender, EventArgs e)
        {
            if (GlobalFunction.PingTest(GlobalValue.Parameter[(int)e_Parameter.RMC]["1"][(int)e_Parameter_RMC.IP], Convert.ToInt32(GlobalValue.Parameter[(int)e_Parameter.RMC]["1"][(int)e_Parameter_RMC.ConnectionTimeout_msec])))
            {
                if (GlobalDevice.RMC.Instance != null)
                {
                    GlobalDevice.RMC.Instance.Connect();
                }
            }
            else
            {
                GlobalValue.PCAlarm[(int)e_PCAlarm.ERROR_PING_TEST] = true;
            }
        }

        private void btn_Disconnect_RMC_Click(object sender, EventArgs e)
        {
            if (GlobalDevice.RMC.Instance != null)
            {
                GlobalDevice.RMC.Instance.Disconnect();
            }
        }

        #endregion

        #region ZERO Set

        private void btn_Set_Position_Click(object sender, EventArgs e)
        {
            if (GlobalFunction.MessageBox(MethodBase.GetCurrentMethod().Name, "Zero Position을 변경하시겠습니까?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Button btn = sender as Button;

                try
                {
                    string axis = btn.Name.Substring(4, 5);

                    switch (axis)
                    {
                        case "Axis0":
                            float[] cmd = new float[6];
                            cmd[0] = 49;
                            cmd[1] = (float)num_Axis0_Setting_Pos.Value;
                            cmd[2] = 0;
                            cmd[3] = 0;
                            cmd[4] = 0;
                            cmd[5] = 0;

                            if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCommandArea(cmd); }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
                }
            }
        }

        private void btn_Set_Force_Click(object sender, EventArgs e)
        {
            if (GlobalFunction.MessageBox(MethodBase.GetCurrentMethod().Name, "Zero Force를 변경하시겠습니까?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Button btn = sender as Button;

                try
                {
                    string axis = btn.Name.Substring(4, 5);

                    switch (axis)
                    {
                        case "Axis0":
                            float[] cmd = new float[6];
                            cmd[0] = 65;
                            cmd[1] = (float)num_Axis0_Setting_Frc.Value;
                            cmd[2] = 0;
                            cmd[3] = 0;
                            cmd[4] = 0;
                            cmd[5] = 0;

                            if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCommandArea(cmd); }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
                }
            }
        }

        private void btn_Move_Absolute_Click(object sender, EventArgs e)
        {
            if (GlobalFunction.MessageBox(MethodBase.GetCurrentMethod().Name, "Position을 이동하시겠습니까?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    float[] cmd = new float[6];
                    cmd[0] = 20;
                    cmd[1] = (float)num_Move_Position.Value;
                    cmd[2] = (float)num_Move_Speed.Value;
                    cmd[3] = (float)num_Move_Accel.Value;
                    cmd[4] = (float)num_Move_Decel.Value;
                    cmd[5] = 0;

                    if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCommandArea(cmd); }
                }
                catch (Exception ex)
                {
                    Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
                }
            }
        }

        #endregion

        #region PARAMETER Set

        private void InitializeParameterSet()
        {
            tabControl1.TabPages.Remove(tabPage8);

            loginToolStripMenuItem.Enabled = true;
            logoutToolStripMenuItem.Enabled = false;
        }

        private void btn_Position_Open_Click(object sender, EventArgs e)
        {
            // btn_Axis0_Position_G_Open
            // btn_Axis0_Position_V_Open

            Button btn = sender as Button;

            try
            {
                string axis = btn.Name.Substring(4, 5);
                string type = btn.Name.Substring(19, 1);

                switch (axis)
                {
                    case "Axis0":
                        switch (type)
                        {
                            case "G":
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_Gain_Kp.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetAxisParameter(e_Axis.Axis0, 61)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_Gain_Ki.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetAxisParameter(e_Axis.Axis0, 62)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_Gain_Kd.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetAxisParameter(e_Axis.Axis0, 63)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_Gain_KffP.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetAxisParameter(e_Axis.Axis0, 65)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_Gain_KffN.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetAxisParameter(e_Axis.Axis0, 68)); }
                                break;


                            case "V":
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_MaxVelocity.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 38)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_MaxAcc.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 39)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_MaxJogVelocity.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 40)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_ManualVelocity.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 41)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_ManualAccTime.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 42)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_HomeVelocity.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 43)); }

                                //if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_HomeAccTime.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurrentFloatValue(2, Axis0_Force_MaxVelocity)); }

                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_HomePosition.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 44)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_AutoVelocity.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 45)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_AutoAccTime.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 46)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_InPositionTolerance.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 47)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_Offset.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 48)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_FatalError.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 49)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Position_WarningError.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 50)); }
                                break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }
        private void btn_Force_Open_Click(object sender, EventArgs e)
        {
            // btn_Axis0_Force_G_Open
            // btn_Axis0_Force_V_Open

            Button btn = sender as Button;

            try
            {
                string axis = btn.Name.Substring(4, 5);
                string type = btn.Name.Substring(16, 1);

                switch (axis)
                {
                    case "Axis0":
                        switch (type)
                        {
                            case "G":
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_Gain_Kp.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetAxisParameter(e_Axis.Axis0, 81)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_Gain_Ki.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetAxisParameter(e_Axis.Axis0, 82)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_Gain_Kd.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetAxisParameter(e_Axis.Axis0, 83)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_Gain_Kff.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetAxisParameter(e_Axis.Axis0, 84)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_Gain_Krff.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetAxisParameter(e_Axis.Axis0, 85)); }
                                break;


                            case "V":
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_MaxVelocity.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 83)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_MaxAcc.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 84)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_MaxJogVelocity.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 85)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_ManualVelocity.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 86)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_ManualAccTime.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 87)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_HomeVelocity.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 88)); }

                                //if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_HomeAccTime.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurrentFloatValue(2, 38)); }

                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_HomePosition.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 89)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_AutoVelocity.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 90)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_AutoAccTime.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 91)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_InPositionTolerance.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 92)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_Offset.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 93)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_FatalError.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 94)); }
                                if (GlobalDevice.RMC.Instance != null) { num_Axis0_Force_WarningError.Value = Convert.ToDecimal(GlobalDevice.RMC.Instance.GetCurValueR(2, 95)); }
                                break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }

        private void btn_Position_Write_Click(object sender, EventArgs e)
        {
            // btn_Axis0_Position_G_Write
            // btn_Axis0_Position_V_Write

            Button btn = sender as Button;

            try
            {
                string axis = btn.Name.Substring(4, 5);
                string type = btn.Name.Substring(19, 1);

                switch (axis)
                {
                    case "Axis0":
                        switch (type)
                        {
                            case "G":
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetAxisParameter(e_Axis.Axis0, 61, num_Axis0_Position_Gain_Kp.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetAxisParameter(e_Axis.Axis0, 62, num_Axis0_Position_Gain_Ki.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetAxisParameter(e_Axis.Axis0, 63, num_Axis0_Position_Gain_Kd.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetAxisParameter(e_Axis.Axis0, 65, num_Axis0_Position_Gain_KffP.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetAxisParameter(e_Axis.Axis0, 68, num_Axis0_Position_Gain_KffN.Value.ToString()); }
                                break;


                            case "V":
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 38, num_Axis0_Position_MaxVelocity.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 39, num_Axis0_Position_MaxAcc.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 40, num_Axis0_Position_MaxJogVelocity.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 41, num_Axis0_Position_ManualVelocity.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 42, num_Axis0_Position_ManualAccTime.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 43, num_Axis0_Position_HomeVelocity.Value.ToString()); }

                                //if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurrentValue(2, Axis0_Force_MaxVelocity, num_Axis0_Position_HomeAccTime.Value.ToString()); }

                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 44, num_Axis0_Position_HomePosition.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 45, num_Axis0_Position_AutoVelocity.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 46, num_Axis0_Position_AutoAccTime.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 47, num_Axis0_Position_InPositionTolerance.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 48, num_Axis0_Position_Offset.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 49, num_Axis0_Position_FatalError.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 50, num_Axis0_Position_WarningError.Value.ToString()); }
                                break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }
        private void btn_Force_Write_Click(object sender, EventArgs e)
        {
            // btn_Axis0_Force_G_Write
            // btn_Axis0_Force_V_Write

            Button btn = sender as Button;

            try
            {
                string axis = btn.Name.Substring(4, 5);
                string type = btn.Name.Substring(16, 1);

                switch (axis)
                {
                    case "Axis0":
                        switch (type)
                        {
                            case "G":
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetAxisParameter(e_Axis.Axis0, 81, num_Axis0_Force_Gain_Kp.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetAxisParameter(e_Axis.Axis0, 82, num_Axis0_Force_Gain_Ki.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetAxisParameter(e_Axis.Axis0, 83, num_Axis0_Force_Gain_Kd.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetAxisParameter(e_Axis.Axis0, 84, num_Axis0_Force_Gain_Kff.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetAxisParameter(e_Axis.Axis0, 85, num_Axis0_Force_Gain_Krff.Value.ToString()); }
                                break;


                            case "V":
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 83, num_Axis0_Force_MaxVelocity.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 84, num_Axis0_Force_MaxAcc.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 85, num_Axis0_Force_MaxJogVelocity.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 86, num_Axis0_Force_ManualVelocity.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 87, num_Axis0_Force_ManualAccTime.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 88, num_Axis0_Force_HomeVelocity.Value.ToString()); }

                                //if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurrentValue(2, 38, num_Axis0_Force_HomeAccTime.Value.ToString()); }

                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 89, num_Axis0_Force_HomePosition.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 90, num_Axis0_Force_AutoVelocity.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 91, num_Axis0_Force_AutoAccTime.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 92, num_Axis0_Force_InPositionTolerance.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 93, num_Axis0_Force_Offset.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 94, num_Axis0_Force_FatalError.Value.ToString()); }
                                if (GlobalDevice.RMC.Instance != null) { GlobalDevice.RMC.Instance.SetCurValue(2, 95, num_Axis0_Force_WarningError.Value.ToString()); }
                                break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }

        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabPage = (e_TabPage)tabControl1.SelectedIndex;
        }
    }
}

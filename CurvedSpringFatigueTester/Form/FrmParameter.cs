using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;

using LibLog;

namespace CurvedSpringFatigueTester
{
    public partial class FrmParameter : Form
    {
        public FrmParameter()
        {
            InitializeComponent();
        }

        private void FrmParameter_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalValue.Form.FormParameter = null;
        }
        private void FrmParameter_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearTabControl(tabControl);
        }
        private void FrmParameter_Load(object sender, EventArgs e)
        {
            tabControl = tabControl1;

            InitializeTabControl(tabControl);

            TabControlSelectedIndexChanged(null, null);
        }

        private TabPage[] tabPages = null;
        private DataGridView[] dataGridViews = null;
        private TabControl tabControl = null;

        private void ClearTabControl(TabControl tab)
        {
            if (dataGridViews != null)
            {
                for (int i = 0; i < dataGridViews.Length; i++)
                {
                    if (dataGridViews[i] != null)
                    {
                        dataGridViews[i].RowPostPaint -= new DataGridViewRowPostPaintEventHandler(DataGridViewRowPostPaint);

                        dataGridViews[i].KeyUp -= new KeyEventHandler(DataGridViewKeyUp);

                        dataGridViews[i].Dispose();
                        dataGridViews[i] = null;
                    }
                }

                dataGridViews = null;
            }

            tab.SelectedIndexChanged -= new EventHandler(TabControlSelectedIndexChanged); // TabPage.Dispose() 시에 SelectedIndexChanged 이벤트가 발생되기 때문에 오류 방지를 위해 미리 이벤트 해제

            if (tabPages != null)
            {
                for (int i = 0; i < tabPages.Length; i++)
                {
                    if (tabPages[i] != null)
                    {
                        //tabPages[i].Controls.Clear(); // DataGridView.Dispose() 시에 자동으로 제거되기 때문에 필요 없음

                        tabPages[i].Dispose();
                        tabPages[i] = null;
                    }
                }

                tabPages = null;
            }

            tab.TabPages.Clear();
        }
        private void InitializeTabControl(TabControl tab)
        {
            var list = Enum.GetNames(typeof(e_Parameter)).ToList();
            list.RemoveAt((int)e_Parameter.Recipe_Copy);
            string[] vs = list.ToArray();

            #region TabPage 생성 및 속성 설정 후 TabControl에 등록
            ClearTabControl(tab);

            tabPages = new TabPage[vs.Length];
            for (int i = 0; i < vs.Length; i++)
            {
                tabPages[i] = new TabPage();

                tabPages[i].Name = tabPages[i].Text = vs[i];
            }

            tab.TabPages.AddRange(tabPages);
            #endregion

            #region DataGridView 생성 및 속성 설정, 이벤트 연결
            dataGridViews = new DataGridView[vs.Length];
            for (int i = 0; i < vs.Length; i++)
            {
                dataGridViews[i] = new DataGridView();

                dataGridViews[i].Name = vs[i];
                dataGridViews[i].Dock = DockStyle.Fill;

                SetDataGridViewProperties(dataGridViews[i]);

                dataGridViews[i].RowPostPaint += new DataGridViewRowPostPaintEventHandler(DataGridViewRowPostPaint);

                dataGridViews[i].KeyUp += new KeyEventHandler(DataGridViewKeyUp);
            }
            #endregion

            #region TabPage 별로 DataGridView 등록
            for (int i = 0; i < vs.Length; i++)
            {
                tabPages[i].Controls.Add(dataGridViews[i]);
            }
            #endregion

            tab.SizeMode = TabSizeMode.Fixed;
            tab.ItemSize = new Size(100, 35);

            tab.SelectedIndexChanged += new EventHandler(TabControlSelectedIndexChanged);
        }

        private void SetDataGridViewProperties(DataGridView dgv)
        {
            GlobalFunction.DoubleBuffered(dgv, true);

            //dgv.AllowUserToAddRows = false;
            //dgv.AllowUserToDeleteRows = false;
            //dgv.AllowUserToOrderColumns = false;
            //dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;

            //dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; // 홀수 번호 행에 적용되는 기본 셀 스타일을 설정

            DataGridViewCellStyle defaultCellStyle = new DataGridViewCellStyle();
            defaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            defaultCellStyle.Font = new Font(e_Font.Tahoma.ToString(), 11F);
            dgv.DefaultCellStyle = defaultCellStyle;

            //dgv.RowHeadersVisible = false;

            dgv.RowHeadersWidth = 60;
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            DataGridViewRow rowTemplate = new DataGridViewRow();
            rowTemplate.Height = 30;
            dgv.RowTemplate = rowTemplate;
        }
        private void DataGridViewRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            Rectangle rectangle = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgv.RowHeadersWidth, e.RowBounds.Height);

            StringFormat stringFormat = new StringFormat()
            {
                Alignment     = StringAlignment.Center,  // 가로
                LineAlignment = StringAlignment.Center   // 세로
            };

            e.Graphics.DrawString((e.RowIndex + 1).ToString(), new Font(e_Font.Tahoma.ToString(), 9), SystemBrushes.ControlText, rectangle, stringFormat);
        }
        private void AddDataGridViewColumns(DataGridView dgv, e_Parameter parameter)
        {
            string[] columns = GlobalFunction.GetNames(parameter);

            dgv.Columns.Clear();

            for (int i = 1; i < columns.Length; i++)
            {
                dgv.Columns.Add(columns[i], columns[i]);

                dgv.Columns[i - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //cellStyle.BackColor = Color.DimGray;
            //cellStyle.ForeColor = Color.White;
            cellStyle.Font = new Font(e_Font.Tahoma.ToString(), 11F);
            dgv.ColumnHeadersDefaultCellStyle = cellStyle;

            dgv.ColumnHeadersHeight = 30;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgv.EnableHeadersVisualStyles = false;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private e_Parameter GetParameter()
        {
            return (e_Parameter)tabControl.SelectedIndex;
        }
        private void TabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            e_Parameter parameter = GetParameter();
            DataGridView dgv = dataGridViews[(int)parameter];

            AddDataGridViewColumns(dgv, parameter);

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            for (int row = 0; row < GlobalValue.Parameter[(int)parameter].Count; row++)
            {
                dgv.Rows.Add();

                for (int col = 1; col < dgv.Columns.Count + 1; col++)
                {
                    if (col < GlobalValue.Parameter[(int)parameter][(row + 1).ToString()].Length)
                    {
                        dgv.Rows[row].Cells[col - 1].Value = GlobalValue.Parameter[(int)parameter][(row + 1).ToString()][col];
                    }
                }
            }

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // TODO : e_Parameter
            switch (parameter)
            {
                case e_Parameter.System:       lbl_Description.Text = "System Parameter"; break;
                case e_Parameter.DB:           lbl_Description.Text = "DB Parameter"; break;
                case e_Parameter.Log:          lbl_Description.Text = "0 : OFF     1 : ON\r\n\r\nActualPosFrc : 그래프 값 로깅"; break;
                case e_Parameter.PLC:          lbl_Description.Text = "PLC Parameter"; break;
                case e_Parameter.PLC_B_IN:     lbl_Description.Text = "B Device Comment"; break;
                case e_Parameter.PLC_B_OUT:    lbl_Description.Text = "B Device Comment"; break;
                case e_Parameter.PLC_F_Alarm:  lbl_Description.Text = "Alarm Comment"; break;
                case e_Parameter.PLC_R_IN:     lbl_Description.Text = "R Device Comment"; break;
                case e_Parameter.PLC_R_OUT:    lbl_Description.Text = "R Device Comment"; break;
                case e_Parameter.RMC:          lbl_Description.Text = "RMC Parameter"; break;
                case e_Parameter.RMC_IN:       lbl_Description.Text = "RMC_IN"; break;
                case e_Parameter.RMC_OUT:      lbl_Description.Text = "RMC_OUT"; break;
                case e_Parameter.Recipe:       lbl_Description.Text = "Recipe Parameter"; break;
            }
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            e_Parameter parameter = GetParameter();
            DataGridView dgv = dataGridViews[(int)parameter];

            Button btn = sender as Button;

            switch (btn.Name.Substring(4))
            {
                case "Clear":
                    AddDataGridViewColumns(dgv, parameter);
                    break;


                case "Save":
                    #region 백업
                    Dictionary<string, string[]> backup = new Dictionary<string, string[]>();
                    foreach (string key in GlobalValue.Parameter[(int)parameter].Keys)
                    {
                        backup.Add(key, GlobalValue.Parameter[(int)parameter][key]);
                    }
                    #endregion

                    // Parameter 변수 초기화
                    GlobalValue.Parameter[(int)parameter].Clear();

                    #region DataGridView 내용을 Parameter 변수로 복사
                    for (int row = 0; row < dgv.Rows.Count - 1; row++)
                    {
                        string[] vs = new string[dgv.Columns.Count + 1];

                        vs[0] = (row + 1).ToString();
                        for (int col = 1; col <= dgv.Columns.Count; col++)
                        {
                            vs[col] = GlobalFunction.GetString(dgv.Rows[row].Cells[col - 1].Value);
                        }

                        GlobalValue.Parameter[(int)parameter].Add(vs[0], vs);
                    }
                    #endregion

                    if (GlobalFunction.SaveParameter(parameter))
                    {
                        GlobalFunction.MessageBox(MethodBase.GetCurrentMethod().Name, "Save OK", MessageBoxButtons.OK);
                    }
                    else
                    {
                        GlobalFunction.MessageBox(MethodBase.GetCurrentMethod().Name, "Save NG", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        GlobalValue.Parameter[(int)parameter].Clear();
                        foreach (string key in backup.Keys)
                        {
                            GlobalValue.Parameter[(int)parameter].Add(key, backup[key]);
                        }
                    }
                    break;


                case "Close":
                    Close();
                    break;
            }
        }

        private void DataGridViewKeyUp(object sender, KeyEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            try
            {
                #region Ctrl + V

                if (e.Control &&
                    e.KeyCode == Keys.V
                   )
                {
                    char[] rowSplitter = { '\r', '\n' };
                    char[] columSplitter = { '\t' };
                    int[] columnsOrderArray = dgv.Columns.Cast<DataGridViewColumn>().Where(x => x.Visible).OrderBy(x => x.DisplayIndex).Select(x => x.Index).ToArray();

                    IDataObject dataInClipboard = Clipboard.GetDataObject();
                    string stringInClipboard = (string)dataInClipboard.GetData(DataFormats.Text);

                    string[] rowInClipboard = stringInClipboard.Split(rowSplitter, StringSplitOptions.RemoveEmptyEntries);
                    int r = dgv.SelectedCells[0].RowIndex;
                    int c = columnsOrderArray[dgv.SelectedCells[0].ColumnIndex];

                    if (dgv.Rows.Count < (r + rowInClipboard.Length))
                    {
                        dgv.Rows.Add(r + rowInClipboard.Length - dgv.Rows.Count + 1);
                    }

                    for (int iRow = 0; iRow < rowInClipboard.Length; iRow++)
                    {
                        string[] valuesInRow = rowInClipboard[iRow].Split(columSplitter);

                        for (int iCol = 0; iCol < valuesInRow.Length; iCol++)
                        {
                            if (columnsOrderArray.Count() - 1 >= c + iCol)
                            {
                                int idx = columnsOrderArray[c + iCol];
                                dgv.Rows[r + iRow].Cells[idx].Value = valuesInRow[iCol];
                            }
                        }
                    }
                }

                #endregion

                #region Delete

                if (e.KeyCode == Keys.Delete)
                {
                    foreach (DataGridViewCell cell in dgv.SelectedCells)
                    {
                        cell.Value = null;
                    }
                }

                #endregion
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }
    }
}

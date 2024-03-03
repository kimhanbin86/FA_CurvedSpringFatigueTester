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
using System.Windows.Forms.DataVisualization.Charting;

using LibLog;

namespace CurvedSpringFatigueTester
{
    public partial class FrmFrcByPos : Form
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

        #region Thread

        private System.Threading.Thread threadUpdateGraph = null;
        private bool isThreadUpdateGraph = false;
        private void ProcessUpdateGraph()
        {
            GraphData graphData;

            bool condition = false;
            bool edgeClear = false;

            while (isThreadUpdateGraph)
            {
                try
                {
                    if (GlobalValue.Form.FormMain.isGraphClear)
                    {
                        if (GlobalDevice.RMC.Instance.GraphDatas[(int)e_Axis.Axis0].Count > 0) { GlobalDevice.RMC.Instance.GraphDatas[(int)e_Axis.Axis0].Clear(); }

                        if (ct_FrcByPos.Series[0].Points.Count > 0)
                        {
                            ClearChartPoints(ct_FrcByPos);
                        }
                    }
                    else
                    {
                        if (GlobalValue.Form.FormMain.TestStart &&
                            GlobalValue.Form.FormMain.isGraphOn
                           )
                        {
                            #region Clear

                            condition = GlobalValue.Form.FormMain.TestCount % Convert.ToInt32(num_Count.Value) == 0 ? true : false;

                            if (edgeClear != condition)
                            {
                                edgeClear = condition;

                                if (edgeClear)
                                {
                                    if (ct_FrcByPos.Series[0].Points.Count > 0)
                                    {
                                        ClearChartPoints(ct_FrcByPos);
                                    }
                                }
                            }

                            #endregion
                        }

                        // RMC 클래스 내 스레드에서 조건 확인 후 큐에 데이터를 추가하기 때문에 카운트만 확인하면 됨
                        if (GlobalDevice.RMC.Instance.GraphDatas[(int)e_Axis.Axis0].Count > 0)
                        {
                            graphData = GlobalDevice.RMC.Instance.GraphDatas[(int)e_Axis.Axis0].Dequeue();

                            AddPointToChart(ct_FrcByPos, graphData.actualPos, graphData.actualFrc);
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

        #region Invoke

        private void ClearChartPoints(Chart chart)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate () { ClearChartPoints(chart); }));
                }
                else
                {
                    chart.Series[0].Points.Clear();
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }
        private void AddPointToChart(Chart chart, double pos, double frc)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate () { AddPointToChart(chart, pos, frc); }));
                }
                else
                {
                    chart.Series[0].Points.AddXY(pos, frc);
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
            threadUpdateGraph = new System.Threading.Thread(ProcessUpdateGraph);
            threadUpdateGraph.IsBackground = true;
            threadUpdateGraph.Priority = System.Threading.ThreadPriority.Highest;
            isThreadUpdateGraph = true;
            threadUpdateGraph.Start();
        }
        private void StopThread()
        {
            isThreadUpdateGraph = false; try { threadUpdateGraph?.Join(1000); } catch { }
        }

        #endregion

        public FrmFrcByPos()
        {
            InitializeComponent();
        }

        private void FrmFrcByPos_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalValue.Form.FormFrcByPos = null;
        }
        private void FrmFrcByPos_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopThread();

            #region 그래프 초기화

            if (ct_FrcByPos.Series.Count > 0)
            {
                ct_FrcByPos.Series.Clear();
            }

            #endregion
        }
        private void FrmFrcByPos_Load(object sender, EventArgs e)
        {
            #region Screen

            Screen[] screens = Screen.AllScreens;

            if (screens.Length > 1)
            {
                Location = new Point(screens[1].WorkingArea.X, screens[1].WorkingArea.Y);
                Size = new Size(screens[1].WorkingArea.Width, screens[1].WorkingArea.Height);
            }

            WindowState = FormWindowState.Maximized;

            #endregion

            InitializeGraph(ct_FrcByPos);

            // 폼을 열었는데 큐에 데이터가 존재하면 그래프를 그리기 때문에 초기화 한번
            if (GlobalDevice.RMC.Instance.GraphDatas[(int)e_Axis.Axis0].Count > 0)
            {
                GlobalDevice.RMC.Instance.GraphDatas[(int)e_Axis.Axis0].Clear();
            }

            StartThread();
        }

        private void InitializeGraph(Chart chart)
        {
            if (chart.Legends.Count > 0)
            {
                chart.Legends.Clear();
            }

            if (chart.Series.Count > 0)
            {
                chart.Series.Clear();

                chart.Series.Add("FrcByPos");

                chart.Series[0].ChartType = SeriesChartType.FastLine;
                chart.Series[0].BorderWidth = 2;

                chart.Series[0].Color = Color.Green;
            }

            chart.ChartAreas[0].AxisX.Title = "Position [deg]";
            chart.ChartAreas[0].AxisY.Title = "Force [Nm]";

            chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            chart.ChartAreas[0].AxisX.Minimum   = Convert.ToDouble(num_Form_Pos_Minimum.Value); 
            chart.ChartAreas[0].AxisX.Maximum   = Convert.ToDouble(num_Form_Pos_Maximum.Value); 
            chart.ChartAreas[0].AxisX.Interval  = Convert.ToDouble(num_Form_Pos_Interval.Value);

            chart.ChartAreas[0].AxisY.Minimum   = Convert.ToDouble(num_Form_Frc_Minimum.Value); 
            chart.ChartAreas[0].AxisY.Maximum   = Convert.ToDouble(num_Form_Frc_Maximum.Value); 
            chart.ChartAreas[0].AxisY.Interval  = Convert.ToDouble(num_Form_Frc_Interval.Value);
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //num_Form_Pos_Minimum
                //num_Form_Pos_Maximum
                //num_Form_Pos_Interval

                //num_Form_Frc_Minimum
                //num_Form_Frc_Maximum
                //num_Form_Frc_Interval

                NumericUpDown num = sender as NumericUpDown;

                switch (num.Name.Substring(9, 3))
                {
                    case "Pos":
                        switch (num.Name.Substring(13))
                        {
                            case "Minimum":   ct_FrcByPos.ChartAreas[0].AxisX.Minimum   = Convert.ToDouble(num_Form_Pos_Minimum.Value);   break;
                            case "Maximum":   ct_FrcByPos.ChartAreas[0].AxisX.Maximum   = Convert.ToDouble(num_Form_Pos_Maximum.Value);   break;
                            case "Interval":  ct_FrcByPos.ChartAreas[0].AxisX.Interval  = Convert.ToDouble(num_Form_Pos_Interval.Value);  break;
                        }
                        break;


                    case "Frc":
                        switch (num.Name.Substring(13))
                        {
                            case "Minimum":   ct_FrcByPos.ChartAreas[0].AxisY.Minimum   = Convert.ToDouble(num_Form_Frc_Minimum.Value);   break;
                            case "Maximum":   ct_FrcByPos.ChartAreas[0].AxisY.Maximum   = Convert.ToDouble(num_Form_Frc_Maximum.Value);   break;
                            case "Interval":  ct_FrcByPos.ChartAreas[0].AxisY.Interval  = Convert.ToDouble(num_Form_Frc_Interval.Value);  break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }
    }
}


namespace CurvedSpringFatigueTester
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모니터2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.conn_PLC = new System.Windows.Forms.ToolStripStatusLabel();
            this.conn_PLC_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.conn_RMC = new System.Windows.Forms.ToolStripStatusLabel();
            this.pb_RMC = new System.Windows.Forms.ToolStripProgressBar();
            this.pb_RMC_percent = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_DateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewLog1 = new LibLog.ListViewLog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ct_Preview = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_RecipeOpen = new System.Windows.Forms.Button();
            this.btn_RecipeSave = new System.Windows.Forms.Button();
            this.btn_DownloadToRMC = new System.Windows.Forms.Button();
            this.btn_UploadFromRMC = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_RecipeName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_Command = new System.Windows.Forms.ListView();
            this.imageList_Command = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Recipe_Copy = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Recipe_Copy_Up = new System.Windows.Forms.Button();
            this.btn_Recipe_Copy_Down = new System.Windows.Forms.Button();
            this.btn_Recipe_Copy_Delete = new System.Windows.Forms.Button();
            this.dgv_Command_Param = new System.Windows.Forms.DataGridView();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel31 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel33 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_CountReset = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.num_Main_Pos_Interval = new System.Windows.Forms.NumericUpDown();
            this.num_Main_Pos_Maximum = new System.Windows.Forms.NumericUpDown();
            this.num_Main_Pos_Minimum = new System.Windows.Forms.NumericUpDown();
            this.label65 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.num_Main_Frc_Interval = new System.Windows.Forms.NumericUpDown();
            this.num_Main_Frc_Maximum = new System.Windows.Forms.NumericUpDown();
            this.num_Main_Frc_Minimum = new System.Windows.Forms.NumericUpDown();
            this.label73 = new System.Windows.Forms.Label();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.ct_Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chk_Force = new System.Windows.Forms.CheckBox();
            this.chk_Position = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_Axis0_Pos = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.lbl_Axis0_Frc = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.lbl_Min_Pos = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.lbl_Min_Frc = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.lbl_Max_Pos = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.lbl_Max_Frc = new System.Windows.Forms.Label();
            this.tableLayoutPanel32 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_isAuto = new System.Windows.Forms.Label();
            this.lbl_isManual = new System.Windows.Forms.Label();
            this.lbl_isTestStart = new System.Windows.Forms.Label();
            this.lbl_isTestStop = new System.Windows.Forms.Label();
            this.lbl_isEmergency = new System.Windows.Forms.Label();
            this.lbl_isReady = new System.Windows.Forms.Label();
            this.lbl_isTestComplete = new System.Windows.Forms.Label();
            this.lbl_isGraphOn = new System.Windows.Forms.Label();
            this.lbl_isGraphClear = new System.Windows.Forms.Label();
            this.lbl_isTestOK = new System.Windows.Forms.Label();
            this.lbl_isTestNG = new System.Windows.Forms.Label();
            this.lbl_isHomePosOK = new System.Windows.Forms.Label();
            this.lbl_isPosPosLimit = new System.Windows.Forms.Label();
            this.lbl_isPosFrcLimit = new System.Windows.Forms.Label();
            this.lbl_isNegPosLimit = new System.Windows.Forms.Label();
            this.lbl_isNegFrcLimit = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_PLC_F_Alarm = new System.Windows.Forms.DataGridView();
            this.dgv_PLC_B_IN = new System.Windows.Forms.DataGridView();
            this.dgv_PLC_B_OUT = new System.Windows.Forms.DataGridView();
            this.dgv_PLC_R_IN = new System.Windows.Forms.DataGridView();
            this.dgv_PLC_R_OUT = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Connect_PLC = new System.Windows.Forms.Button();
            this.btn_Disconnect_PLC = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_RMC_IN = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_RMC_OUT = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Axis0_StatusBits = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Axis0_ErrorBits = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Axis0_Status = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Connect_RMC = new System.Windows.Forms.Button();
            this.btn_Disconnect_RMC = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.label34 = new System.Windows.Forms.Label();
            this.lbl_Axis0_Actual_Pos = new System.Windows.Forms.Label();
            this.tableLayoutPanel28 = new System.Windows.Forms.TableLayoutPanel();
            this.label36 = new System.Windows.Forms.Label();
            this.num_Axis0_Setting_Pos = new System.Windows.Forms.NumericUpDown();
            this.btn_Axis0_Set_Position = new System.Windows.Forms.Button();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel29 = new System.Windows.Forms.TableLayoutPanel();
            this.label38 = new System.Windows.Forms.Label();
            this.lbl_Axis0_Actual_Frc = new System.Windows.Forms.Label();
            this.tableLayoutPanel30 = new System.Windows.Forms.TableLayoutPanel();
            this.label40 = new System.Windows.Forms.Label();
            this.num_Axis0_Setting_Frc = new System.Windows.Forms.NumericUpDown();
            this.btn_Axis0_Set_Force = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Move_Absolute = new System.Windows.Forms.Button();
            this.label63 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.num_Move_Decel = new System.Windows.Forms.NumericUpDown();
            this.num_Move_Accel = new System.Windows.Forms.NumericUpDown();
            this.num_Move_Speed = new System.Windows.Forms.NumericUpDown();
            this.num_Move_Position = new System.Windows.Forms.NumericUpDown();
            this.label57 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.btn_Axis0_Position_V_Write = new System.Windows.Forms.Button();
            this.btn_Axis0_Position_V_Open = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.num_Axis0_Position_WarningError = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Position_FatalError = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Position_Offset = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Position_InPositionTolerance = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Position_AutoAccTime = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Position_AutoVelocity = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Position_HomePosition = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Position_HomeAccTime = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Position_HomeVelocity = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Position_ManualAccTime = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Position_ManualVelocity = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Position_MaxJogVelocity = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Position_MaxAcc = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Position_MaxVelocity = new System.Windows.Forms.NumericUpDown();
            this.label51 = new System.Windows.Forms.Label();
            this.btn_Axis0_Position_G_Write = new System.Windows.Forms.Button();
            this.btn_Axis0_Position_G_Open = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.num_Axis0_Position_Gain_KffN = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Position_Gain_KffP = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Position_Gain_Kd = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Position_Gain_Ki = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Position_Gain_Kp = new System.Windows.Forms.NumericUpDown();
            this.label56 = new System.Windows.Forms.Label();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.btn_Axis0_Force_V_Write = new System.Windows.Forms.Button();
            this.btn_Axis0_Force_V_Open = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.num_Axis0_Force_WarningError = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Force_FatalError = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Force_Offset = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Force_InPositionTolerance = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Force_AutoAccTime = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Force_AutoVelocity = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Force_HomePosition = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Force_HomeAccTime = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Force_HomeVelocity = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Force_ManualAccTime = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Force_ManualVelocity = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Force_MaxJogVelocity = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Force_MaxAcc = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Force_MaxVelocity = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.btn_Axis0_Force_G_Write = new System.Windows.Forms.Button();
            this.btn_Axis0_Force_G_Open = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.num_Axis0_Force_Gain_Krff = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Force_Gain_Kff = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Force_Gain_Kd = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Force_Gain_Ki = new System.Windows.Forms.NumericUpDown();
            this.num_Axis0_Force_Gain_Kp = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Preview)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recipe_Copy)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Command_Param)).BeginInit();
            this.tabPage12.SuspendLayout();
            this.tableLayoutPanel31.SuspendLayout();
            this.tableLayoutPanel33.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Main_Pos_Interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Main_Pos_Maximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Main_Pos_Minimum)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Main_Frc_Interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Main_Frc_Maximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Main_Frc_Minimum)).BeginInit();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Graph)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.tableLayoutPanel32.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PLC_F_Alarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PLC_B_IN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PLC_B_OUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PLC_R_IN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PLC_R_OUT)).BeginInit();
            this.tableLayoutPanel19.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RMC_IN)).BeginInit();
            this.tableLayoutPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RMC_OUT)).BeginInit();
            this.tabControl3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Axis0_StatusBits)).BeginInit();
            this.tableLayoutPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Axis0_ErrorBits)).BeginInit();
            this.tableLayoutPanel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Axis0_Status)).BeginInit();
            this.tableLayoutPanel18.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            this.tableLayoutPanel25.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
            this.tableLayoutPanel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Setting_Pos)).BeginInit();
            this.tableLayoutPanel26.SuspendLayout();
            this.tableLayoutPanel29.SuspendLayout();
            this.tableLayoutPanel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Setting_Frc)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Move_Decel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Move_Accel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Move_Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Move_Position)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabControl5.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_WarningError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_FatalError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_Offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_InPositionTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_AutoAccTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_AutoVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_HomePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_HomeAccTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_HomeVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_ManualAccTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_ManualVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_MaxJogVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_MaxAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_MaxVelocity)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_Gain_KffN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_Gain_KffP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_Gain_Kd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_Gain_Ki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_Gain_Kp)).BeginInit();
            this.tabPage11.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_WarningError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_FatalError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_Offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_InPositionTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_AutoAccTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_AutoVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_HomePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_HomeAccTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_HomeVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_ManualAccTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_ManualVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_MaxJogVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_MaxAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_MaxVelocity)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_Gain_Krff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_Gain_Kff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_Gain_Kd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_Gain_Ki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_Gain_Kp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(36, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.parameterToolStripMenuItem,
            this.모니터2ToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.logToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Visible = false;
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // parameterToolStripMenuItem
            // 
            this.parameterToolStripMenuItem.Name = "parameterToolStripMenuItem";
            this.parameterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.parameterToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.parameterToolStripMenuItem.Text = "Parameter";
            this.parameterToolStripMenuItem.Visible = false;
            this.parameterToolStripMenuItem.Click += new System.EventHandler(this.parameterToolStripMenuItem_Click);
            // 
            // 모니터2ToolStripMenuItem
            // 
            this.모니터2ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.모니터2ToolStripMenuItem.Name = "모니터2ToolStripMenuItem";
            this.모니터2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.모니터2ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.모니터2ToolStripMenuItem.Text = "모니터#2";
            this.모니터2ToolStripMenuItem.Click += new System.EventHandler(this.모니터2ToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.userToolStripMenuItem.Text = "User";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conn_PLC,
            this.conn_PLC_time,
            this.conn_RMC,
            this.pb_RMC,
            this.pb_RMC_percent,
            this.lbl_DateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 704);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // conn_PLC
            // 
            this.conn_PLC.AutoSize = false;
            this.conn_PLC.Name = "conn_PLC";
            this.conn_PLC.Size = new System.Drawing.Size(100, 20);
            this.conn_PLC.Text = "PLC";
            // 
            // conn_PLC_time
            // 
            this.conn_PLC_time.AutoSize = false;
            this.conn_PLC_time.Name = "conn_PLC_time";
            this.conn_PLC_time.Size = new System.Drawing.Size(100, 20);
            this.conn_PLC_time.Text = "[msec]";
            this.conn_PLC_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // conn_RMC
            // 
            this.conn_RMC.AutoSize = false;
            this.conn_RMC.Name = "conn_RMC";
            this.conn_RMC.Size = new System.Drawing.Size(100, 20);
            this.conn_RMC.Text = "RMC";
            // 
            // pb_RMC
            // 
            this.pb_RMC.Name = "pb_RMC";
            this.pb_RMC.Size = new System.Drawing.Size(200, 19);
            // 
            // pb_RMC_percent
            // 
            this.pb_RMC_percent.AutoSize = false;
            this.pb_RMC_percent.Name = "pb_RMC_percent";
            this.pb_RMC_percent.Size = new System.Drawing.Size(100, 20);
            this.pb_RMC_percent.Text = "[%]";
            this.pb_RMC_percent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_DateTime
            // 
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(391, 20);
            this.lbl_DateTime.Spring = true;
            this.lbl_DateTime.Text = "lbl_DateTime";
            this.lbl_DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewLog1);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 504);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 200);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // listViewLog1
            // 
            this.listViewLog1.BackColor = System.Drawing.Color.Black;
            this.listViewLog1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listViewLog1.ForeColor = System.Drawing.Color.Yellow;
            this.listViewLog1.FullRowSelect = true;
            this.listViewLog1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewLog1.HideSelection = false;
            this.listViewLog1.Location = new System.Drawing.Point(0, 5);
            this.listViewLog1.MultiSelect = false;
            this.listViewLog1.Name = "listViewLog1";
            this.listViewLog1.Size = new System.Drawing.Size(1008, 195);
            this.listViewLog1.TabIndex = 1;
            this.listViewLog1.TabStop = false;
            this.listViewLog1.UseCompatibleStateImageBehavior = false;
            this.listViewLog1.View = System.Windows.Forms.View.Details;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.Highlight;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1008, 5);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            this.splitter1.DoubleClick += new System.EventHandler(this.splitter1_DoubleClick);
            this.splitter1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitter1_MouseUp);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage12);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 35);
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 479);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HOME";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Command_Param, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 430);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ct_Preview, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(697, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(294, 424);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ct_Preview
            // 
            chartArea1.Name = "ChartArea1";
            this.ct_Preview.ChartAreas.Add(chartArea1);
            this.ct_Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ct_Preview.Legends.Add(legend1);
            this.ct_Preview.Location = new System.Drawing.Point(3, 3);
            this.ct_Preview.Name = "ct_Preview";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ct_Preview.Series.Add(series1);
            this.ct_Preview.Size = new System.Drawing.Size(288, 206);
            this.ct_Preview.TabIndex = 0;
            this.ct_Preview.Text = "chart1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(341, 424);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.btn_RecipeOpen, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_RecipeSave, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_DownloadToRMC, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_UploadFromRMC, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(335, 36);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btn_RecipeOpen
            // 
            this.btn_RecipeOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RecipeOpen.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_RecipeOpen.Location = new System.Drawing.Point(3, 3);
            this.btn_RecipeOpen.Name = "btn_RecipeOpen";
            this.btn_RecipeOpen.Size = new System.Drawing.Size(77, 30);
            this.btn_RecipeOpen.TabIndex = 0;
            this.btn_RecipeOpen.Text = "불러오기";
            this.btn_RecipeOpen.UseVisualStyleBackColor = true;
            this.btn_RecipeOpen.Click += new System.EventHandler(this.btn_RecipeOpen_Click);
            // 
            // btn_RecipeSave
            // 
            this.btn_RecipeSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RecipeSave.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_RecipeSave.Location = new System.Drawing.Point(86, 3);
            this.btn_RecipeSave.Name = "btn_RecipeSave";
            this.btn_RecipeSave.Size = new System.Drawing.Size(77, 30);
            this.btn_RecipeSave.TabIndex = 1;
            this.btn_RecipeSave.Text = "저장";
            this.btn_RecipeSave.UseVisualStyleBackColor = true;
            this.btn_RecipeSave.Click += new System.EventHandler(this.btn_RecipeSave_Click);
            // 
            // btn_DownloadToRMC
            // 
            this.btn_DownloadToRMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_DownloadToRMC.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_DownloadToRMC.Location = new System.Drawing.Point(169, 3);
            this.btn_DownloadToRMC.Name = "btn_DownloadToRMC";
            this.btn_DownloadToRMC.Size = new System.Drawing.Size(77, 30);
            this.btn_DownloadToRMC.TabIndex = 2;
            this.btn_DownloadToRMC.Text = "다운로드";
            this.btn_DownloadToRMC.UseVisualStyleBackColor = true;
            this.btn_DownloadToRMC.Click += new System.EventHandler(this.btn_DownloadToRMC_Click);
            // 
            // btn_UploadFromRMC
            // 
            this.btn_UploadFromRMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_UploadFromRMC.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_UploadFromRMC.Location = new System.Drawing.Point(252, 3);
            this.btn_UploadFromRMC.Name = "btn_UploadFromRMC";
            this.btn_UploadFromRMC.Size = new System.Drawing.Size(80, 30);
            this.btn_UploadFromRMC.TabIndex = 3;
            this.btn_UploadFromRMC.Text = "업로드";
            this.btn_UploadFromRMC.UseVisualStyleBackColor = true;
            this.btn_UploadFromRMC.Click += new System.EventHandler(this.btn_UploadFromRMC_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbl_RecipeName, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 45);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(335, 36);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECIPE NAME :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_RecipeName
            // 
            this.lbl_RecipeName.BackColor = System.Drawing.Color.Black;
            this.lbl_RecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_RecipeName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecipeName.ForeColor = System.Drawing.Color.Lime;
            this.lbl_RecipeName.Location = new System.Drawing.Point(103, 0);
            this.lbl_RecipeName.Name = "lbl_RecipeName";
            this.lbl_RecipeName.Size = new System.Drawing.Size(229, 36);
            this.lbl_RecipeName.TabIndex = 2;
            this.lbl_RecipeName.Text = "lbl_RecipeName";
            this.lbl_RecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.listView_Command);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Command";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(15, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 50);
            this.panel3.TabIndex = 5;
            this.panel3.Visible = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Command enum과 imageList_Command.Images 컬렉션의 순서가 동일해야 함";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView_Command
            // 
            this.listView_Command.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Command.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Command.HideSelection = false;
            this.listView_Command.LargeImageList = this.imageList_Command;
            this.listView_Command.Location = new System.Drawing.Point(3, 18);
            this.listView_Command.Name = "listView_Command";
            this.listView_Command.Size = new System.Drawing.Size(329, 36);
            this.listView_Command.TabIndex = 0;
            this.listView_Command.UseCompatibleStateImageBehavior = false;
            this.listView_Command.DoubleClick += new System.EventHandler(this.listView_Command_DoubleClick);
            // 
            // imageList_Command
            // 
            this.imageList_Command.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Command.ImageStream")));
            this.imageList_Command.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Command.Images.SetKeyName(0, "Ramp.png");
            this.imageList_Command.Images.SetKeyName(1, "Test.png");
            this.imageList_Command.Images.SetKeyName(2, "Link.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 271);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recipe";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.Controls.Add(this.dgv_Recipe_Copy, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(329, 250);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // dgv_Recipe_Copy
            // 
            this.dgv_Recipe_Copy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Recipe_Copy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Recipe_Copy.Location = new System.Drawing.Point(3, 3);
            this.dgv_Recipe_Copy.Name = "dgv_Recipe_Copy";
            this.dgv_Recipe_Copy.RowTemplate.Height = 23;
            this.dgv_Recipe_Copy.Size = new System.Drawing.Size(224, 244);
            this.dgv_Recipe_Copy.TabIndex = 0;
            this.dgv_Recipe_Copy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Recipe_Copy_CellClick);
            this.dgv_Recipe_Copy.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Recipe_Copy_CellValueChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.btn_Recipe_Copy_Up, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btn_Recipe_Copy_Down, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.btn_Recipe_Copy_Delete, 0, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(233, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 5;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(93, 244);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // btn_Recipe_Copy_Up
            // 
            this.btn_Recipe_Copy_Up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Recipe_Copy_Up.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Recipe_Copy_Up.Location = new System.Drawing.Point(3, 3);
            this.btn_Recipe_Copy_Up.Name = "btn_Recipe_Copy_Up";
            this.btn_Recipe_Copy_Up.Size = new System.Drawing.Size(87, 42);
            this.btn_Recipe_Copy_Up.TabIndex = 0;
            this.btn_Recipe_Copy_Up.Text = "위로";
            this.btn_Recipe_Copy_Up.UseVisualStyleBackColor = true;
            this.btn_Recipe_Copy_Up.Click += new System.EventHandler(this.btn_Recipe_Copy_Up_Click);
            // 
            // btn_Recipe_Copy_Down
            // 
            this.btn_Recipe_Copy_Down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Recipe_Copy_Down.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Recipe_Copy_Down.Location = new System.Drawing.Point(3, 51);
            this.btn_Recipe_Copy_Down.Name = "btn_Recipe_Copy_Down";
            this.btn_Recipe_Copy_Down.Size = new System.Drawing.Size(87, 42);
            this.btn_Recipe_Copy_Down.TabIndex = 1;
            this.btn_Recipe_Copy_Down.Text = "아래로";
            this.btn_Recipe_Copy_Down.UseVisualStyleBackColor = true;
            this.btn_Recipe_Copy_Down.Click += new System.EventHandler(this.btn_Recipe_Copy_Down_Click);
            // 
            // btn_Recipe_Copy_Delete
            // 
            this.btn_Recipe_Copy_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Recipe_Copy_Delete.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Recipe_Copy_Delete.Location = new System.Drawing.Point(3, 99);
            this.btn_Recipe_Copy_Delete.Name = "btn_Recipe_Copy_Delete";
            this.btn_Recipe_Copy_Delete.Size = new System.Drawing.Size(87, 42);
            this.btn_Recipe_Copy_Delete.TabIndex = 2;
            this.btn_Recipe_Copy_Delete.Text = "삭제";
            this.btn_Recipe_Copy_Delete.UseVisualStyleBackColor = true;
            this.btn_Recipe_Copy_Delete.Click += new System.EventHandler(this.btn_Recipe_Copy_Delete_Click);
            // 
            // dgv_Command_Param
            // 
            this.dgv_Command_Param.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Command_Param.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Command_Param.Location = new System.Drawing.Point(350, 3);
            this.dgv_Command_Param.Name = "dgv_Command_Param";
            this.dgv_Command_Param.RowTemplate.Height = 23;
            this.dgv_Command_Param.Size = new System.Drawing.Size(341, 424);
            this.dgv_Command_Param.TabIndex = 3;
            this.dgv_Command_Param.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Command_Param_CellValueChanged);
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.tableLayoutPanel31);
            this.tabPage12.Location = new System.Drawing.Point(4, 39);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(1000, 436);
            this.tabPage12.TabIndex = 6;
            this.tabPage12.Text = "GRAPH";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel31
            // 
            this.tableLayoutPanel31.ColumnCount = 1;
            this.tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel31.Controls.Add(this.tableLayoutPanel33, 0, 2);
            this.tableLayoutPanel31.Controls.Add(this.tableLayoutPanel11, 0, 1);
            this.tableLayoutPanel31.Controls.Add(this.tableLayoutPanel21, 0, 0);
            this.tableLayoutPanel31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel31.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel31.Name = "tableLayoutPanel31";
            this.tableLayoutPanel31.RowCount = 3;
            this.tableLayoutPanel31.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel31.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel31.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel31.Size = new System.Drawing.Size(994, 430);
            this.tableLayoutPanel31.TabIndex = 0;
            // 
            // tableLayoutPanel33
            // 
            this.tableLayoutPanel33.ColumnCount = 4;
            this.tableLayoutPanel33.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel33.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel33.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel33.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel33.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel33.Controls.Add(this.btn_CountReset, 0, 0);
            this.tableLayoutPanel33.Controls.Add(this.groupBox4, 2, 0);
            this.tableLayoutPanel33.Controls.Add(this.groupBox6, 3, 0);
            this.tableLayoutPanel33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel33.Location = new System.Drawing.Point(3, 347);
            this.tableLayoutPanel33.Name = "tableLayoutPanel33";
            this.tableLayoutPanel33.RowCount = 1;
            this.tableLayoutPanel33.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel33.Size = new System.Drawing.Size(988, 80);
            this.tableLayoutPanel33.TabIndex = 1;
            // 
            // btn_CountReset
            // 
            this.btn_CountReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_CountReset.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_CountReset.Location = new System.Drawing.Point(3, 3);
            this.btn_CountReset.Name = "btn_CountReset";
            this.btn_CountReset.Size = new System.Drawing.Size(241, 74);
            this.btn_CountReset.TabIndex = 4;
            this.btn_CountReset.Text = "Count Reset";
            this.btn_CountReset.UseVisualStyleBackColor = true;
            this.btn_CountReset.Click += new System.EventHandler(this.btn_CountReset_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label69);
            this.groupBox4.Controls.Add(this.label67);
            this.groupBox4.Controls.Add(this.num_Main_Pos_Interval);
            this.groupBox4.Controls.Add(this.num_Main_Pos_Maximum);
            this.groupBox4.Controls.Add(this.num_Main_Pos_Minimum);
            this.groupBox4.Controls.Add(this.label65);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(497, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 74);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Position (deg)";
            // 
            // label69
            // 
            this.label69.Location = new System.Drawing.Point(23, 64);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(108, 22);
            this.label69.TabIndex = 14;
            this.label69.Text = "Interval :";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label67
            // 
            this.label67.Location = new System.Drawing.Point(23, 39);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(108, 22);
            this.label67.TabIndex = 13;
            this.label67.Text = "Maximum :";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num_Main_Pos_Interval
            // 
            this.num_Main_Pos_Interval.Location = new System.Drawing.Point(137, 66);
            this.num_Main_Pos_Interval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Main_Pos_Interval.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.num_Main_Pos_Interval.Name = "num_Main_Pos_Interval";
            this.num_Main_Pos_Interval.Size = new System.Drawing.Size(81, 22);
            this.num_Main_Pos_Interval.TabIndex = 12;
            this.num_Main_Pos_Interval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_Main_Pos_Interval.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // num_Main_Pos_Maximum
            // 
            this.num_Main_Pos_Maximum.Location = new System.Drawing.Point(137, 41);
            this.num_Main_Pos_Maximum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Main_Pos_Maximum.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.num_Main_Pos_Maximum.Name = "num_Main_Pos_Maximum";
            this.num_Main_Pos_Maximum.Size = new System.Drawing.Size(81, 22);
            this.num_Main_Pos_Maximum.TabIndex = 11;
            this.num_Main_Pos_Maximum.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.num_Main_Pos_Maximum.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // num_Main_Pos_Minimum
            // 
            this.num_Main_Pos_Minimum.Location = new System.Drawing.Point(137, 16);
            this.num_Main_Pos_Minimum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Main_Pos_Minimum.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.num_Main_Pos_Minimum.Name = "num_Main_Pos_Minimum";
            this.num_Main_Pos_Minimum.Size = new System.Drawing.Size(81, 22);
            this.num_Main_Pos_Minimum.TabIndex = 10;
            this.num_Main_Pos_Minimum.Value = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.num_Main_Pos_Minimum.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label65
            // 
            this.label65.Location = new System.Drawing.Point(23, 14);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(108, 22);
            this.label65.TabIndex = 9;
            this.label65.Text = "Minimum :";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label71);
            this.groupBox6.Controls.Add(this.label72);
            this.groupBox6.Controls.Add(this.num_Main_Frc_Interval);
            this.groupBox6.Controls.Add(this.num_Main_Frc_Maximum);
            this.groupBox6.Controls.Add(this.num_Main_Frc_Minimum);
            this.groupBox6.Controls.Add(this.label73);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(744, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(241, 74);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Force (Nm)";
            // 
            // label71
            // 
            this.label71.Location = new System.Drawing.Point(23, 64);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(108, 22);
            this.label71.TabIndex = 14;
            this.label71.Text = "Interval :";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label72
            // 
            this.label72.Location = new System.Drawing.Point(23, 39);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(108, 22);
            this.label72.TabIndex = 13;
            this.label72.Text = "Maximum :";
            this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num_Main_Frc_Interval
            // 
            this.num_Main_Frc_Interval.Location = new System.Drawing.Point(137, 66);
            this.num_Main_Frc_Interval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Main_Frc_Interval.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.num_Main_Frc_Interval.Name = "num_Main_Frc_Interval";
            this.num_Main_Frc_Interval.Size = new System.Drawing.Size(81, 22);
            this.num_Main_Frc_Interval.TabIndex = 12;
            this.num_Main_Frc_Interval.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.num_Main_Frc_Interval.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // num_Main_Frc_Maximum
            // 
            this.num_Main_Frc_Maximum.Location = new System.Drawing.Point(137, 41);
            this.num_Main_Frc_Maximum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Main_Frc_Maximum.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.num_Main_Frc_Maximum.Name = "num_Main_Frc_Maximum";
            this.num_Main_Frc_Maximum.Size = new System.Drawing.Size(81, 22);
            this.num_Main_Frc_Maximum.TabIndex = 11;
            this.num_Main_Frc_Maximum.Value = new decimal(new int[] {
            3500,
            0,
            0,
            0});
            this.num_Main_Frc_Maximum.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // num_Main_Frc_Minimum
            // 
            this.num_Main_Frc_Minimum.Location = new System.Drawing.Point(137, 16);
            this.num_Main_Frc_Minimum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Main_Frc_Minimum.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.num_Main_Frc_Minimum.Name = "num_Main_Frc_Minimum";
            this.num_Main_Frc_Minimum.Size = new System.Drawing.Size(81, 22);
            this.num_Main_Frc_Minimum.TabIndex = 10;
            this.num_Main_Frc_Minimum.Value = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.num_Main_Frc_Minimum.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label73
            // 
            this.label73.Location = new System.Drawing.Point(23, 14);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(108, 22);
            this.label73.TabIndex = 9;
            this.label73.Text = "Minimum :";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel11.Controls.Add(this.ct_Graph, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 132);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(988, 209);
            this.tableLayoutPanel11.TabIndex = 2;
            // 
            // ct_Graph
            // 
            chartArea2.Name = "ChartArea1";
            this.ct_Graph.ChartAreas.Add(chartArea2);
            this.ct_Graph.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.ct_Graph.Legends.Add(legend2);
            this.ct_Graph.Location = new System.Drawing.Point(3, 3);
            this.ct_Graph.Name = "ct_Graph";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ct_Graph.Series.Add(series2);
            this.ct_Graph.Size = new System.Drawing.Size(883, 203);
            this.ct_Graph.TabIndex = 0;
            this.ct_Graph.Text = "chart3";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chk_Force);
            this.panel2.Controls.Add(this.chk_Position);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(892, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 203);
            this.panel2.TabIndex = 1;
            // 
            // chk_Force
            // 
            this.chk_Force.Checked = true;
            this.chk_Force.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Force.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_Force.Location = new System.Drawing.Point(10, 46);
            this.chk_Force.Name = "chk_Force";
            this.chk_Force.Size = new System.Drawing.Size(100, 20);
            this.chk_Force.TabIndex = 5;
            this.chk_Force.Text = "Force";
            this.chk_Force.UseVisualStyleBackColor = false;
            this.chk_Force.CheckedChanged += new System.EventHandler(this.chk_PosFrc_CheckedChanged);
            // 
            // chk_Position
            // 
            this.chk_Position.Checked = true;
            this.chk_Position.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Position.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_Position.ForeColor = System.Drawing.Color.Red;
            this.chk_Position.Location = new System.Drawing.Point(10, 20);
            this.chk_Position.Name = "chk_Position";
            this.chk_Position.Size = new System.Drawing.Size(100, 20);
            this.chk_Position.TabIndex = 4;
            this.chk_Position.Text = "Position";
            this.chk_Position.UseVisualStyleBackColor = false;
            this.chk_Position.CheckedChanged += new System.EventHandler(this.chk_PosFrc_CheckedChanged);
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 2;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel21.Controls.Add(this.tableLayoutPanel22, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.tableLayoutPanel32, 1, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(988, 123);
            this.tableLayoutPanel21.TabIndex = 3;
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 4;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel22.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel22.Controls.Add(this.lbl_Axis0_Pos, 0, 1);
            this.tableLayoutPanel22.Controls.Add(this.label58, 0, 2);
            this.tableLayoutPanel22.Controls.Add(this.lbl_Axis0_Frc, 0, 3);
            this.tableLayoutPanel22.Controls.Add(this.label60, 1, 0);
            this.tableLayoutPanel22.Controls.Add(this.lbl_Time, 1, 1);
            this.tableLayoutPanel22.Controls.Add(this.label62, 1, 2);
            this.tableLayoutPanel22.Controls.Add(this.lbl_Count, 1, 3);
            this.tableLayoutPanel22.Controls.Add(this.label64, 2, 0);
            this.tableLayoutPanel22.Controls.Add(this.lbl_Min_Pos, 2, 1);
            this.tableLayoutPanel22.Controls.Add(this.label66, 2, 2);
            this.tableLayoutPanel22.Controls.Add(this.lbl_Min_Frc, 2, 3);
            this.tableLayoutPanel22.Controls.Add(this.label68, 3, 0);
            this.tableLayoutPanel22.Controls.Add(this.lbl_Max_Pos, 3, 1);
            this.tableLayoutPanel22.Controls.Add(this.label70, 3, 2);
            this.tableLayoutPanel22.Controls.Add(this.lbl_Max_Frc, 3, 3);
            this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel22.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 4;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(685, 117);
            this.tableLayoutPanel22.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(1, 1);
            this.label12.Margin = new System.Windows.Forms.Padding(1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 27);
            this.label12.TabIndex = 0;
            this.label12.Text = "Axis0_Pos [deg]";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Axis0_Pos
            // 
            this.lbl_Axis0_Pos.BackColor = System.Drawing.Color.Black;
            this.lbl_Axis0_Pos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Axis0_Pos.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Axis0_Pos.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Axis0_Pos.Location = new System.Drawing.Point(1, 30);
            this.lbl_Axis0_Pos.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_Axis0_Pos.Name = "lbl_Axis0_Pos";
            this.lbl_Axis0_Pos.Size = new System.Drawing.Size(169, 27);
            this.lbl_Axis0_Pos.TabIndex = 1;
            this.lbl_Axis0_Pos.Text = "0.000";
            this.lbl_Axis0_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label58
            // 
            this.label58.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label58.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label58.Location = new System.Drawing.Point(1, 59);
            this.label58.Margin = new System.Windows.Forms.Padding(1);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(169, 27);
            this.label58.TabIndex = 2;
            this.label58.Text = "Axis0_Frc [Nm]";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Axis0_Frc
            // 
            this.lbl_Axis0_Frc.BackColor = System.Drawing.Color.Black;
            this.lbl_Axis0_Frc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Axis0_Frc.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Axis0_Frc.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Axis0_Frc.Location = new System.Drawing.Point(1, 88);
            this.lbl_Axis0_Frc.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_Axis0_Frc.Name = "lbl_Axis0_Frc";
            this.lbl_Axis0_Frc.Size = new System.Drawing.Size(169, 28);
            this.lbl_Axis0_Frc.TabIndex = 3;
            this.lbl_Axis0_Frc.Text = "0.000";
            this.lbl_Axis0_Frc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label60
            // 
            this.label60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label60.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label60.Location = new System.Drawing.Point(172, 1);
            this.label60.Margin = new System.Windows.Forms.Padding(1);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(169, 27);
            this.label60.TabIndex = 4;
            this.label60.Text = "Time [sec]";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Time
            // 
            this.lbl_Time.BackColor = System.Drawing.Color.Black;
            this.lbl_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Time.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Time.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Time.Location = new System.Drawing.Point(172, 30);
            this.lbl_Time.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(169, 27);
            this.lbl_Time.TabIndex = 5;
            this.lbl_Time.Text = "00:00:00";
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label62
            // 
            this.label62.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label62.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label62.Location = new System.Drawing.Point(172, 59);
            this.label62.Margin = new System.Windows.Forms.Padding(1);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(169, 27);
            this.label62.TabIndex = 6;
            this.label62.Text = "Count [EA]";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Count
            // 
            this.lbl_Count.BackColor = System.Drawing.Color.Black;
            this.lbl_Count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Count.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Count.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Count.Location = new System.Drawing.Point(172, 88);
            this.lbl_Count.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(169, 28);
            this.lbl_Count.TabIndex = 7;
            this.lbl_Count.Text = "0";
            this.lbl_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label64
            // 
            this.label64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label64.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label64.Location = new System.Drawing.Point(343, 1);
            this.label64.Margin = new System.Windows.Forms.Padding(1);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(169, 27);
            this.label64.TabIndex = 8;
            this.label64.Text = "Min_Pos [deg]";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Min_Pos
            // 
            this.lbl_Min_Pos.BackColor = System.Drawing.Color.Black;
            this.lbl_Min_Pos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Min_Pos.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Min_Pos.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Min_Pos.Location = new System.Drawing.Point(343, 30);
            this.lbl_Min_Pos.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_Min_Pos.Name = "lbl_Min_Pos";
            this.lbl_Min_Pos.Size = new System.Drawing.Size(169, 27);
            this.lbl_Min_Pos.TabIndex = 9;
            this.lbl_Min_Pos.Text = "0.000";
            this.lbl_Min_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label66
            // 
            this.label66.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label66.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label66.Location = new System.Drawing.Point(343, 59);
            this.label66.Margin = new System.Windows.Forms.Padding(1);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(169, 27);
            this.label66.TabIndex = 10;
            this.label66.Text = "Min_Frc [Nm]";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Min_Frc
            // 
            this.lbl_Min_Frc.BackColor = System.Drawing.Color.Black;
            this.lbl_Min_Frc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Min_Frc.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Min_Frc.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Min_Frc.Location = new System.Drawing.Point(343, 88);
            this.lbl_Min_Frc.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_Min_Frc.Name = "lbl_Min_Frc";
            this.lbl_Min_Frc.Size = new System.Drawing.Size(169, 28);
            this.lbl_Min_Frc.TabIndex = 11;
            this.lbl_Min_Frc.Text = "0.000";
            this.lbl_Min_Frc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label68
            // 
            this.label68.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label68.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label68.Location = new System.Drawing.Point(514, 1);
            this.label68.Margin = new System.Windows.Forms.Padding(1);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(170, 27);
            this.label68.TabIndex = 12;
            this.label68.Text = "Max_Pos [deg]";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Max_Pos
            // 
            this.lbl_Max_Pos.BackColor = System.Drawing.Color.Black;
            this.lbl_Max_Pos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Max_Pos.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Max_Pos.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Max_Pos.Location = new System.Drawing.Point(514, 30);
            this.lbl_Max_Pos.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_Max_Pos.Name = "lbl_Max_Pos";
            this.lbl_Max_Pos.Size = new System.Drawing.Size(170, 27);
            this.lbl_Max_Pos.TabIndex = 13;
            this.lbl_Max_Pos.Text = "0.000";
            this.lbl_Max_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label70
            // 
            this.label70.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label70.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label70.Location = new System.Drawing.Point(514, 59);
            this.label70.Margin = new System.Windows.Forms.Padding(1);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(170, 27);
            this.label70.TabIndex = 14;
            this.label70.Text = "Max_Frc [Nm]";
            this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Max_Frc
            // 
            this.lbl_Max_Frc.BackColor = System.Drawing.Color.Black;
            this.lbl_Max_Frc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Max_Frc.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Max_Frc.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Max_Frc.Location = new System.Drawing.Point(514, 88);
            this.lbl_Max_Frc.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_Max_Frc.Name = "lbl_Max_Frc";
            this.lbl_Max_Frc.Size = new System.Drawing.Size(170, 28);
            this.lbl_Max_Frc.TabIndex = 15;
            this.lbl_Max_Frc.Text = "0.000";
            this.lbl_Max_Frc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel32
            // 
            this.tableLayoutPanel32.ColumnCount = 5;
            this.tableLayoutPanel32.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel32.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel32.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel32.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel32.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel32.Controls.Add(this.lbl_isAuto, 0, 0);
            this.tableLayoutPanel32.Controls.Add(this.lbl_isManual, 1, 0);
            this.tableLayoutPanel32.Controls.Add(this.lbl_isTestStart, 2, 0);
            this.tableLayoutPanel32.Controls.Add(this.lbl_isTestStop, 3, 0);
            this.tableLayoutPanel32.Controls.Add(this.lbl_isEmergency, 4, 0);
            this.tableLayoutPanel32.Controls.Add(this.lbl_isReady, 0, 1);
            this.tableLayoutPanel32.Controls.Add(this.lbl_isTestComplete, 2, 1);
            this.tableLayoutPanel32.Controls.Add(this.lbl_isGraphOn, 0, 2);
            this.tableLayoutPanel32.Controls.Add(this.lbl_isGraphClear, 1, 2);
            this.tableLayoutPanel32.Controls.Add(this.lbl_isTestOK, 2, 2);
            this.tableLayoutPanel32.Controls.Add(this.lbl_isTestNG, 3, 2);
            this.tableLayoutPanel32.Controls.Add(this.lbl_isHomePosOK, 1, 1);
            this.tableLayoutPanel32.Controls.Add(this.lbl_isPosPosLimit, 0, 3);
            this.tableLayoutPanel32.Controls.Add(this.lbl_isPosFrcLimit, 1, 3);
            this.tableLayoutPanel32.Controls.Add(this.lbl_isNegPosLimit, 2, 3);
            this.tableLayoutPanel32.Controls.Add(this.lbl_isNegFrcLimit, 3, 3);
            this.tableLayoutPanel32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel32.Location = new System.Drawing.Point(694, 3);
            this.tableLayoutPanel32.Name = "tableLayoutPanel32";
            this.tableLayoutPanel32.RowCount = 4;
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel32.Size = new System.Drawing.Size(291, 117);
            this.tableLayoutPanel32.TabIndex = 1;
            // 
            // lbl_isAuto
            // 
            this.lbl_isAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_isAuto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_isAuto.Location = new System.Drawing.Point(1, 1);
            this.lbl_isAuto.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_isAuto.Name = "lbl_isAuto";
            this.lbl_isAuto.Size = new System.Drawing.Size(56, 27);
            this.lbl_isAuto.TabIndex = 0;
            this.lbl_isAuto.Text = "Auto";
            this.lbl_isAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_isManual
            // 
            this.lbl_isManual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_isManual.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_isManual.Location = new System.Drawing.Point(59, 1);
            this.lbl_isManual.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_isManual.Name = "lbl_isManual";
            this.lbl_isManual.Size = new System.Drawing.Size(56, 27);
            this.lbl_isManual.TabIndex = 1;
            this.lbl_isManual.Text = "Manual";
            this.lbl_isManual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_isTestStart
            // 
            this.lbl_isTestStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_isTestStart.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_isTestStart.Location = new System.Drawing.Point(117, 1);
            this.lbl_isTestStart.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_isTestStart.Name = "lbl_isTestStart";
            this.lbl_isTestStart.Size = new System.Drawing.Size(56, 27);
            this.lbl_isTestStart.TabIndex = 2;
            this.lbl_isTestStart.Text = "Test\r\nStart";
            this.lbl_isTestStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_isTestStop
            // 
            this.lbl_isTestStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_isTestStop.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_isTestStop.Location = new System.Drawing.Point(175, 1);
            this.lbl_isTestStop.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_isTestStop.Name = "lbl_isTestStop";
            this.lbl_isTestStop.Size = new System.Drawing.Size(56, 27);
            this.lbl_isTestStop.TabIndex = 3;
            this.lbl_isTestStop.Text = "Test\r\nStop";
            this.lbl_isTestStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_isEmergency
            // 
            this.lbl_isEmergency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_isEmergency.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_isEmergency.Location = new System.Drawing.Point(233, 1);
            this.lbl_isEmergency.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_isEmergency.Name = "lbl_isEmergency";
            this.lbl_isEmergency.Size = new System.Drawing.Size(57, 27);
            this.lbl_isEmergency.TabIndex = 4;
            this.lbl_isEmergency.Text = "EMG";
            this.lbl_isEmergency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_isReady
            // 
            this.lbl_isReady.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_isReady.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_isReady.Location = new System.Drawing.Point(1, 30);
            this.lbl_isReady.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_isReady.Name = "lbl_isReady";
            this.lbl_isReady.Size = new System.Drawing.Size(56, 27);
            this.lbl_isReady.TabIndex = 5;
            this.lbl_isReady.Text = "Ready";
            this.lbl_isReady.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_isTestComplete
            // 
            this.lbl_isTestComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_isTestComplete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_isTestComplete.Location = new System.Drawing.Point(117, 30);
            this.lbl_isTestComplete.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_isTestComplete.Name = "lbl_isTestComplete";
            this.lbl_isTestComplete.Size = new System.Drawing.Size(56, 27);
            this.lbl_isTestComplete.TabIndex = 6;
            this.lbl_isTestComplete.Text = "Test\r\nComp";
            this.lbl_isTestComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_isGraphOn
            // 
            this.lbl_isGraphOn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_isGraphOn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_isGraphOn.Location = new System.Drawing.Point(1, 59);
            this.lbl_isGraphOn.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_isGraphOn.Name = "lbl_isGraphOn";
            this.lbl_isGraphOn.Size = new System.Drawing.Size(56, 27);
            this.lbl_isGraphOn.TabIndex = 10;
            this.lbl_isGraphOn.Text = "Graph\r\nOn";
            this.lbl_isGraphOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_isGraphClear
            // 
            this.lbl_isGraphClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_isGraphClear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_isGraphClear.Location = new System.Drawing.Point(59, 59);
            this.lbl_isGraphClear.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_isGraphClear.Name = "lbl_isGraphClear";
            this.lbl_isGraphClear.Size = new System.Drawing.Size(56, 27);
            this.lbl_isGraphClear.TabIndex = 11;
            this.lbl_isGraphClear.Text = "Graph\r\nClear";
            this.lbl_isGraphClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_isTestOK
            // 
            this.lbl_isTestOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_isTestOK.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_isTestOK.Location = new System.Drawing.Point(117, 59);
            this.lbl_isTestOK.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_isTestOK.Name = "lbl_isTestOK";
            this.lbl_isTestOK.Size = new System.Drawing.Size(56, 27);
            this.lbl_isTestOK.TabIndex = 12;
            this.lbl_isTestOK.Text = "Test\r\nOK";
            this.lbl_isTestOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_isTestNG
            // 
            this.lbl_isTestNG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_isTestNG.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_isTestNG.Location = new System.Drawing.Point(175, 59);
            this.lbl_isTestNG.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_isTestNG.Name = "lbl_isTestNG";
            this.lbl_isTestNG.Size = new System.Drawing.Size(56, 27);
            this.lbl_isTestNG.TabIndex = 13;
            this.lbl_isTestNG.Text = "Test\r\nNG";
            this.lbl_isTestNG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_isHomePosOK
            // 
            this.lbl_isHomePosOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_isHomePosOK.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_isHomePosOK.Location = new System.Drawing.Point(59, 30);
            this.lbl_isHomePosOK.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_isHomePosOK.Name = "lbl_isHomePosOK";
            this.lbl_isHomePosOK.Size = new System.Drawing.Size(56, 27);
            this.lbl_isHomePosOK.TabIndex = 14;
            this.lbl_isHomePosOK.Text = "Home\r\nPos";
            this.lbl_isHomePosOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_isPosPosLimit
            // 
            this.lbl_isPosPosLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_isPosPosLimit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_isPosPosLimit.Location = new System.Drawing.Point(1, 88);
            this.lbl_isPosPosLimit.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_isPosPosLimit.Name = "lbl_isPosPosLimit";
            this.lbl_isPosPosLimit.Size = new System.Drawing.Size(56, 28);
            this.lbl_isPosPosLimit.TabIndex = 15;
            this.lbl_isPosPosLimit.Text = "+ Pos\r\nLimit";
            this.lbl_isPosPosLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_isPosFrcLimit
            // 
            this.lbl_isPosFrcLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_isPosFrcLimit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_isPosFrcLimit.Location = new System.Drawing.Point(59, 88);
            this.lbl_isPosFrcLimit.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_isPosFrcLimit.Name = "lbl_isPosFrcLimit";
            this.lbl_isPosFrcLimit.Size = new System.Drawing.Size(56, 28);
            this.lbl_isPosFrcLimit.TabIndex = 16;
            this.lbl_isPosFrcLimit.Text = "+ Frc\r\nLimit";
            this.lbl_isPosFrcLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_isNegPosLimit
            // 
            this.lbl_isNegPosLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_isNegPosLimit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_isNegPosLimit.Location = new System.Drawing.Point(117, 88);
            this.lbl_isNegPosLimit.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_isNegPosLimit.Name = "lbl_isNegPosLimit";
            this.lbl_isNegPosLimit.Size = new System.Drawing.Size(56, 28);
            this.lbl_isNegPosLimit.TabIndex = 17;
            this.lbl_isNegPosLimit.Text = "- Pos\r\nLimit";
            this.lbl_isNegPosLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_isNegFrcLimit
            // 
            this.lbl_isNegFrcLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_isNegFrcLimit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_isNegFrcLimit.Location = new System.Drawing.Point(175, 88);
            this.lbl_isNegFrcLimit.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_isNegFrcLimit.Name = "lbl_isNegFrcLimit";
            this.lbl_isNegFrcLimit.Size = new System.Drawing.Size(56, 28);
            this.lbl_isNegFrcLimit.TabIndex = 18;
            this.lbl_isNegFrcLimit.Text = "- Frc\r\nLimit";
            this.lbl_isNegFrcLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1000, 436);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "IN/OUT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.ItemSize = new System.Drawing.Size(100, 35);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1000, 436);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel8);
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(992, 393);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "PLC";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel19, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(986, 387);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 5;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel10.Controls.Add(this.dgv_PLC_F_Alarm, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.dgv_PLC_B_IN, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.dgv_PLC_B_OUT, 2, 1);
            this.tableLayoutPanel10.Controls.Add(this.dgv_PLC_R_IN, 3, 1);
            this.tableLayoutPanel10.Controls.Add(this.dgv_PLC_R_OUT, 4, 1);
            this.tableLayoutPanel10.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel10.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 41);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(980, 343);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // dgv_PLC_F_Alarm
            // 
            this.dgv_PLC_F_Alarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PLC_F_Alarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_PLC_F_Alarm.Location = new System.Drawing.Point(3, 37);
            this.dgv_PLC_F_Alarm.Name = "dgv_PLC_F_Alarm";
            this.dgv_PLC_F_Alarm.RowTemplate.Height = 23;
            this.dgv_PLC_F_Alarm.Size = new System.Drawing.Size(239, 303);
            this.dgv_PLC_F_Alarm.TabIndex = 0;
            // 
            // dgv_PLC_B_IN
            // 
            this.dgv_PLC_B_IN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PLC_B_IN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_PLC_B_IN.Location = new System.Drawing.Point(248, 37);
            this.dgv_PLC_B_IN.Name = "dgv_PLC_B_IN";
            this.dgv_PLC_B_IN.RowTemplate.Height = 23;
            this.dgv_PLC_B_IN.Size = new System.Drawing.Size(92, 303);
            this.dgv_PLC_B_IN.TabIndex = 1;
            // 
            // dgv_PLC_B_OUT
            // 
            this.dgv_PLC_B_OUT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PLC_B_OUT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_PLC_B_OUT.Location = new System.Drawing.Point(346, 37);
            this.dgv_PLC_B_OUT.Name = "dgv_PLC_B_OUT";
            this.dgv_PLC_B_OUT.RowTemplate.Height = 23;
            this.dgv_PLC_B_OUT.Size = new System.Drawing.Size(92, 303);
            this.dgv_PLC_B_OUT.TabIndex = 2;
            this.dgv_PLC_B_OUT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PLC_B_OUT_CellClick);
            // 
            // dgv_PLC_R_IN
            // 
            this.dgv_PLC_R_IN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PLC_R_IN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_PLC_R_IN.Location = new System.Drawing.Point(444, 37);
            this.dgv_PLC_R_IN.Name = "dgv_PLC_R_IN";
            this.dgv_PLC_R_IN.RowTemplate.Height = 23;
            this.dgv_PLC_R_IN.Size = new System.Drawing.Size(239, 303);
            this.dgv_PLC_R_IN.TabIndex = 3;
            // 
            // dgv_PLC_R_OUT
            // 
            this.dgv_PLC_R_OUT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PLC_R_OUT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_PLC_R_OUT.Location = new System.Drawing.Point(689, 37);
            this.dgv_PLC_R_OUT.Name = "dgv_PLC_R_OUT";
            this.dgv_PLC_R_OUT.RowTemplate.Height = 23;
            this.dgv_PLC_R_OUT.Size = new System.Drawing.Size(288, 303);
            this.dgv_PLC_R_OUT.TabIndex = 4;
            this.dgv_PLC_R_OUT.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PLC_R_OUT_CellValueChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "F_Alarm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(248, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "B_IN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(346, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "B_OUT";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(444, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "R_IN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(689, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 34);
            this.label7.TabIndex = 9;
            this.label7.Text = "R_OUT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 10;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel19.Controls.Add(this.btn_Connect_PLC, 0, 0);
            this.tableLayoutPanel19.Controls.Add(this.btn_Disconnect_PLC, 1, 0);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(980, 32);
            this.tableLayoutPanel19.TabIndex = 1;
            // 
            // btn_Connect_PLC
            // 
            this.btn_Connect_PLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Connect_PLC.Location = new System.Drawing.Point(3, 3);
            this.btn_Connect_PLC.Name = "btn_Connect_PLC";
            this.btn_Connect_PLC.Size = new System.Drawing.Size(92, 26);
            this.btn_Connect_PLC.TabIndex = 0;
            this.btn_Connect_PLC.Text = "Connect";
            this.btn_Connect_PLC.UseVisualStyleBackColor = true;
            this.btn_Connect_PLC.Click += new System.EventHandler(this.btn_Connect_PLC_Click);
            // 
            // btn_Disconnect_PLC
            // 
            this.btn_Disconnect_PLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Disconnect_PLC.Location = new System.Drawing.Point(101, 3);
            this.btn_Disconnect_PLC.Name = "btn_Disconnect_PLC";
            this.btn_Disconnect_PLC.Size = new System.Drawing.Size(92, 26);
            this.btn_Disconnect_PLC.TabIndex = 1;
            this.btn_Disconnect_PLC.Text = "Disconnect";
            this.btn_Disconnect_PLC.UseVisualStyleBackColor = true;
            this.btn_Disconnect_PLC.Click += new System.EventHandler(this.btn_Disconnect_PLC_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tableLayoutPanel9);
            this.tabPage6.Location = new System.Drawing.Point(4, 39);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(992, 393);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "RMC";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel12, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel18, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(986, 387);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 3;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel14, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.tabControl3, 2, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 41);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(980, 343);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.Controls.Add(this.dgv_RMC_IN, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(239, 337);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // dgv_RMC_IN
            // 
            this.dgv_RMC_IN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RMC_IN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_RMC_IN.Location = new System.Drawing.Point(3, 36);
            this.dgv_RMC_IN.Name = "dgv_RMC_IN";
            this.dgv_RMC_IN.RowTemplate.Height = 23;
            this.dgv_RMC_IN.Size = new System.Drawing.Size(233, 298);
            this.dgv_RMC_IN.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 33);
            this.label8.TabIndex = 1;
            this.label8.Text = "Input";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.Controls.Add(this.dgv_RMC_OUT, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(248, 3);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(239, 337);
            this.tableLayoutPanel14.TabIndex = 1;
            // 
            // dgv_RMC_OUT
            // 
            this.dgv_RMC_OUT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RMC_OUT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_RMC_OUT.Location = new System.Drawing.Point(3, 36);
            this.dgv_RMC_OUT.Name = "dgv_RMC_OUT";
            this.dgv_RMC_OUT.RowTemplate.Height = 23;
            this.dgv_RMC_OUT.Size = new System.Drawing.Size(233, 298);
            this.dgv_RMC_OUT.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 33);
            this.label9.TabIndex = 1;
            this.label9.Text = "Output";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.ItemSize = new System.Drawing.Size(100, 35);
            this.tabControl3.Location = new System.Drawing.Point(493, 3);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(484, 337);
            this.tabControl3.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl3.TabIndex = 2;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.tableLayoutPanel15);
            this.tabPage7.Location = new System.Drawing.Point(4, 39);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(476, 294);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Axis 0";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 3;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel16, 1, 0);
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel17, 2, 0);
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel20, 0, 0);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(470, 288);
            this.tableLayoutPanel15.TabIndex = 0;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel16.Controls.Add(this.dgv_Axis0_StatusBits, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(191, 3);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(135, 282);
            this.tableLayoutPanel16.TabIndex = 0;
            // 
            // dgv_Axis0_StatusBits
            // 
            this.dgv_Axis0_StatusBits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Axis0_StatusBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Axis0_StatusBits.Location = new System.Drawing.Point(3, 31);
            this.dgv_Axis0_StatusBits.Name = "dgv_Axis0_StatusBits";
            this.dgv_Axis0_StatusBits.RowTemplate.Height = 23;
            this.dgv_Axis0_StatusBits.Size = new System.Drawing.Size(129, 248);
            this.dgv_Axis0_StatusBits.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 28);
            this.label10.TabIndex = 1;
            this.label10.Text = "Status Bits";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 1;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel17.Controls.Add(this.dgv_Axis0_ErrorBits, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(332, 3);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(135, 282);
            this.tableLayoutPanel17.TabIndex = 1;
            // 
            // dgv_Axis0_ErrorBits
            // 
            this.dgv_Axis0_ErrorBits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Axis0_ErrorBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Axis0_ErrorBits.Location = new System.Drawing.Point(3, 31);
            this.dgv_Axis0_ErrorBits.Name = "dgv_Axis0_ErrorBits";
            this.dgv_Axis0_ErrorBits.RowTemplate.Height = 23;
            this.dgv_Axis0_ErrorBits.Size = new System.Drawing.Size(129, 248);
            this.dgv_Axis0_ErrorBits.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 28);
            this.label11.TabIndex = 1;
            this.label11.Text = "Error Bits";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 1;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel20.Controls.Add(this.dgv_Axis0_Status, 0, 1);
            this.tableLayoutPanel20.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 2;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(182, 282);
            this.tableLayoutPanel20.TabIndex = 2;
            // 
            // dgv_Axis0_Status
            // 
            this.dgv_Axis0_Status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Axis0_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Axis0_Status.Location = new System.Drawing.Point(3, 31);
            this.dgv_Axis0_Status.Name = "dgv_Axis0_Status";
            this.dgv_Axis0_Status.RowTemplate.Height = 23;
            this.dgv_Axis0_Status.Size = new System.Drawing.Size(176, 248);
            this.dgv_Axis0_Status.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(176, 28);
            this.label13.TabIndex = 1;
            this.label13.Text = "Status";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 10;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel18.Controls.Add(this.btn_Connect_RMC, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.btn_Disconnect_RMC, 1, 0);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 1;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(980, 32);
            this.tableLayoutPanel18.TabIndex = 1;
            // 
            // btn_Connect_RMC
            // 
            this.btn_Connect_RMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Connect_RMC.Location = new System.Drawing.Point(3, 3);
            this.btn_Connect_RMC.Name = "btn_Connect_RMC";
            this.btn_Connect_RMC.Size = new System.Drawing.Size(92, 26);
            this.btn_Connect_RMC.TabIndex = 0;
            this.btn_Connect_RMC.Text = "Connect";
            this.btn_Connect_RMC.UseVisualStyleBackColor = true;
            this.btn_Connect_RMC.Click += new System.EventHandler(this.btn_Connect_RMC_Click);
            // 
            // btn_Disconnect_RMC
            // 
            this.btn_Disconnect_RMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Disconnect_RMC.Location = new System.Drawing.Point(101, 3);
            this.btn_Disconnect_RMC.Name = "btn_Disconnect_RMC";
            this.btn_Disconnect_RMC.Size = new System.Drawing.Size(92, 26);
            this.btn_Disconnect_RMC.TabIndex = 1;
            this.btn_Disconnect_RMC.Text = "Disconnect";
            this.btn_Disconnect_RMC.UseVisualStyleBackColor = true;
            this.btn_Disconnect_RMC.Click += new System.EventHandler(this.btn_Disconnect_RMC_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.tableLayoutPanel23);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1000, 436);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "ZERO Set";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label33);
            this.panel4.Location = new System.Drawing.Point(350, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 300);
            this.panel4.TabIndex = 11;
            // 
            // label33
            // 
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label33.Location = new System.Drawing.Point(0, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(300, 300);
            this.label33.TabIndex = 0;
            this.label33.Text = "수동모드에서 활성화됩니다";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.ColumnCount = 2;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel23.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel23.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 2;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(994, 430);
            this.tableLayoutPanel23.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tableLayoutPanel24);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(491, 209);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Axis 0 Set Pos/Frc";
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.ColumnCount = 2;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel24.Controls.Add(this.tableLayoutPanel25, 0, 0);
            this.tableLayoutPanel24.Controls.Add(this.tableLayoutPanel26, 1, 0);
            this.tableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel24.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 1;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(485, 188);
            this.tableLayoutPanel24.TabIndex = 0;
            // 
            // tableLayoutPanel25
            // 
            this.tableLayoutPanel25.ColumnCount = 1;
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.Controls.Add(this.tableLayoutPanel27, 0, 0);
            this.tableLayoutPanel25.Controls.Add(this.tableLayoutPanel28, 0, 1);
            this.tableLayoutPanel25.Controls.Add(this.btn_Axis0_Set_Position, 0, 2);
            this.tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel25.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel25.Name = "tableLayoutPanel25";
            this.tableLayoutPanel25.RowCount = 4;
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.Size = new System.Drawing.Size(236, 182);
            this.tableLayoutPanel25.TabIndex = 0;
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.ColumnCount = 2;
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel27.Controls.Add(this.label34, 0, 0);
            this.tableLayoutPanel27.Controls.Add(this.lbl_Axis0_Actual_Pos, 1, 0);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 1;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel27.Size = new System.Drawing.Size(230, 39);
            this.tableLayoutPanel27.TabIndex = 0;
            // 
            // label34
            // 
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Location = new System.Drawing.Point(3, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(109, 39);
            this.label34.TabIndex = 0;
            this.label34.Text = "Actual Pos. [deg]";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Axis0_Actual_Pos
            // 
            this.lbl_Axis0_Actual_Pos.BackColor = System.Drawing.Color.Black;
            this.lbl_Axis0_Actual_Pos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Axis0_Actual_Pos.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Axis0_Actual_Pos.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Axis0_Actual_Pos.Location = new System.Drawing.Point(118, 0);
            this.lbl_Axis0_Actual_Pos.Name = "lbl_Axis0_Actual_Pos";
            this.lbl_Axis0_Actual_Pos.Size = new System.Drawing.Size(109, 39);
            this.lbl_Axis0_Actual_Pos.TabIndex = 1;
            this.lbl_Axis0_Actual_Pos.Text = "0.0";
            this.lbl_Axis0_Actual_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel28
            // 
            this.tableLayoutPanel28.ColumnCount = 2;
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel28.Controls.Add(this.label36, 0, 0);
            this.tableLayoutPanel28.Controls.Add(this.num_Axis0_Setting_Pos, 1, 0);
            this.tableLayoutPanel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel28.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel28.Name = "tableLayoutPanel28";
            this.tableLayoutPanel28.RowCount = 1;
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel28.Size = new System.Drawing.Size(230, 39);
            this.tableLayoutPanel28.TabIndex = 1;
            // 
            // label36
            // 
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Location = new System.Drawing.Point(3, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(109, 39);
            this.label36.TabIndex = 0;
            this.label36.Text = "Setting Pos. [deg]";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num_Axis0_Setting_Pos
            // 
            this.num_Axis0_Setting_Pos.DecimalPlaces = 3;
            this.num_Axis0_Setting_Pos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_Axis0_Setting_Pos.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num_Axis0_Setting_Pos.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Setting_Pos.Location = new System.Drawing.Point(118, 3);
            this.num_Axis0_Setting_Pos.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Setting_Pos.Name = "num_Axis0_Setting_Pos";
            this.num_Axis0_Setting_Pos.Size = new System.Drawing.Size(109, 36);
            this.num_Axis0_Setting_Pos.TabIndex = 1;
            // 
            // btn_Axis0_Set_Position
            // 
            this.btn_Axis0_Set_Position.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Axis0_Set_Position.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Axis0_Set_Position.Location = new System.Drawing.Point(3, 93);
            this.btn_Axis0_Set_Position.Name = "btn_Axis0_Set_Position";
            this.btn_Axis0_Set_Position.Size = new System.Drawing.Size(230, 39);
            this.btn_Axis0_Set_Position.TabIndex = 2;
            this.btn_Axis0_Set_Position.Text = "Set Position";
            this.btn_Axis0_Set_Position.UseVisualStyleBackColor = true;
            this.btn_Axis0_Set_Position.Click += new System.EventHandler(this.btn_Set_Position_Click);
            // 
            // tableLayoutPanel26
            // 
            this.tableLayoutPanel26.ColumnCount = 1;
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel26.Controls.Add(this.tableLayoutPanel29, 0, 0);
            this.tableLayoutPanel26.Controls.Add(this.tableLayoutPanel30, 0, 1);
            this.tableLayoutPanel26.Controls.Add(this.btn_Axis0_Set_Force, 0, 2);
            this.tableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel26.Location = new System.Drawing.Point(245, 3);
            this.tableLayoutPanel26.Name = "tableLayoutPanel26";
            this.tableLayoutPanel26.RowCount = 4;
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(237, 182);
            this.tableLayoutPanel26.TabIndex = 1;
            // 
            // tableLayoutPanel29
            // 
            this.tableLayoutPanel29.ColumnCount = 2;
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel29.Controls.Add(this.label38, 0, 0);
            this.tableLayoutPanel29.Controls.Add(this.lbl_Axis0_Actual_Frc, 1, 0);
            this.tableLayoutPanel29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel29.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel29.Name = "tableLayoutPanel29";
            this.tableLayoutPanel29.RowCount = 1;
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel29.Size = new System.Drawing.Size(231, 39);
            this.tableLayoutPanel29.TabIndex = 0;
            // 
            // label38
            // 
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Location = new System.Drawing.Point(3, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(109, 39);
            this.label38.TabIndex = 0;
            this.label38.Text = "Actual Frc. [Nm]";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Axis0_Actual_Frc
            // 
            this.lbl_Axis0_Actual_Frc.BackColor = System.Drawing.Color.Black;
            this.lbl_Axis0_Actual_Frc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Axis0_Actual_Frc.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Axis0_Actual_Frc.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Axis0_Actual_Frc.Location = new System.Drawing.Point(118, 0);
            this.lbl_Axis0_Actual_Frc.Name = "lbl_Axis0_Actual_Frc";
            this.lbl_Axis0_Actual_Frc.Size = new System.Drawing.Size(110, 39);
            this.lbl_Axis0_Actual_Frc.TabIndex = 1;
            this.lbl_Axis0_Actual_Frc.Text = "0.0";
            this.lbl_Axis0_Actual_Frc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel30
            // 
            this.tableLayoutPanel30.ColumnCount = 2;
            this.tableLayoutPanel30.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel30.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel30.Controls.Add(this.label40, 0, 0);
            this.tableLayoutPanel30.Controls.Add(this.num_Axis0_Setting_Frc, 1, 0);
            this.tableLayoutPanel30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel30.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel30.Name = "tableLayoutPanel30";
            this.tableLayoutPanel30.RowCount = 1;
            this.tableLayoutPanel30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel30.Size = new System.Drawing.Size(231, 39);
            this.tableLayoutPanel30.TabIndex = 1;
            // 
            // label40
            // 
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Location = new System.Drawing.Point(3, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(109, 39);
            this.label40.TabIndex = 0;
            this.label40.Text = "Setting Frc. [Nm]";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num_Axis0_Setting_Frc
            // 
            this.num_Axis0_Setting_Frc.DecimalPlaces = 3;
            this.num_Axis0_Setting_Frc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_Axis0_Setting_Frc.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num_Axis0_Setting_Frc.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Setting_Frc.Location = new System.Drawing.Point(118, 3);
            this.num_Axis0_Setting_Frc.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Setting_Frc.Name = "num_Axis0_Setting_Frc";
            this.num_Axis0_Setting_Frc.Size = new System.Drawing.Size(110, 36);
            this.num_Axis0_Setting_Frc.TabIndex = 1;
            // 
            // btn_Axis0_Set_Force
            // 
            this.btn_Axis0_Set_Force.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Axis0_Set_Force.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Axis0_Set_Force.Location = new System.Drawing.Point(3, 93);
            this.btn_Axis0_Set_Force.Name = "btn_Axis0_Set_Force";
            this.btn_Axis0_Set_Force.Size = new System.Drawing.Size(231, 39);
            this.btn_Axis0_Set_Force.TabIndex = 2;
            this.btn_Axis0_Set_Force.Text = "Set Force";
            this.btn_Axis0_Set_Force.UseVisualStyleBackColor = true;
            this.btn_Axis0_Set_Force.Click += new System.EventHandler(this.btn_Set_Force_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Move_Absolute);
            this.groupBox3.Controls.Add(this.label63);
            this.groupBox3.Controls.Add(this.label61);
            this.groupBox3.Controls.Add(this.label59);
            this.groupBox3.Controls.Add(this.num_Move_Decel);
            this.groupBox3.Controls.Add(this.num_Move_Accel);
            this.groupBox3.Controls.Add(this.num_Move_Speed);
            this.groupBox3.Controls.Add(this.num_Move_Position);
            this.groupBox3.Controls.Add(this.label57);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 209);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Axis 0 Move Absolute (20)";
            // 
            // btn_Move_Absolute
            // 
            this.btn_Move_Absolute.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Move_Absolute.Location = new System.Drawing.Point(48, 134);
            this.btn_Move_Absolute.Name = "btn_Move_Absolute";
            this.btn_Move_Absolute.Size = new System.Drawing.Size(188, 44);
            this.btn_Move_Absolute.TabIndex = 8;
            this.btn_Move_Absolute.Text = "Move Absolute";
            this.btn_Move_Absolute.UseVisualStyleBackColor = true;
            this.btn_Move_Absolute.Click += new System.EventHandler(this.btn_Move_Absolute_Click);
            // 
            // label63
            // 
            this.label63.Location = new System.Drawing.Point(10, 104);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(144, 22);
            this.label63.TabIndex = 7;
            this.label63.Text = "Decel Rate (deg/s2) :";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label61
            // 
            this.label61.Location = new System.Drawing.Point(10, 76);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(144, 22);
            this.label61.TabIndex = 6;
            this.label61.Text = "Accel Rate (deg/s2) :";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label59
            // 
            this.label59.Location = new System.Drawing.Point(10, 48);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(144, 22);
            this.label59.TabIndex = 5;
            this.label59.Text = "Speed (deg/s) :";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num_Move_Decel
            // 
            this.num_Move_Decel.DecimalPlaces = 1;
            this.num_Move_Decel.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_Move_Decel.Location = new System.Drawing.Point(160, 106);
            this.num_Move_Decel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Move_Decel.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_Move_Decel.Name = "num_Move_Decel";
            this.num_Move_Decel.Size = new System.Drawing.Size(88, 22);
            this.num_Move_Decel.TabIndex = 4;
            this.num_Move_Decel.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // num_Move_Accel
            // 
            this.num_Move_Accel.DecimalPlaces = 1;
            this.num_Move_Accel.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_Move_Accel.Location = new System.Drawing.Point(160, 78);
            this.num_Move_Accel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Move_Accel.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_Move_Accel.Name = "num_Move_Accel";
            this.num_Move_Accel.Size = new System.Drawing.Size(88, 22);
            this.num_Move_Accel.TabIndex = 3;
            this.num_Move_Accel.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // num_Move_Speed
            // 
            this.num_Move_Speed.DecimalPlaces = 1;
            this.num_Move_Speed.Location = new System.Drawing.Point(160, 50);
            this.num_Move_Speed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Move_Speed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_Move_Speed.Name = "num_Move_Speed";
            this.num_Move_Speed.Size = new System.Drawing.Size(88, 22);
            this.num_Move_Speed.TabIndex = 2;
            this.num_Move_Speed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // num_Move_Position
            // 
            this.num_Move_Position.DecimalPlaces = 1;
            this.num_Move_Position.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Move_Position.Location = new System.Drawing.Point(160, 22);
            this.num_Move_Position.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.num_Move_Position.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.num_Move_Position.Name = "num_Move_Position";
            this.num_Move_Position.Size = new System.Drawing.Size(88, 22);
            this.num_Move_Position.TabIndex = 1;
            // 
            // label57
            // 
            this.label57.Location = new System.Drawing.Point(10, 20);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(144, 22);
            this.label57.TabIndex = 0;
            this.label57.Text = "Position (deg) :";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.tabControl4);
            this.tabPage8.Location = new System.Drawing.Point(4, 39);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1000, 436);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "Parameter Set";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage9);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.ItemSize = new System.Drawing.Size(100, 35);
            this.tabControl4.Location = new System.Drawing.Point(0, 0);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(1000, 436);
            this.tabControl4.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl4.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.tabControl5);
            this.tabPage9.Location = new System.Drawing.Point(4, 39);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(992, 393);
            this.tabPage9.TabIndex = 0;
            this.tabPage9.Text = "Axis 0";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage10);
            this.tabControl5.Controls.Add(this.tabPage11);
            this.tabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl5.ItemSize = new System.Drawing.Size(100, 35);
            this.tabControl5.Location = new System.Drawing.Point(3, 3);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(986, 387);
            this.tabControl5.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl5.TabIndex = 0;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.btn_Axis0_Position_V_Write);
            this.tabPage10.Controls.Add(this.btn_Axis0_Position_V_Open);
            this.tabPage10.Controls.Add(this.groupBox9);
            this.tabPage10.Controls.Add(this.btn_Axis0_Position_G_Write);
            this.tabPage10.Controls.Add(this.btn_Axis0_Position_G_Open);
            this.tabPage10.Controls.Add(this.groupBox11);
            this.tabPage10.Location = new System.Drawing.Point(4, 39);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(978, 344);
            this.tabPage10.TabIndex = 0;
            this.tabPage10.Text = "Position";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // btn_Axis0_Position_V_Write
            // 
            this.btn_Axis0_Position_V_Write.Location = new System.Drawing.Point(366, 387);
            this.btn_Axis0_Position_V_Write.Name = "btn_Axis0_Position_V_Write";
            this.btn_Axis0_Position_V_Write.Size = new System.Drawing.Size(80, 30);
            this.btn_Axis0_Position_V_Write.TabIndex = 28;
            this.btn_Axis0_Position_V_Write.TabStop = false;
            this.btn_Axis0_Position_V_Write.Text = "V_Write";
            this.btn_Axis0_Position_V_Write.UseVisualStyleBackColor = true;
            this.btn_Axis0_Position_V_Write.Click += new System.EventHandler(this.btn_Position_Write_Click);
            // 
            // btn_Axis0_Position_V_Open
            // 
            this.btn_Axis0_Position_V_Open.Location = new System.Drawing.Point(280, 387);
            this.btn_Axis0_Position_V_Open.Name = "btn_Axis0_Position_V_Open";
            this.btn_Axis0_Position_V_Open.Size = new System.Drawing.Size(80, 30);
            this.btn_Axis0_Position_V_Open.TabIndex = 27;
            this.btn_Axis0_Position_V_Open.TabStop = false;
            this.btn_Axis0_Position_V_Open.Text = "V_Open";
            this.btn_Axis0_Position_V_Open.UseVisualStyleBackColor = true;
            this.btn_Axis0_Position_V_Open.Click += new System.EventHandler(this.btn_Position_Open_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label35);
            this.groupBox9.Controls.Add(this.label37);
            this.groupBox9.Controls.Add(this.label39);
            this.groupBox9.Controls.Add(this.label41);
            this.groupBox9.Controls.Add(this.label42);
            this.groupBox9.Controls.Add(this.label43);
            this.groupBox9.Controls.Add(this.label44);
            this.groupBox9.Controls.Add(this.label45);
            this.groupBox9.Controls.Add(this.label46);
            this.groupBox9.Controls.Add(this.label47);
            this.groupBox9.Controls.Add(this.label48);
            this.groupBox9.Controls.Add(this.label49);
            this.groupBox9.Controls.Add(this.label50);
            this.groupBox9.Controls.Add(this.num_Axis0_Position_WarningError);
            this.groupBox9.Controls.Add(this.num_Axis0_Position_FatalError);
            this.groupBox9.Controls.Add(this.num_Axis0_Position_Offset);
            this.groupBox9.Controls.Add(this.num_Axis0_Position_InPositionTolerance);
            this.groupBox9.Controls.Add(this.num_Axis0_Position_AutoAccTime);
            this.groupBox9.Controls.Add(this.num_Axis0_Position_AutoVelocity);
            this.groupBox9.Controls.Add(this.num_Axis0_Position_HomePosition);
            this.groupBox9.Controls.Add(this.num_Axis0_Position_HomeAccTime);
            this.groupBox9.Controls.Add(this.num_Axis0_Position_HomeVelocity);
            this.groupBox9.Controls.Add(this.num_Axis0_Position_ManualAccTime);
            this.groupBox9.Controls.Add(this.num_Axis0_Position_ManualVelocity);
            this.groupBox9.Controls.Add(this.num_Axis0_Position_MaxJogVelocity);
            this.groupBox9.Controls.Add(this.num_Axis0_Position_MaxAcc);
            this.groupBox9.Controls.Add(this.num_Axis0_Position_MaxVelocity);
            this.groupBox9.Controls.Add(this.label51);
            this.groupBox9.Location = new System.Drawing.Point(216, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(250, 375);
            this.groupBox9.TabIndex = 26;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Position Set";
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(10, 344);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(140, 22);
            this.label35.TabIndex = 28;
            this.label35.Text = "Warning Error :";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(10, 321);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(140, 22);
            this.label37.TabIndex = 27;
            this.label37.Text = "Fatal Error :";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label39
            // 
            this.label39.Location = new System.Drawing.Point(10, 293);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(140, 22);
            this.label39.TabIndex = 26;
            this.label39.Text = "Offset :";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label41
            // 
            this.label41.Location = new System.Drawing.Point(10, 265);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(140, 22);
            this.label41.TabIndex = 25;
            this.label41.Text = "In-Position Tolerance :";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label42
            // 
            this.label42.Location = new System.Drawing.Point(10, 242);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(140, 22);
            this.label42.TabIndex = 24;
            this.label42.Text = "Auto. Acc Time :";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label43
            // 
            this.label43.Location = new System.Drawing.Point(10, 219);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(140, 22);
            this.label43.TabIndex = 23;
            this.label43.Text = "Auto. Velocity :";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label44
            // 
            this.label44.Location = new System.Drawing.Point(10, 191);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(140, 22);
            this.label44.TabIndex = 22;
            this.label44.Text = "Home. Position :";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label45
            // 
            this.label45.Location = new System.Drawing.Point(10, 168);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(140, 22);
            this.label45.TabIndex = 21;
            this.label45.Text = "Home. Acc Time :";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label46
            // 
            this.label46.Location = new System.Drawing.Point(10, 145);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(140, 22);
            this.label46.TabIndex = 20;
            this.label46.Text = "Home. Velocity :";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label47
            // 
            this.label47.Location = new System.Drawing.Point(10, 117);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(140, 22);
            this.label47.TabIndex = 19;
            this.label47.Text = "Manual. Acc Time :";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label48
            // 
            this.label48.Location = new System.Drawing.Point(10, 94);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(140, 22);
            this.label48.TabIndex = 18;
            this.label48.Text = "Manual. Velocity :";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label49
            // 
            this.label49.Location = new System.Drawing.Point(10, 66);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(140, 22);
            this.label49.TabIndex = 17;
            this.label49.Text = "Max. Jog Velocity :";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label50
            // 
            this.label50.Location = new System.Drawing.Point(10, 43);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(140, 22);
            this.label50.TabIndex = 16;
            this.label50.Text = "Max. Acc :";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num_Axis0_Position_WarningError
            // 
            this.num_Axis0_Position_WarningError.DecimalPlaces = 1;
            this.num_Axis0_Position_WarningError.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_WarningError.Location = new System.Drawing.Point(156, 346);
            this.num_Axis0_Position_WarningError.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_WarningError.Name = "num_Axis0_Position_WarningError";
            this.num_Axis0_Position_WarningError.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Position_WarningError.TabIndex = 15;
            // 
            // num_Axis0_Position_FatalError
            // 
            this.num_Axis0_Position_FatalError.DecimalPlaces = 1;
            this.num_Axis0_Position_FatalError.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_FatalError.Location = new System.Drawing.Point(156, 323);
            this.num_Axis0_Position_FatalError.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_FatalError.Name = "num_Axis0_Position_FatalError";
            this.num_Axis0_Position_FatalError.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Position_FatalError.TabIndex = 14;
            // 
            // num_Axis0_Position_Offset
            // 
            this.num_Axis0_Position_Offset.DecimalPlaces = 1;
            this.num_Axis0_Position_Offset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_Offset.Location = new System.Drawing.Point(156, 295);
            this.num_Axis0_Position_Offset.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_Offset.Name = "num_Axis0_Position_Offset";
            this.num_Axis0_Position_Offset.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Position_Offset.TabIndex = 13;
            // 
            // num_Axis0_Position_InPositionTolerance
            // 
            this.num_Axis0_Position_InPositionTolerance.DecimalPlaces = 1;
            this.num_Axis0_Position_InPositionTolerance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_InPositionTolerance.Location = new System.Drawing.Point(156, 267);
            this.num_Axis0_Position_InPositionTolerance.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_InPositionTolerance.Name = "num_Axis0_Position_InPositionTolerance";
            this.num_Axis0_Position_InPositionTolerance.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Position_InPositionTolerance.TabIndex = 12;
            // 
            // num_Axis0_Position_AutoAccTime
            // 
            this.num_Axis0_Position_AutoAccTime.DecimalPlaces = 1;
            this.num_Axis0_Position_AutoAccTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_AutoAccTime.Location = new System.Drawing.Point(156, 244);
            this.num_Axis0_Position_AutoAccTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_AutoAccTime.Name = "num_Axis0_Position_AutoAccTime";
            this.num_Axis0_Position_AutoAccTime.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Position_AutoAccTime.TabIndex = 11;
            // 
            // num_Axis0_Position_AutoVelocity
            // 
            this.num_Axis0_Position_AutoVelocity.DecimalPlaces = 1;
            this.num_Axis0_Position_AutoVelocity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_AutoVelocity.Location = new System.Drawing.Point(156, 221);
            this.num_Axis0_Position_AutoVelocity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_AutoVelocity.Name = "num_Axis0_Position_AutoVelocity";
            this.num_Axis0_Position_AutoVelocity.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Position_AutoVelocity.TabIndex = 10;
            // 
            // num_Axis0_Position_HomePosition
            // 
            this.num_Axis0_Position_HomePosition.DecimalPlaces = 1;
            this.num_Axis0_Position_HomePosition.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_HomePosition.Location = new System.Drawing.Point(156, 193);
            this.num_Axis0_Position_HomePosition.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_HomePosition.Name = "num_Axis0_Position_HomePosition";
            this.num_Axis0_Position_HomePosition.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Position_HomePosition.TabIndex = 9;
            // 
            // num_Axis0_Position_HomeAccTime
            // 
            this.num_Axis0_Position_HomeAccTime.DecimalPlaces = 1;
            this.num_Axis0_Position_HomeAccTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_HomeAccTime.Location = new System.Drawing.Point(156, 170);
            this.num_Axis0_Position_HomeAccTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_HomeAccTime.Name = "num_Axis0_Position_HomeAccTime";
            this.num_Axis0_Position_HomeAccTime.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Position_HomeAccTime.TabIndex = 8;
            // 
            // num_Axis0_Position_HomeVelocity
            // 
            this.num_Axis0_Position_HomeVelocity.DecimalPlaces = 1;
            this.num_Axis0_Position_HomeVelocity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_HomeVelocity.Location = new System.Drawing.Point(156, 147);
            this.num_Axis0_Position_HomeVelocity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_HomeVelocity.Name = "num_Axis0_Position_HomeVelocity";
            this.num_Axis0_Position_HomeVelocity.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Position_HomeVelocity.TabIndex = 7;
            // 
            // num_Axis0_Position_ManualAccTime
            // 
            this.num_Axis0_Position_ManualAccTime.DecimalPlaces = 1;
            this.num_Axis0_Position_ManualAccTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_ManualAccTime.Location = new System.Drawing.Point(156, 119);
            this.num_Axis0_Position_ManualAccTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_ManualAccTime.Name = "num_Axis0_Position_ManualAccTime";
            this.num_Axis0_Position_ManualAccTime.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Position_ManualAccTime.TabIndex = 6;
            // 
            // num_Axis0_Position_ManualVelocity
            // 
            this.num_Axis0_Position_ManualVelocity.DecimalPlaces = 1;
            this.num_Axis0_Position_ManualVelocity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_ManualVelocity.Location = new System.Drawing.Point(156, 96);
            this.num_Axis0_Position_ManualVelocity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_ManualVelocity.Name = "num_Axis0_Position_ManualVelocity";
            this.num_Axis0_Position_ManualVelocity.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Position_ManualVelocity.TabIndex = 5;
            // 
            // num_Axis0_Position_MaxJogVelocity
            // 
            this.num_Axis0_Position_MaxJogVelocity.DecimalPlaces = 1;
            this.num_Axis0_Position_MaxJogVelocity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_MaxJogVelocity.Location = new System.Drawing.Point(156, 68);
            this.num_Axis0_Position_MaxJogVelocity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_MaxJogVelocity.Name = "num_Axis0_Position_MaxJogVelocity";
            this.num_Axis0_Position_MaxJogVelocity.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Position_MaxJogVelocity.TabIndex = 4;
            // 
            // num_Axis0_Position_MaxAcc
            // 
            this.num_Axis0_Position_MaxAcc.DecimalPlaces = 1;
            this.num_Axis0_Position_MaxAcc.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_MaxAcc.Location = new System.Drawing.Point(156, 45);
            this.num_Axis0_Position_MaxAcc.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_MaxAcc.Name = "num_Axis0_Position_MaxAcc";
            this.num_Axis0_Position_MaxAcc.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Position_MaxAcc.TabIndex = 3;
            // 
            // num_Axis0_Position_MaxVelocity
            // 
            this.num_Axis0_Position_MaxVelocity.DecimalPlaces = 1;
            this.num_Axis0_Position_MaxVelocity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_MaxVelocity.Location = new System.Drawing.Point(156, 22);
            this.num_Axis0_Position_MaxVelocity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_MaxVelocity.Name = "num_Axis0_Position_MaxVelocity";
            this.num_Axis0_Position_MaxVelocity.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Position_MaxVelocity.TabIndex = 2;
            // 
            // label51
            // 
            this.label51.Location = new System.Drawing.Point(10, 20);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(140, 22);
            this.label51.TabIndex = 1;
            this.label51.Text = "Max. Velocity :";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Axis0_Position_G_Write
            // 
            this.btn_Axis0_Position_G_Write.Location = new System.Drawing.Point(106, 232);
            this.btn_Axis0_Position_G_Write.Name = "btn_Axis0_Position_G_Write";
            this.btn_Axis0_Position_G_Write.Size = new System.Drawing.Size(80, 30);
            this.btn_Axis0_Position_G_Write.TabIndex = 22;
            this.btn_Axis0_Position_G_Write.TabStop = false;
            this.btn_Axis0_Position_G_Write.Text = "G_Write";
            this.btn_Axis0_Position_G_Write.UseVisualStyleBackColor = true;
            this.btn_Axis0_Position_G_Write.Click += new System.EventHandler(this.btn_Position_Write_Click);
            // 
            // btn_Axis0_Position_G_Open
            // 
            this.btn_Axis0_Position_G_Open.Location = new System.Drawing.Point(20, 232);
            this.btn_Axis0_Position_G_Open.Name = "btn_Axis0_Position_G_Open";
            this.btn_Axis0_Position_G_Open.Size = new System.Drawing.Size(80, 30);
            this.btn_Axis0_Position_G_Open.TabIndex = 21;
            this.btn_Axis0_Position_G_Open.TabStop = false;
            this.btn_Axis0_Position_G_Open.Text = "G_Open";
            this.btn_Axis0_Position_G_Open.UseVisualStyleBackColor = true;
            this.btn_Axis0_Position_G_Open.Click += new System.EventHandler(this.btn_Position_Open_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label52);
            this.groupBox11.Controls.Add(this.label53);
            this.groupBox11.Controls.Add(this.label54);
            this.groupBox11.Controls.Add(this.label55);
            this.groupBox11.Controls.Add(this.num_Axis0_Position_Gain_KffN);
            this.groupBox11.Controls.Add(this.num_Axis0_Position_Gain_KffP);
            this.groupBox11.Controls.Add(this.num_Axis0_Position_Gain_Kd);
            this.groupBox11.Controls.Add(this.num_Axis0_Position_Gain_Ki);
            this.groupBox11.Controls.Add(this.num_Axis0_Position_Gain_Kp);
            this.groupBox11.Controls.Add(this.label56);
            this.groupBox11.Location = new System.Drawing.Point(6, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(200, 220);
            this.groupBox11.TabIndex = 20;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Gain";
            // 
            // label52
            // 
            this.label52.Location = new System.Drawing.Point(0, 132);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(54, 22);
            this.label52.TabIndex = 10;
            this.label52.Text = "Kff(N) :";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label53
            // 
            this.label53.Location = new System.Drawing.Point(0, 104);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(54, 22);
            this.label53.TabIndex = 9;
            this.label53.Text = "Kff(P) :";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label54
            // 
            this.label54.Location = new System.Drawing.Point(10, 76);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(44, 22);
            this.label54.TabIndex = 8;
            this.label54.Text = "Kd :";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label55
            // 
            this.label55.Location = new System.Drawing.Point(10, 48);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(44, 22);
            this.label55.TabIndex = 7;
            this.label55.Text = "Ki :";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num_Axis0_Position_Gain_KffN
            // 
            this.num_Axis0_Position_Gain_KffN.DecimalPlaces = 3;
            this.num_Axis0_Position_Gain_KffN.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_Gain_KffN.Location = new System.Drawing.Point(60, 134);
            this.num_Axis0_Position_Gain_KffN.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_Gain_KffN.Name = "num_Axis0_Position_Gain_KffN";
            this.num_Axis0_Position_Gain_KffN.Size = new System.Drawing.Size(120, 22);
            this.num_Axis0_Position_Gain_KffN.TabIndex = 6;
            // 
            // num_Axis0_Position_Gain_KffP
            // 
            this.num_Axis0_Position_Gain_KffP.DecimalPlaces = 3;
            this.num_Axis0_Position_Gain_KffP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_Gain_KffP.Location = new System.Drawing.Point(60, 106);
            this.num_Axis0_Position_Gain_KffP.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_Gain_KffP.Name = "num_Axis0_Position_Gain_KffP";
            this.num_Axis0_Position_Gain_KffP.Size = new System.Drawing.Size(120, 22);
            this.num_Axis0_Position_Gain_KffP.TabIndex = 5;
            // 
            // num_Axis0_Position_Gain_Kd
            // 
            this.num_Axis0_Position_Gain_Kd.DecimalPlaces = 3;
            this.num_Axis0_Position_Gain_Kd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_Gain_Kd.Location = new System.Drawing.Point(60, 78);
            this.num_Axis0_Position_Gain_Kd.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_Gain_Kd.Name = "num_Axis0_Position_Gain_Kd";
            this.num_Axis0_Position_Gain_Kd.Size = new System.Drawing.Size(120, 22);
            this.num_Axis0_Position_Gain_Kd.TabIndex = 4;
            // 
            // num_Axis0_Position_Gain_Ki
            // 
            this.num_Axis0_Position_Gain_Ki.DecimalPlaces = 3;
            this.num_Axis0_Position_Gain_Ki.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_Gain_Ki.Location = new System.Drawing.Point(60, 50);
            this.num_Axis0_Position_Gain_Ki.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_Gain_Ki.Name = "num_Axis0_Position_Gain_Ki";
            this.num_Axis0_Position_Gain_Ki.Size = new System.Drawing.Size(120, 22);
            this.num_Axis0_Position_Gain_Ki.TabIndex = 3;
            // 
            // num_Axis0_Position_Gain_Kp
            // 
            this.num_Axis0_Position_Gain_Kp.DecimalPlaces = 3;
            this.num_Axis0_Position_Gain_Kp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Position_Gain_Kp.Location = new System.Drawing.Point(60, 22);
            this.num_Axis0_Position_Gain_Kp.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Position_Gain_Kp.Name = "num_Axis0_Position_Gain_Kp";
            this.num_Axis0_Position_Gain_Kp.Size = new System.Drawing.Size(120, 22);
            this.num_Axis0_Position_Gain_Kp.TabIndex = 2;
            // 
            // label56
            // 
            this.label56.Location = new System.Drawing.Point(10, 20);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(44, 22);
            this.label56.TabIndex = 1;
            this.label56.Text = "Kp :";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.btn_Axis0_Force_V_Write);
            this.tabPage11.Controls.Add(this.btn_Axis0_Force_V_Open);
            this.tabPage11.Controls.Add(this.groupBox7);
            this.tabPage11.Controls.Add(this.btn_Axis0_Force_G_Write);
            this.tabPage11.Controls.Add(this.btn_Axis0_Force_G_Open);
            this.tabPage11.Controls.Add(this.groupBox5);
            this.tabPage11.Location = new System.Drawing.Point(4, 39);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(978, 344);
            this.tabPage11.TabIndex = 1;
            this.tabPage11.Text = "Force";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // btn_Axis0_Force_V_Write
            // 
            this.btn_Axis0_Force_V_Write.Location = new System.Drawing.Point(366, 387);
            this.btn_Axis0_Force_V_Write.Name = "btn_Axis0_Force_V_Write";
            this.btn_Axis0_Force_V_Write.Size = new System.Drawing.Size(80, 30);
            this.btn_Axis0_Force_V_Write.TabIndex = 19;
            this.btn_Axis0_Force_V_Write.TabStop = false;
            this.btn_Axis0_Force_V_Write.Text = "V_Write";
            this.btn_Axis0_Force_V_Write.UseVisualStyleBackColor = true;
            this.btn_Axis0_Force_V_Write.Click += new System.EventHandler(this.btn_Force_Write_Click);
            // 
            // btn_Axis0_Force_V_Open
            // 
            this.btn_Axis0_Force_V_Open.Location = new System.Drawing.Point(280, 387);
            this.btn_Axis0_Force_V_Open.Name = "btn_Axis0_Force_V_Open";
            this.btn_Axis0_Force_V_Open.Size = new System.Drawing.Size(80, 30);
            this.btn_Axis0_Force_V_Open.TabIndex = 18;
            this.btn_Axis0_Force_V_Open.TabStop = false;
            this.btn_Axis0_Force_V_Open.Text = "V_Open";
            this.btn_Axis0_Force_V_Open.UseVisualStyleBackColor = true;
            this.btn_Axis0_Force_V_Open.Click += new System.EventHandler(this.btn_Force_Open_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Controls.Add(this.label31);
            this.groupBox7.Controls.Add(this.label30);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Controls.Add(this.label28);
            this.groupBox7.Controls.Add(this.label27);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.num_Axis0_Force_WarningError);
            this.groupBox7.Controls.Add(this.num_Axis0_Force_FatalError);
            this.groupBox7.Controls.Add(this.num_Axis0_Force_Offset);
            this.groupBox7.Controls.Add(this.num_Axis0_Force_InPositionTolerance);
            this.groupBox7.Controls.Add(this.num_Axis0_Force_AutoAccTime);
            this.groupBox7.Controls.Add(this.num_Axis0_Force_AutoVelocity);
            this.groupBox7.Controls.Add(this.num_Axis0_Force_HomePosition);
            this.groupBox7.Controls.Add(this.num_Axis0_Force_HomeAccTime);
            this.groupBox7.Controls.Add(this.num_Axis0_Force_HomeVelocity);
            this.groupBox7.Controls.Add(this.num_Axis0_Force_ManualAccTime);
            this.groupBox7.Controls.Add(this.num_Axis0_Force_ManualVelocity);
            this.groupBox7.Controls.Add(this.num_Axis0_Force_MaxJogVelocity);
            this.groupBox7.Controls.Add(this.num_Axis0_Force_MaxAcc);
            this.groupBox7.Controls.Add(this.num_Axis0_Force_MaxVelocity);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Location = new System.Drawing.Point(216, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(250, 375);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Force Set";
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(10, 344);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(140, 22);
            this.label32.TabIndex = 28;
            this.label32.Text = "Warning Error :";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(10, 321);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(140, 22);
            this.label31.TabIndex = 27;
            this.label31.Text = "Fatal Error :";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(10, 293);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(140, 22);
            this.label30.TabIndex = 26;
            this.label30.Text = "Offset :";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(10, 265);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(140, 22);
            this.label29.TabIndex = 25;
            this.label29.Text = "In-Position Tolerance :";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(10, 242);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(140, 22);
            this.label28.TabIndex = 24;
            this.label28.Text = "Auto. Acc Time :";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(10, 219);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(140, 22);
            this.label27.TabIndex = 23;
            this.label27.Text = "Auto. Velocity :";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(10, 191);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(140, 22);
            this.label26.TabIndex = 22;
            this.label26.Text = "Home. Position :";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(10, 168);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(140, 22);
            this.label25.TabIndex = 21;
            this.label25.Text = "Home. Acc Time :";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(10, 145);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(140, 22);
            this.label24.TabIndex = 20;
            this.label24.Text = "Home. Velocity :";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(10, 117);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(140, 22);
            this.label22.TabIndex = 19;
            this.label22.Text = "Manual. Acc Time :";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(10, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(140, 22);
            this.label21.TabIndex = 18;
            this.label21.Text = "Manual. Velocity :";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(10, 66);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(140, 22);
            this.label20.TabIndex = 17;
            this.label20.Text = "Max. Jog Velocity :";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(10, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 22);
            this.label19.TabIndex = 16;
            this.label19.Text = "Max. Acc :";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num_Axis0_Force_WarningError
            // 
            this.num_Axis0_Force_WarningError.DecimalPlaces = 1;
            this.num_Axis0_Force_WarningError.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_WarningError.Location = new System.Drawing.Point(156, 346);
            this.num_Axis0_Force_WarningError.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_WarningError.Name = "num_Axis0_Force_WarningError";
            this.num_Axis0_Force_WarningError.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Force_WarningError.TabIndex = 15;
            // 
            // num_Axis0_Force_FatalError
            // 
            this.num_Axis0_Force_FatalError.DecimalPlaces = 1;
            this.num_Axis0_Force_FatalError.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_FatalError.Location = new System.Drawing.Point(156, 323);
            this.num_Axis0_Force_FatalError.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_FatalError.Name = "num_Axis0_Force_FatalError";
            this.num_Axis0_Force_FatalError.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Force_FatalError.TabIndex = 14;
            // 
            // num_Axis0_Force_Offset
            // 
            this.num_Axis0_Force_Offset.DecimalPlaces = 1;
            this.num_Axis0_Force_Offset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_Offset.Location = new System.Drawing.Point(156, 295);
            this.num_Axis0_Force_Offset.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_Offset.Name = "num_Axis0_Force_Offset";
            this.num_Axis0_Force_Offset.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Force_Offset.TabIndex = 13;
            // 
            // num_Axis0_Force_InPositionTolerance
            // 
            this.num_Axis0_Force_InPositionTolerance.DecimalPlaces = 1;
            this.num_Axis0_Force_InPositionTolerance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_InPositionTolerance.Location = new System.Drawing.Point(156, 267);
            this.num_Axis0_Force_InPositionTolerance.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_InPositionTolerance.Name = "num_Axis0_Force_InPositionTolerance";
            this.num_Axis0_Force_InPositionTolerance.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Force_InPositionTolerance.TabIndex = 12;
            // 
            // num_Axis0_Force_AutoAccTime
            // 
            this.num_Axis0_Force_AutoAccTime.DecimalPlaces = 1;
            this.num_Axis0_Force_AutoAccTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_AutoAccTime.Location = new System.Drawing.Point(156, 244);
            this.num_Axis0_Force_AutoAccTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_AutoAccTime.Name = "num_Axis0_Force_AutoAccTime";
            this.num_Axis0_Force_AutoAccTime.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Force_AutoAccTime.TabIndex = 11;
            // 
            // num_Axis0_Force_AutoVelocity
            // 
            this.num_Axis0_Force_AutoVelocity.DecimalPlaces = 1;
            this.num_Axis0_Force_AutoVelocity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_AutoVelocity.Location = new System.Drawing.Point(156, 221);
            this.num_Axis0_Force_AutoVelocity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_AutoVelocity.Name = "num_Axis0_Force_AutoVelocity";
            this.num_Axis0_Force_AutoVelocity.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Force_AutoVelocity.TabIndex = 10;
            // 
            // num_Axis0_Force_HomePosition
            // 
            this.num_Axis0_Force_HomePosition.DecimalPlaces = 1;
            this.num_Axis0_Force_HomePosition.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_HomePosition.Location = new System.Drawing.Point(156, 193);
            this.num_Axis0_Force_HomePosition.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_HomePosition.Name = "num_Axis0_Force_HomePosition";
            this.num_Axis0_Force_HomePosition.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Force_HomePosition.TabIndex = 9;
            // 
            // num_Axis0_Force_HomeAccTime
            // 
            this.num_Axis0_Force_HomeAccTime.DecimalPlaces = 1;
            this.num_Axis0_Force_HomeAccTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_HomeAccTime.Location = new System.Drawing.Point(156, 170);
            this.num_Axis0_Force_HomeAccTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_HomeAccTime.Name = "num_Axis0_Force_HomeAccTime";
            this.num_Axis0_Force_HomeAccTime.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Force_HomeAccTime.TabIndex = 8;
            // 
            // num_Axis0_Force_HomeVelocity
            // 
            this.num_Axis0_Force_HomeVelocity.DecimalPlaces = 1;
            this.num_Axis0_Force_HomeVelocity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_HomeVelocity.Location = new System.Drawing.Point(156, 147);
            this.num_Axis0_Force_HomeVelocity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_HomeVelocity.Name = "num_Axis0_Force_HomeVelocity";
            this.num_Axis0_Force_HomeVelocity.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Force_HomeVelocity.TabIndex = 7;
            // 
            // num_Axis0_Force_ManualAccTime
            // 
            this.num_Axis0_Force_ManualAccTime.DecimalPlaces = 1;
            this.num_Axis0_Force_ManualAccTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_ManualAccTime.Location = new System.Drawing.Point(156, 119);
            this.num_Axis0_Force_ManualAccTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_ManualAccTime.Name = "num_Axis0_Force_ManualAccTime";
            this.num_Axis0_Force_ManualAccTime.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Force_ManualAccTime.TabIndex = 6;
            // 
            // num_Axis0_Force_ManualVelocity
            // 
            this.num_Axis0_Force_ManualVelocity.DecimalPlaces = 1;
            this.num_Axis0_Force_ManualVelocity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_ManualVelocity.Location = new System.Drawing.Point(156, 96);
            this.num_Axis0_Force_ManualVelocity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_ManualVelocity.Name = "num_Axis0_Force_ManualVelocity";
            this.num_Axis0_Force_ManualVelocity.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Force_ManualVelocity.TabIndex = 5;
            // 
            // num_Axis0_Force_MaxJogVelocity
            // 
            this.num_Axis0_Force_MaxJogVelocity.DecimalPlaces = 1;
            this.num_Axis0_Force_MaxJogVelocity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_MaxJogVelocity.Location = new System.Drawing.Point(156, 68);
            this.num_Axis0_Force_MaxJogVelocity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_MaxJogVelocity.Name = "num_Axis0_Force_MaxJogVelocity";
            this.num_Axis0_Force_MaxJogVelocity.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Force_MaxJogVelocity.TabIndex = 4;
            // 
            // num_Axis0_Force_MaxAcc
            // 
            this.num_Axis0_Force_MaxAcc.DecimalPlaces = 1;
            this.num_Axis0_Force_MaxAcc.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_MaxAcc.Location = new System.Drawing.Point(156, 45);
            this.num_Axis0_Force_MaxAcc.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_MaxAcc.Name = "num_Axis0_Force_MaxAcc";
            this.num_Axis0_Force_MaxAcc.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Force_MaxAcc.TabIndex = 3;
            // 
            // num_Axis0_Force_MaxVelocity
            // 
            this.num_Axis0_Force_MaxVelocity.DecimalPlaces = 1;
            this.num_Axis0_Force_MaxVelocity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_MaxVelocity.Location = new System.Drawing.Point(156, 22);
            this.num_Axis0_Force_MaxVelocity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_MaxVelocity.Name = "num_Axis0_Force_MaxVelocity";
            this.num_Axis0_Force_MaxVelocity.Size = new System.Drawing.Size(74, 22);
            this.num_Axis0_Force_MaxVelocity.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(10, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(140, 22);
            this.label23.TabIndex = 1;
            this.label23.Text = "Max. Velocity :";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Axis0_Force_G_Write
            // 
            this.btn_Axis0_Force_G_Write.Location = new System.Drawing.Point(106, 232);
            this.btn_Axis0_Force_G_Write.Name = "btn_Axis0_Force_G_Write";
            this.btn_Axis0_Force_G_Write.Size = new System.Drawing.Size(80, 30);
            this.btn_Axis0_Force_G_Write.TabIndex = 13;
            this.btn_Axis0_Force_G_Write.TabStop = false;
            this.btn_Axis0_Force_G_Write.Text = "G_Write";
            this.btn_Axis0_Force_G_Write.UseVisualStyleBackColor = true;
            this.btn_Axis0_Force_G_Write.Click += new System.EventHandler(this.btn_Force_Write_Click);
            // 
            // btn_Axis0_Force_G_Open
            // 
            this.btn_Axis0_Force_G_Open.Location = new System.Drawing.Point(20, 232);
            this.btn_Axis0_Force_G_Open.Name = "btn_Axis0_Force_G_Open";
            this.btn_Axis0_Force_G_Open.Size = new System.Drawing.Size(80, 30);
            this.btn_Axis0_Force_G_Open.TabIndex = 12;
            this.btn_Axis0_Force_G_Open.TabStop = false;
            this.btn_Axis0_Force_G_Open.Text = "G_Open";
            this.btn_Axis0_Force_G_Open.UseVisualStyleBackColor = true;
            this.btn_Axis0_Force_G_Open.Click += new System.EventHandler(this.btn_Force_Open_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.num_Axis0_Force_Gain_Krff);
            this.groupBox5.Controls.Add(this.num_Axis0_Force_Gain_Kff);
            this.groupBox5.Controls.Add(this.num_Axis0_Force_Gain_Kd);
            this.groupBox5.Controls.Add(this.num_Axis0_Force_Gain_Ki);
            this.groupBox5.Controls.Add(this.num_Axis0_Force_Gain_Kp);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 220);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gain";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(10, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 22);
            this.label18.TabIndex = 10;
            this.label18.Text = "Krff :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(10, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 22);
            this.label17.TabIndex = 9;
            this.label17.Text = "Kff :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(10, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 22);
            this.label16.TabIndex = 8;
            this.label16.Text = "Kd :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(10, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 22);
            this.label15.TabIndex = 7;
            this.label15.Text = "Ki :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num_Axis0_Force_Gain_Krff
            // 
            this.num_Axis0_Force_Gain_Krff.DecimalPlaces = 3;
            this.num_Axis0_Force_Gain_Krff.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_Gain_Krff.Location = new System.Drawing.Point(60, 134);
            this.num_Axis0_Force_Gain_Krff.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_Gain_Krff.Name = "num_Axis0_Force_Gain_Krff";
            this.num_Axis0_Force_Gain_Krff.Size = new System.Drawing.Size(120, 22);
            this.num_Axis0_Force_Gain_Krff.TabIndex = 6;
            // 
            // num_Axis0_Force_Gain_Kff
            // 
            this.num_Axis0_Force_Gain_Kff.DecimalPlaces = 3;
            this.num_Axis0_Force_Gain_Kff.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_Gain_Kff.Location = new System.Drawing.Point(60, 106);
            this.num_Axis0_Force_Gain_Kff.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_Gain_Kff.Name = "num_Axis0_Force_Gain_Kff";
            this.num_Axis0_Force_Gain_Kff.Size = new System.Drawing.Size(120, 22);
            this.num_Axis0_Force_Gain_Kff.TabIndex = 5;
            // 
            // num_Axis0_Force_Gain_Kd
            // 
            this.num_Axis0_Force_Gain_Kd.DecimalPlaces = 3;
            this.num_Axis0_Force_Gain_Kd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_Gain_Kd.Location = new System.Drawing.Point(60, 78);
            this.num_Axis0_Force_Gain_Kd.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_Gain_Kd.Name = "num_Axis0_Force_Gain_Kd";
            this.num_Axis0_Force_Gain_Kd.Size = new System.Drawing.Size(120, 22);
            this.num_Axis0_Force_Gain_Kd.TabIndex = 4;
            // 
            // num_Axis0_Force_Gain_Ki
            // 
            this.num_Axis0_Force_Gain_Ki.DecimalPlaces = 3;
            this.num_Axis0_Force_Gain_Ki.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_Gain_Ki.Location = new System.Drawing.Point(60, 50);
            this.num_Axis0_Force_Gain_Ki.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_Gain_Ki.Name = "num_Axis0_Force_Gain_Ki";
            this.num_Axis0_Force_Gain_Ki.Size = new System.Drawing.Size(120, 22);
            this.num_Axis0_Force_Gain_Ki.TabIndex = 3;
            // 
            // num_Axis0_Force_Gain_Kp
            // 
            this.num_Axis0_Force_Gain_Kp.DecimalPlaces = 3;
            this.num_Axis0_Force_Gain_Kp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Axis0_Force_Gain_Kp.Location = new System.Drawing.Point(60, 22);
            this.num_Axis0_Force_Gain_Kp.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Axis0_Force_Gain_Kp.Name = "num_Axis0_Force_Gain_Kp";
            this.num_Axis0_Force_Gain_Kp.Size = new System.Drawing.Size(120, 22);
            this.num_Axis0_Force_Gain_Kp.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(10, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 22);
            this.label14.TabIndex = 1;
            this.label14.Text = "Kp :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(750, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ct_Preview)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recipe_Copy)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Command_Param)).EndInit();
            this.tabPage12.ResumeLayout(false);
            this.tableLayoutPanel31.ResumeLayout(false);
            this.tableLayoutPanel33.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Main_Pos_Interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Main_Pos_Maximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Main_Pos_Minimum)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Main_Frc_Interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Main_Frc_Maximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Main_Frc_Minimum)).EndInit();
            this.tableLayoutPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ct_Graph)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel32.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PLC_F_Alarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PLC_B_IN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PLC_B_OUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PLC_R_IN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PLC_R_OUT)).EndInit();
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RMC_IN)).EndInit();
            this.tableLayoutPanel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RMC_OUT)).EndInit();
            this.tabControl3.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Axis0_StatusBits)).EndInit();
            this.tableLayoutPanel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Axis0_ErrorBits)).EndInit();
            this.tableLayoutPanel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Axis0_Status)).EndInit();
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel23.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel25.ResumeLayout(false);
            this.tableLayoutPanel27.ResumeLayout(false);
            this.tableLayoutPanel28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Setting_Pos)).EndInit();
            this.tableLayoutPanel26.ResumeLayout(false);
            this.tableLayoutPanel29.ResumeLayout(false);
            this.tableLayoutPanel30.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Setting_Frc)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Move_Decel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Move_Accel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Move_Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Move_Position)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabControl5.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_WarningError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_FatalError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_Offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_InPositionTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_AutoAccTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_AutoVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_HomePosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_HomeAccTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_HomeVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_ManualAccTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_ManualVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_MaxJogVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_MaxAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_MaxVelocity)).EndInit();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_Gain_KffN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_Gain_KffP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_Gain_Kd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_Gain_Ki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Position_Gain_Kp)).EndInit();
            this.tabPage11.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_WarningError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_FatalError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_Offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_InPositionTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_AutoAccTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_AutoVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_HomePosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_HomeAccTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_HomeVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_ManualAccTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_ManualVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_MaxJogVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_MaxAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_MaxVelocity)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_Gain_Krff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_Gain_Kff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_Gain_Kd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_Gain_Ki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Axis0_Force_Gain_Kp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private LibLog.ListViewLog listViewLog1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_Preview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_RecipeOpen;
        private System.Windows.Forms.Button btn_RecipeSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_RecipeName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView_Command;
        private System.Windows.Forms.ImageList imageList_Command;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DataGridView dgv_Recipe_Copy;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel conn_PLC;
        private System.Windows.Forms.ToolStripStatusLabel conn_PLC_time;
        private System.Windows.Forms.DataGridView dgv_Command_Param;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btn_Recipe_Copy_Up;
        private System.Windows.Forms.Button btn_Recipe_Copy_Down;
        private System.Windows.Forms.Button btn_Recipe_Copy_Delete;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.DataGridView dgv_PLC_F_Alarm;
        private System.Windows.Forms.DataGridView dgv_PLC_B_IN;
        private System.Windows.Forms.DataGridView dgv_PLC_B_OUT;
        private System.Windows.Forms.DataGridView dgv_PLC_R_IN;
        private System.Windows.Forms.DataGridView dgv_PLC_R_OUT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.DataGridView dgv_RMC_IN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.DataGridView dgv_RMC_OUT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.DataGridView dgv_Axis0_StatusBits;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.DataGridView dgv_Axis0_ErrorBits;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem parameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel conn_RMC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.Button btn_Connect_RMC;
        private System.Windows.Forms.Button btn_Disconnect_RMC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.Button btn_Connect_PLC;
        private System.Windows.Forms.Button btn_Disconnect_PLC;
        private System.Windows.Forms.Button btn_DownloadToRMC;
        private System.Windows.Forms.Button btn_UploadFromRMC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.DataGridView dgv_Axis0_Status;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripProgressBar pb_RMC;
        private System.Windows.Forms.ToolStripStatusLabel pb_RMC_percent;
        private System.Windows.Forms.ToolStripStatusLabel lbl_DateTime;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel25;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lbl_Axis0_Actual_Pos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel28;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btn_Axis0_Set_Position;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel29;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lbl_Axis0_Actual_Frc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel30;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button btn_Axis0_Set_Force;
        private System.Windows.Forms.NumericUpDown num_Axis0_Setting_Pos;
        private System.Windows.Forms.NumericUpDown num_Axis0_Setting_Frc;
        private System.Windows.Forms.TabControl tabControl5;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_Gain_Krff;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_Gain_Kff;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_Gain_Kd;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_Gain_Ki;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_Gain_Kp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Axis0_Force_G_Write;
        private System.Windows.Forms.Button btn_Axis0_Force_G_Open;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_WarningError;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_FatalError;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_Offset;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_InPositionTolerance;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_AutoAccTime;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_AutoVelocity;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_HomePosition;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_HomeAccTime;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_HomeVelocity;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_ManualAccTime;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_ManualVelocity;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_MaxJogVelocity;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_MaxAcc;
        private System.Windows.Forms.NumericUpDown num_Axis0_Force_MaxVelocity;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btn_Axis0_Position_V_Write;
        private System.Windows.Forms.Button btn_Axis0_Position_V_Open;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_WarningError;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_FatalError;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_Offset;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_InPositionTolerance;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_AutoAccTime;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_AutoVelocity;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_HomePosition;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_HomeAccTime;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_HomeVelocity;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_ManualAccTime;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_ManualVelocity;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_MaxJogVelocity;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_MaxAcc;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_MaxVelocity;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Button btn_Axis0_Position_G_Write;
        private System.Windows.Forms.Button btn_Axis0_Position_G_Open;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_Gain_KffN;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_Gain_KffP;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_Gain_Kd;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_Gain_Ki;
        private System.Windows.Forms.NumericUpDown num_Axis0_Position_Gain_Kp;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Button btn_Axis0_Force_V_Write;
        private System.Windows.Forms.Button btn_Axis0_Force_V_Open;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel31;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel33;
        private System.Windows.Forms.Button btn_CountReset;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_Graph;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chk_Position;
        private System.Windows.Forms.CheckBox chk_Force;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_Axis0_Pos;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label lbl_Axis0_Frc;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label lbl_Min_Pos;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label lbl_Min_Frc;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label lbl_Max_Pos;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label lbl_Max_Frc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel32;
        private System.Windows.Forms.Label lbl_isAuto;
        private System.Windows.Forms.Label lbl_isManual;
        private System.Windows.Forms.Label lbl_isTestStart;
        private System.Windows.Forms.Label lbl_isTestStop;
        private System.Windows.Forms.Label lbl_isEmergency;
        private System.Windows.Forms.Label lbl_isReady;
        private System.Windows.Forms.Label lbl_isTestComplete;
        private System.Windows.Forms.Label lbl_isGraphOn;
        private System.Windows.Forms.Label lbl_isGraphClear;
        private System.Windows.Forms.Label lbl_isTestOK;
        private System.Windows.Forms.Label lbl_isTestNG;
        private System.Windows.Forms.ToolStripMenuItem 모니터2ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Move_Absolute;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.NumericUpDown num_Move_Decel;
        private System.Windows.Forms.NumericUpDown num_Move_Accel;
        private System.Windows.Forms.NumericUpDown num_Move_Speed;
        private System.Windows.Forms.NumericUpDown num_Move_Position;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_isHomePosOK;
        private System.Windows.Forms.Label lbl_isPosPosLimit;
        private System.Windows.Forms.Label lbl_isPosFrcLimit;
        private System.Windows.Forms.Label lbl_isNegPosLimit;
        private System.Windows.Forms.Label lbl_isNegFrcLimit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.NumericUpDown num_Main_Pos_Interval;
        private System.Windows.Forms.NumericUpDown num_Main_Pos_Maximum;
        private System.Windows.Forms.NumericUpDown num_Main_Pos_Minimum;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.NumericUpDown num_Main_Frc_Interval;
        private System.Windows.Forms.NumericUpDown num_Main_Frc_Maximum;
        private System.Windows.Forms.NumericUpDown num_Main_Frc_Minimum;
        private System.Windows.Forms.Label label73;
    }
}


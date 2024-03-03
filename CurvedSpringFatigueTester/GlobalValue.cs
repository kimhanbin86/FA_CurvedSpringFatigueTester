using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurvedSpringFatigueTester
{
    #region enum
    #region Font
    public enum e_Font
    {
        Tahoma
    }
    #endregion

    #region Parameter
    // TODO : e_Parameter
    public enum e_Parameter
    {
        System,
        // ======================================== Parameter
        DB,
        Log,          // e_Parameter_Log
        PLC,          // e_Parameter_PLC
        PLC_B_IN,     // e_Parameter_PLC_Param
        PLC_B_OUT,    // e_Parameter_PLC_Param
        PLC_F_Alarm,  // e_Parameter_PLC_Param
        PLC_R_IN,     // e_Parameter_PLC_Param
        PLC_R_OUT,    // e_Parameter_PLC_Param
        RMC,          // e_Parameter_RMC
        RMC_IN,       // e_Parameter_RMC_Param
        RMC_OUT,      // e_Parameter_RMC_Param
        // ==================================================
        Recipe,
        Recipe_Copy
    }

    public enum e_Parameter_System
    {
        No,
        Name,
        LastFileName
    }
    public enum e_Parameter_Recipe
    {
        No,
        Skip, // Not Use
        Command,
        Param0,
        Param1,
        Param2,
        Param3,
        Param4,
        Param5,
        Param6,
        Param7,
        Param8,
        Param9,
        Param10,
        Param11,
        Param12,
        Param13,
        Param14,
        Param15,
        Param16,
        Param17,
        Param18,
        Param19,
        Param20,
        Param21,
        Param22,
        Param23,
        Param24,
        Param25,
        Param26,
        Param27,
        Param28,
        Param29,
        Param30,
        Param31,
        Param32,
        Param33,
        Param34,
        Param35,
        Param36,
        Param37,
        Param38,
        Param39,
        Param40,
        Param41,
        Param42,
        Param43,
        Param44,
        Param45,
        Param46,
        Param47
    }

    public enum e_Parameter_DB
    {
        No,
        Type,
        Server,
        Port,
        Database,
        Uid,
        Pwd,
        ConnectionTimeout_sec
    }
    public enum e_Parameter_Log
    {
        No,
        ActualPosFrc
    }
    public enum e_Parameter_PLC
    {
        No,
        Type,
        ActLogicalStationNumber,
        IP,
        Port
    }
    public enum e_Parameter_PLC_Param
    {
        No,
        Address,
        Comment
    }
    public enum e_Parameter_RMC
    {
        No,
        DeviceType,
        IP,
        ConnectionTimeout_msec,
        Interval_Status_msec,    // CRMC.threadStatus Sleep
        Interval_Actual_msec,    // CRMC.threadActual Sleep
        Interval_Graph_msec      // FrmMain.threadUpdateGraph Sleep
                                 // FrmFrcByPos.threadUpdateGraph Sleep
    }
    public enum e_Parameter_RMC_Param
    {
        No,
        Bit,
        Tag_Name
    }
    #endregion

    #region DBTable
    public enum e_DBTable
    {
        Alarm,
        Result
    }

    public enum e_DBTable_Alarm
    {
        StartTime,
        EndTime,
        Code,
        Name
    }
    public enum e_DBTable_Result
    {
        Time,
    }
    #endregion

    #region Device
    public enum e_Device
    {
        PLC,
        RMC
    }

    #region PLC
    public enum e_Device_PLC_B_IN
    {
        B0_B_IN_1,
        B1_B_IN_2,
        B2_B_IN_3,
        B3_B_IN_4,
        B4_B_IN_5,
        B5_B_IN_6,
        B6_B_IN_7,
        B7_B_IN_8,
        B8_B_IN_9,
        B9_B_IN_10,
        B0A_B_IN_11,
        B0B_B_IN_12,
        B0C_B_IN_13,
        B0D_B_IN_14,
        B0E_B_IN_15,
        B0F_B_IN_16
    }
    public enum e_Device_PLC_B_OUT
    {
        B100_B_OUT_1,
        B101_B_OUT_2,
        B102_B_OUT_3,
        B103_B_OUT_4,
        B104_B_OUT_5,
        B105_B_OUT_6,
        B106_B_OUT_7,
        B107_B_OUT_8,
        B108_B_OUT_9,
        B109_B_OUT_10,
        B10A_B_OUT_11,
        B10B_B_OUT_12,
        B10C_B_OUT_13,
        B10D_B_OUT_14,
        B10E_B_OUT_15,
        B10F_B_OUT_16
    }
    public enum e_Device_PLC_F_Alarm
    {
        F0_F_Alarm_1,
        F1_F_Alarm_2,
        F2_F_Alarm_3,
        F3_F_Alarm_4,
        F4_F_Alarm_5,
        F5_F_Alarm_6,
        F6_F_Alarm_7,
        F7_F_Alarm_8,
        F8_F_Alarm_9,
        F9_F_Alarm_10,
        F10_F_Alarm_11,
        F11_F_Alarm_12,
        F12_F_Alarm_13,
        F13_F_Alarm_14,
        F14_F_Alarm_15,
        F15_F_Alarm_16
    }
    public enum e_Device_PLC_R_IN
    {
        R1500_R_IN_1,
        R1501_R_IN_2,
        R1502_R_IN_3,
        R1503_R_IN_4,
        R1504_R_IN_5,
        R1505_R_IN_6,
        R1506_R_IN_7,
        R1507_R_IN_8,
        R1508_R_IN_9,
        R1509_R_IN_10,
        R1510_R_IN_11,
        R1511_R_IN_12,
        R1512_R_IN_13,
        R1513_R_IN_14,
        R1514_R_IN_15,
        R1515_R_IN_16
    }
    public enum e_Device_PLC_R_OUT
    {
        R1600_ALIVE,
        R1601_R_OUT_2,
        R1602_R_OUT_3,
        R1603_R_OUT_4,
        R1604_R_OUT_5,
        R1605_R_OUT_6,
        R1606_R_OUT_7,
        R1607_R_OUT_8,
        R1608_R_OUT_9,
        R1609_R_OUT_10,
        R1610_R_OUT_11,
        R1611_R_OUT_12,
        R1612_R_OUT_13,
        R1613_R_OUT_14,
        R1614_R_OUT_15,
        R1615_R_OUT_16
    }
    #endregion
    #endregion

    #region Command, Param
    // TODO : e_Command
    public enum e_Command
    {
        Ramp,
        Test,
        Link
    }

    // TODO : e_Command_Param
    public enum e_Command_Param
    {
        Index,           // Param0 ~ 47
        Offset,          // RMC element offset (F56:53 - 50 = 3)
        _____Name_____,  // Minus(-), Plus(+), Space( ), LSB([), RSB(])
        _____Data_____,
        Unit,            // Per(/)
        DataType         // D: 0.0, ComboBox, N: 0, CheckBox, Title
    }

    public enum e_Command_
    {
        Param0_Offset_Name_Data_Unit_DataType,
        Param1_Offset_Name_Data_Unit_DataType,
        Param2_Offset_Name_Data_Unit_DataType,
        Param3_Offset_Name_Data_Unit_DataType,
        Param4_Offset_Name_Data_Unit_DataType,
        Param5_Offset_Name_Data_Unit_DataType,
        Param6_Offset_Name_Data_Unit_DataType,
        Param7_Offset_Name_Data_Unit_DataType,
        Param8_Offset_Name_Data_Unit_DataType,
        Param9_Offset_Name_Data_Unit_DataType,
        Param10_Offset_Name_Data_Unit_DataType,
        Param11_Offset_Name_Data_Unit_DataType,
        Param12_Offset_Name_Data_Unit_DataType,
        Param13_Offset_Name_Data_Unit_DataType,
        Param14_Offset_Name_Data_Unit_DataType,
        Param15_Offset_Name_Data_Unit_DataType,
        Param16_Offset_Name_Data_Unit_DataType,
        Param17_Offset_Name_Data_Unit_DataType,
        Param18_Offset_Name_Data_Unit_DataType,
        Param19_Offset_Name_Data_Unit_DataType,
        Param20_Offset_Name_Data_Unit_DataType,
        Param21_Offset_Name_Data_Unit_DataType,
        Param22_Offset_Name_Data_Unit_DataType,
        Param23_Offset_Name_Data_Unit_DataType,
        Param24_Offset_Name_Data_Unit_DataType,
        Param25_Offset_Name_Data_Unit_DataType,
        Param26_Offset_Name_Data_Unit_DataType,
        Param27_Offset_Name_Data_Unit_DataType,
        Param28_Offset_Name_Data_Unit_DataType,
        Param29_Offset_Name_Data_Unit_DataType,
        Param30_Offset_Name_Data_Unit_DataType,
        Param31_Offset_Name_Data_Unit_DataType,
        Param32_Offset_Name_Data_Unit_DataType,
        Param33_Offset_Name_Data_Unit_DataType,
        Param34_Offset_Name_Data_Unit_DataType,
        Param35_Offset_Name_Data_Unit_DataType,
        Param36_Offset_Name_Data_Unit_DataType,
        Param37_Offset_Name_Data_Unit_DataType,
        Param38_Offset_Name_Data_Unit_DataType,
        Param39_Offset_Name_Data_Unit_DataType,
        Param40_Offset_Name_Data_Unit_DataType,
        Param41_Offset_Name_Data_Unit_DataType,
        Param42_Offset_Name_Data_Unit_DataType,
        Param43_Offset_Name_Data_Unit_DataType,
        Param44_Offset_Name_Data_Unit_DataType,
        Param45_Offset_Name_Data_Unit_DataType,
        Param46_Offset_Name_Data_Unit_DataType,
        Param47_Offset_Name_Data_Unit_DataType
    }
    // TODO : e_Command_Ramp
    public enum e_Command_Ramp
    {
        Param0_Offset_Name_Data_Unit_DataType,
        Param1_Offset_Name_Data_Unit_DataType,
        Param2_Offset_Name_Data_Unit_DataType,
        Param3_Offset_Name_Data_Unit_DataType,
        Param4_Offset_Name_Data_Unit_DataType,
        Param5_Offset_Name_Data_Unit_DataType,
        Param6_Offset_Name_Data_Unit_DataType,
        Param7_Offset_Name_Data_Unit_DataType,
        Param8_Offset_Name_Data_Unit_DataType,
        Param9_Offset_Name_Data_Unit_DataType,
        Param10_Offset_Name_Data_Unit_DataType,
        Param11_Offset_Name_Data_Unit_DataType,
        Param12_Offset_Name_Data_Unit_DataType,
        Param13_Offset_Name_Data_Unit_DataType,
        Param14_Offset_Name_Data_Unit_DataType,
        Param15_Offset_Name_Data_Unit_DataType,
        Param16_Offset_Name_Data_Unit_DataType,
        Param17_Offset_Name_Data_Unit_DataType,
        Param18_Offset_Name_Data_Unit_DataType,
        Param19_Offset_Name_Data_Unit_DataType,
        Param20_Offset_Name_Data_Unit_DataType,
        Param21_Offset_Name_Data_Unit_DataType,
        Param22_Offset_Name_Data_Unit_DataType,
        Param23_Offset_Name_Data_Unit_DataType,
        Param24_Offset_Name_Data_Unit_DataType,
        Param25_Offset_Name_Data_Unit_DataType,
        Param26_Offset_Name_Data_Unit_DataType,
        Param27_Offset_Name_Data_Unit_DataType,
        Param28_Offset_Name_Data_Unit_DataType,
        Param29_Offset_Name_Data_Unit_DataType,
        Param30_Offset_Name_Data_Unit_DataType,
        Param31_Offset_Name_Data_Unit_DataType,
        Param32_Offset_Name_Data_Unit_DataType,
        Param33_Offset_Name_Data_Unit_DataType,
        Param34_Offset_Name_Data_Unit_DataType,
        Param35_Offset_Name_Data_Unit_DataType,
        Param36_Offset_Name_Data_Unit_DataType,
        Param37_Offset_Name_Data_Unit_DataType,
        Param38_Offset_Name_Data_Unit_DataType,
        Param39_Offset_Name_Data_Unit_DataType,
        Param40_Offset_Name_Data_Unit_DataType,
        Param41_Offset_Name_Data_Unit_DataType,
        Param42_Offset_Name_Data_Unit_DataType,
        Param43_Offset_Name_Data_Unit_DataType,
        Param44_Offset_Name_Data_Unit_DataType,
        Param45_Offset_Name_Data_Unit_DataType,
        Param46_Offset_Name_Data_Unit_DataType,
        Param47_Offset_Name_Data_Unit_DataType
    }

    public enum e_Index_Test
    {
        Type,
        Mode,
        Offset = 3,
        Amplitude,
        Frequency,
        CWTarget = 7,
        CCWTarget,
    }
    // TODO : e_Command_Test
    public enum e_Command_Test
    {
        // TODO : GetType
        Param0_2_Type_Data_Unit_ComboBox_Sine_Square, // ComboBox_Sine_Triangle_Square_Complex
        // TODO : GetMode
        Param1_3_Mode_Data_Unit_ComboBox_Position_Force,
        Param2_5_Count_Data_EA_N,
        Param3_6_Offset_Data_deg_D,
        Param4_7_Amplitude_Data_deg_D,
        Param5_4_Frequency_Data_Hz_D,
        Param6_Offset_LSBTargetRSB_Data_Unit_Title,
        Param7_Offset_CWSpaceTarget_Data_deg_D,
        Param8_Offset_CCWSpaceTarget_Data_deg_D,
        Param9_Offset_LSBUpperSpaceLimitRSB_Data_Unit_Title,
        Param10_13_Position_Data_deg_D,
        Param11_14_Force_Data_Nm_D,
        Param12_Offset_LSBLowerSpaceLimitRSB_Data_Unit_Title,
        // TODO : GetLowerLimitCheck
        Param13_17_LowerSpaceLimitSpaceCheck_Data_Unit_ComboBox_None_Position_Force,
        Param14_15_Position_Data_deg_D,
        Param15_16_Force_Data_Nm_D,
        Param16_Offset_LSBGraphRSB_Data_Unit_Title,
        Param17_19_DataSpaceGather_Data_Unit_CheckBox,
        Param18_Offset_Name_Data_Unit_DataType,
        Param19_Offset_Name_Data_Unit_DataType,
        Param20_Offset_Name_Data_Unit_DataType,
        Param21_Offset_Name_Data_Unit_DataType,
        Param22_Offset_Name_Data_Unit_DataType,
        Param23_Offset_Name_Data_Unit_DataType,
        Param24_Offset_Name_Data_Unit_DataType,
        Param25_Offset_Name_Data_Unit_DataType,
        Param26_Offset_Name_Data_Unit_DataType,
        Param27_Offset_Name_Data_Unit_DataType,
        Param28_Offset_Name_Data_Unit_DataType,
        Param29_Offset_Name_Data_Unit_DataType,
        Param30_Offset_Name_Data_Unit_DataType,
        Param31_Offset_Name_Data_Unit_DataType,
        Param32_Offset_Name_Data_Unit_DataType,
        Param33_Offset_Name_Data_Unit_DataType,
        Param34_Offset_Name_Data_Unit_DataType,
        Param35_Offset_Name_Data_Unit_DataType,
        Param36_Offset_Name_Data_Unit_DataType,
        Param37_Offset_Name_Data_Unit_DataType,
        Param38_Offset_Name_Data_Unit_DataType,
        Param39_Offset_Name_Data_Unit_DataType,
        Param40_Offset_Name_Data_Unit_DataType,
        Param41_Offset_Name_Data_Unit_DataType,
        Param42_Offset_Name_Data_Unit_DataType,
        Param43_Offset_Name_Data_Unit_DataType,
        Param44_Offset_Name_Data_Unit_DataType,
        Param45_Offset_Name_Data_Unit_DataType,
        Param46_Offset_Name_Data_Unit_DataType,
        Param47_Offset_Name_Data_Unit_DataType
    }
    // TODO : e_Command_Link
    public enum e_Command_Link
    {
        Param0_Offset_Name_Data_Unit_DataType,
        Param1_Offset_Name_Data_Unit_DataType,
        Param2_Offset_Name_Data_Unit_DataType,
        Param3_Offset_Name_Data_Unit_DataType,
        Param4_Offset_Name_Data_Unit_DataType,
        Param5_Offset_Name_Data_Unit_DataType,
        Param6_Offset_Name_Data_Unit_DataType,
        Param7_Offset_Name_Data_Unit_DataType,
        Param8_Offset_Name_Data_Unit_DataType,
        Param9_Offset_Name_Data_Unit_DataType,
        Param10_Offset_Name_Data_Unit_DataType,
        Param11_Offset_Name_Data_Unit_DataType,
        Param12_Offset_Name_Data_Unit_DataType,
        Param13_Offset_Name_Data_Unit_DataType,
        Param14_Offset_Name_Data_Unit_DataType,
        Param15_Offset_Name_Data_Unit_DataType,
        Param16_Offset_Name_Data_Unit_DataType,
        Param17_Offset_Name_Data_Unit_DataType,
        Param18_Offset_Name_Data_Unit_DataType,
        Param19_Offset_Name_Data_Unit_DataType,
        Param20_Offset_Name_Data_Unit_DataType,
        Param21_Offset_Name_Data_Unit_DataType,
        Param22_Offset_Name_Data_Unit_DataType,
        Param23_Offset_Name_Data_Unit_DataType,
        Param24_Offset_Name_Data_Unit_DataType,
        Param25_Offset_Name_Data_Unit_DataType,
        Param26_Offset_Name_Data_Unit_DataType,
        Param27_Offset_Name_Data_Unit_DataType,
        Param28_Offset_Name_Data_Unit_DataType,
        Param29_Offset_Name_Data_Unit_DataType,
        Param30_Offset_Name_Data_Unit_DataType,
        Param31_Offset_Name_Data_Unit_DataType,
        Param32_Offset_Name_Data_Unit_DataType,
        Param33_Offset_Name_Data_Unit_DataType,
        Param34_Offset_Name_Data_Unit_DataType,
        Param35_Offset_Name_Data_Unit_DataType,
        Param36_Offset_Name_Data_Unit_DataType,
        Param37_Offset_Name_Data_Unit_DataType,
        Param38_Offset_Name_Data_Unit_DataType,
        Param39_Offset_Name_Data_Unit_DataType,
        Param40_Offset_Name_Data_Unit_DataType,
        Param41_Offset_Name_Data_Unit_DataType,
        Param42_Offset_Name_Data_Unit_DataType,
        Param43_Offset_Name_Data_Unit_DataType,
        Param44_Offset_Name_Data_Unit_DataType,
        Param45_Offset_Name_Data_Unit_DataType,
        Param46_Offset_Name_Data_Unit_DataType,
        Param47_Offset_Name_Data_Unit_DataType
    }
    #endregion

    #region DataGridView
    #region RMC
    public enum e_dgv_col_RMC_Status
    {
        Register,
        __Value__,
        Unit
    }
    public enum e_dgv_row_RMC_Status
    {
        Command_Position,
        Target_Position,
        Actual_Position,
        Command_Velocity,
        Target_Velocity,
        Actual_Velocity,
        Command_Force,
        Target_Force,
        Actual_Force,
        Control_Output
    }

    public enum e_dgv_col_RMC_Bits
    {
        Tag,
        Value
    }
    public enum e_dgv_row_RMC_StatusBits
    {
        InPos,
        AtVel,
        OpenLoop,
        FaultIn,
        Stopped = 6,
        InputEst,
        EnableOut,
        TGDone,
        TGStateA,
        TGStateB,
        DirectOut,
        Enabled,
        ExtHalt,
        Halted,
        TGSIBusy = 24,
        FeedbackOK = 26
    }
    public enum e_dgv_row_RMC_ErrorBits
    {
        FollowErr,
        OutSat = 2,
        FaultIn,
        NoTrans = 6,
        TransOverflow,
        NoiseErr,
        PosOvertravel,
        NegOvertravel,
        CmdErr,
        CmdMod,
        CfgErr,
        RunErr
    }
    #endregion
    #endregion

    #region PCAlarm
    public enum e_PCAlarm
    {
        ERROR_BACKUP_PARAMETER,          // 
        ERROR_LOADING_PARAMETER,         // 
        ERROR_LOADING_PARAMETER_RECIPE,  // 
        ERROR_SAVE_PARAMETER,            // 
        ERROR_START_DEVICE,              // 

        ERROR_COPY_RECIPE,               // 
        ERROR_DOWNLOAD_COMMAND,          // 
        ERROR_UPDATE_RECIPE,             // 
        ERROR_UPLOAD_COMMAND,            // 
        ERROR_PING_TEST,                 // 
    }
    #endregion

    #region Graph
    public enum e_Chart_Series
    {
        ActualPosition,
        ActualForce,
    }
    #endregion
    #endregion

    public static class GlobalValue
    {
        public static Dictionary<string, string[]>[] Parameter = new Dictionary<string, string[]>[Enum.GetNames(typeof(e_Parameter)).Length];

        public static bool[] PCAlarm = new bool[Enum.GetNames(typeof(e_PCAlarm)).Length];

        public static class Directory
        {
            private static string Application = System.Windows.Forms.Application.StartupPath;

            public static string Parameter = Application + "\\CFG\\Parameter";
            public static string Recipe = Application + "\\CFG\\Recipe";

            public static string bakParameter = Application + "\\BAK\\Parameter";
            public static string bakRecipe = Application + "\\BAK\\Recipe";
        }

        public static class Form
        {
            public static FrmAlarm FormAlarm = null;
            public static FrmFrcByPos FormFrcByPos = null;
            public static FrmLogin FormLogin = null;
            public static FrmMain FormMain = null;
            public static FrmParameter FormParameter = null;
        }
    }
}

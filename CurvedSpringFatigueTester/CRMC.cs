using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;

using LibLog;
using RMCLinkNET;

namespace CurvedSpringFatigueTester
{
    /// <TODO>
    /// e_Axis
    /// Registers
    /// </TODO>

    public struct GraphData
    {
        public DateTime dateTime;  // DateTime.Now
        public float actualPos;    // Actual_Position
        public float actualFrc;    // Actual_Force
    }

    #region enum
    public enum e_Axis
    {
        Axis0,
    }

    public enum e_Axis_Status_Registers
    {
        Status_Bits,       // F8+axis no:0   DWORD
        Error_Bits,        // F8+axis no:1   DWORD
        Command_Position,  // F8+axis no:56  REAL
        Target_Position,   // F8+axis no:53  REAL
        Actual_Position,   // F8+axis no:8   REAL
        Command_Velocity,  // F8+axis no:57  REAL
        Target_Velocity,   // F8+axis no:54  REAL
        Actual_Velocity,   // F8+axis no:9   REAL
        Command_Force,     // F8+axis no:61  REAL
        Target_Force,      // F8+axis no:60  REAL
        Actual_Force,      // F8+axis no:23  REAL
        Control_Output,    // F8+axis no:33  REAL
    }

    public enum e_Axis_Actual_Registers
    {
        Actual_Position,   // F8+axis no:8   REAL
        Actual_Force,      // F8+axis no:23  REAL
    }
    #endregion

    public class CRMC
    {
        #region Thread
        private System.Threading.Thread threadStatus = null;
        private bool isThreadStatus = false;
        private void ProcessStatus()
        {
            #region var
            int element = 0;
            float[] REAL = new float[Enum.GetNames(typeof(e_Axis_Status_Registers)).Length];
            int[] DWORD = new int[Enum.GetNames(typeof(e_Axis_Status_Registers)).Length];
            #endregion

            while (isThreadStatus)
            {
                try
                {
                    if (IsConnected)
                    {
                        for (int axis = 0; axis < Enum.GetNames(typeof(e_Axis)).Length; axis++)
                        {
                            for (int register = 0; register < Enum.GetNames(typeof(e_Axis_Status_Registers)).Length; register++)
                            {
                                #region element set
                                switch ((e_Axis_Status_Registers)register)
                                {
                                    case e_Axis_Status_Registers.Status_Bits: element = 0; break;
                                    case e_Axis_Status_Registers.Error_Bits: element = 1; break;
                                    case e_Axis_Status_Registers.Command_Position: element = 56; break;
                                    case e_Axis_Status_Registers.Target_Position: element = 53; break;
                                    case e_Axis_Status_Registers.Actual_Position: element = 8; break;
                                    case e_Axis_Status_Registers.Command_Velocity: element = 57; break;
                                    case e_Axis_Status_Registers.Target_Velocity: element = 54; break;
                                    case e_Axis_Status_Registers.Actual_Velocity: element = 9; break;
                                    case e_Axis_Status_Registers.Command_Force: element = 61; break;
                                    case e_Axis_Status_Registers.Target_Force: element = 60; break;
                                    case e_Axis_Status_Registers.Actual_Force: element = 23; break;
                                    case e_Axis_Status_Registers.Control_Output: element = 33; break;
                                }
                                #endregion

                                #region ReadFile
                                switch ((e_Axis_Status_Registers)register)
                                {
                                    case e_Axis_Status_Registers.Status_Bits:
                                    case e_Axis_Status_Registers.Error_Bits:
                                        rmc.ReadLFile((int)FileNumber70.fn70StatusAxis0 + axis, element, DWORD, register, 1);
                                        break;


                                    case e_Axis_Status_Registers.Command_Position:
                                    case e_Axis_Status_Registers.Target_Position:
                                    case e_Axis_Status_Registers.Actual_Position:
                                    case e_Axis_Status_Registers.Command_Velocity:
                                    case e_Axis_Status_Registers.Target_Velocity:
                                    case e_Axis_Status_Registers.Actual_Velocity:
                                    case e_Axis_Status_Registers.Command_Force:
                                    case e_Axis_Status_Registers.Target_Force:
                                    case e_Axis_Status_Registers.Actual_Force:
                                    case e_Axis_Status_Registers.Control_Output:
                                        rmc.ReadFFile((int)FileNumber70.fn70StatusAxis0 + axis, element, REAL, register, 1);
                                        break;
                                }
                                #endregion

                                Axis_Status[axis, register] = ((e_Axis_Status_Registers)register >= e_Axis_Status_Registers.Command_Position ? REAL[register].ToString() : DWORD[register].ToString());
                            }
                        }
                    }
                    else
                    {
                        Connect();
                    }

                    System.Threading.Thread.Sleep(Convert.ToInt32(GlobalValue.Parameter[(int)e_Parameter.RMC]["1"][(int)e_Parameter_RMC.Interval_Status_msec]));
                }
                catch (Exception ex)
                {
                    Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));

                    Disconnect();
                }

                //System.Threading.Thread.Sleep(Convert.ToInt32(GlobalValue.Parameter[(int)e_Parameter.RMC]["1"][(int)e_Parameter_RMC.Interval_Status_msec]));
            }
        }

        private System.Threading.Thread threadActual = null;
        private bool isThreadActual = false;
        private void ProcessActual()
        {
            #region var
            int element = 8;
            float[] REAL = new float[16]; // 8번(Pos)부터 23번(Frc)까지

            GraphData graphData = new GraphData();
            #endregion

            for (int axis = 0; axis < Enum.GetNames(typeof(e_Axis)).Length; axis++)
            {
                if (GraphDatasByDateTime[axis] == null) { GraphDatasByDateTime[axis] = new Queue<GraphData>(); }
                if (GraphDatas          [axis] == null) { GraphDatas          [axis] = new Queue<GraphData>(); }
            }

            while (isThreadActual)
            {
                try
                {
                    if (IsConnected)
                    {
                        if (GlobalValue.Form.FormMain.TestStart &&
                            GlobalValue.Form.FormMain.isGraphOn
                           )
                        {
                            graphData.dateTime = DateTime.Now;

                            rmc.ReadFFile((int)FileNumber70.fn70StatusAxis0 + (int)e_Axis.Axis0, element, REAL, 0, REAL.Length);

                            graphData.actualPos = REAL[ 0]; //  8-8= 0
                            graphData.actualFrc = REAL[15]; // 23-8=15

                            GraphDatasByDateTime[(int)e_Axis.Axis0].Enqueue(graphData);
                            GraphDatas          [(int)e_Axis.Axis0].Enqueue(graphData);
                        }
                    }

                    System.Threading.Thread.Sleep(Convert.ToInt32(GlobalValue.Parameter[(int)e_Parameter.RMC]["1"][(int)e_Parameter_RMC.Interval_Actual_msec]));
                }
                catch (Exception ex)
                {
                    Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
                }

                //System.Threading.Thread.Sleep(Convert.ToInt32(GlobalValue.Parameter[(int)e_Parameter.RMC]["1"][(int)e_Parameter_RMC.Interval_Actual_msec]));
            }
        }
        #endregion

        #region member
        private RMCLink rmc = null;

        public string[,] Axis_Status = new string[Enum.GetNames(typeof(e_Axis)).Length, Enum.GetNames(typeof(e_Axis_Status_Registers)).Length];
        public Queue<GraphData>[] GraphDatasByDateTime  = new Queue<GraphData>[Enum.GetNames(typeof(e_Axis)).Length]; // 메인화면에서 사용
        public Queue<GraphData>[] GraphDatas            = new Queue<GraphData>[Enum.GetNames(typeof(e_Axis)).Length]; // 모니터#2에서 사용

        public float actualPos;
        public float actualFrc;
        #endregion

        #region property
        public bool IsConnected
        {
            get
            {
                if (rmc != null)
                {
                    return rmc.IsConnected(PingType.DoNotPing);
                }
                return false;
            }
        }
        #endregion

        public CRMC()
        {
            Initialize();
        }

        private void Initialize()
        {
            threadStatus = new System.Threading.Thread(ProcessStatus);
            threadStatus.IsBackground = true;
            isThreadStatus = true;
            threadStatus.Start();

            threadActual = new System.Threading.Thread(ProcessActual);
            threadActual.IsBackground = true;
            threadActual.Priority = System.Threading.ThreadPriority.Highest;
            isThreadActual = true;
            threadActual.Start();
        }
        public void Dispose()
        {
            isThreadStatus = false;
            isThreadActual = false;

            try { threadStatus?.Join(1000); } catch { }
            try { threadActual?.Join(1000); } catch { }
        }

        public bool Connect()
        {
            bool result = false;
            try
            {
                if (IsConnected) return true;

                rmc = RMCLink.CreateEthernetLink((DeviceType)Convert.ToInt32(GlobalValue.Parameter[(int)e_Parameter.RMC]["1"][(int)e_Parameter_RMC.DeviceType]), GlobalValue.Parameter[(int)e_Parameter.RMC]["1"][(int)e_Parameter_RMC.IP]);

                rmc.Connect();

                result = true;
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
            return result;
        }
        public void Disconnect()
        {
            try
            {
                if (rmc != null)
                {
                    rmc.Disconnect();
                    rmc.Dispose();
                    rmc = null;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
        }

        /// <summary>
        /// REAL
        /// </summary>
        public float GetCurValueR(int fileOffset, int element)
        {
            float[] result = new float[1];
            try
            {
                if (IsConnected)
                {
                    rmc.ReadFFile((int)FileNumber70.fn70VarCurValues + fileOffset, element, result, 0, 1);
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
            return result[0];
        }
        /// <summary>
        /// DWORD
        /// </summary>
        public int GetCurValueD(int fileOffset, int element)
        {
            int[] result = new int[1];
            try
            {
                if (IsConnected)
                {
                    rmc.ReadLFile((int)FileNumber70.fn70VarCurValues + fileOffset, element, result, 0, 1);
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
            return result[0];
        }
        public bool SetCurValue(int fileOffset, int element, string value)
        {
            bool result = false;
            try
            {
                if (IsConnected)
                {
                    if (value.Contains("."))
                    {
                        float[] data = new float[1];
                        data[0] = Convert.ToSingle(value);

                        rmc.WriteFFile((int)FileNumber70.fn70VarCurValues + fileOffset, element, data, 0, 1);
                    }
                    else
                    {
                        int[] data = new int[1];
                        data[0] = Convert.ToInt32(value);

                        rmc.WriteLFile((int)FileNumber70.fn70VarCurValues + fileOffset, element, data, 0, 1);
                    }

                    result = true;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
            return result;
        }

        public float GetAxisParameter(e_Axis axis, int element)
        {
            float[] result = new float[1];
            try
            {
                if (IsConnected)
                {
                    rmc.ReadFFile((int)FileNumber70.fn70ParameterAxis0 + (int)axis, element, result, 0, 1);
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
            return result[0];
        }
        public bool SetAxisParameter(e_Axis axis, int element, string value)
        {
            bool result = false;
            try
            {
                if (IsConnected)
                {
                    float[] data = new float[1];
                    data[0] = Convert.ToSingle(value);

                    rmc.WriteFFile((int)FileNumber70.fn70ParameterAxis0 + (int)axis, element, data, 0, 1);

                    result = true;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
            return result;
        }

        public bool SetCommandArea(float[] cmd)
        {
            bool result = false;
            try
            {
                if (IsConnected)
                {
                    rmc.WriteFFile((int)FileNumber70.fn70CommandArea, 0, cmd, 0, 6);

                    result = true;
                }
            }
            catch (Exception ex)
            {
                Log.Write(MethodBase.GetCurrentMethod().Name, GlobalFunction.GetString(ex));
            }
            return result;
        }
    }
}

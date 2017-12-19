using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DTG.ACKProgram
{
    public static class Globals
    {

        #region "Variables"
        //Serial Communications
        public static SerialCommunications g_SerialPort = new SerialCommunications();
        public static List<String> g_ComPortList = new List<String>();
        public static SerialPort g_ComPort = new SerialPort();
        public static System.Drawing.Color g_SerialStatusColor = System.Drawing.Color.Red;
        public static Boolean g_SerialPortOpen = false;

        //UDP Communications
        public static UDPCommunications g_UDPPort = new UDPCommunications();
        public static IPAddress g_IPAddress = null;
        public static int g_PortNumber = 0;
        public static Boolean g_UDPPortOpen = false;
        public static System.Drawing.Color g_UDPStatusColor = System.Drawing.Color.Red;
        public static String g_CurrentMessageIn = "";

        //Other Communications
        public static String g_RecieveData = "";
        public static String g_SendData = "";

        //ACK/NACK
        public static List<AckResponsePair> g_AckResponsePairList = new List<AckResponsePair>();
        public static AckResponseList g_AckResponseList = new AckResponseList();
        #endregion 

        #region "Serial Communications"

        public static void LoadComPorts()
        {
            g_ComPortList = new List<String>();
            String[] tempNames = SerialPort.GetPortNames();

            foreach (String name in tempNames)
            {
                g_ComPortList.Add(name);
            }
        }
        #endregion

        #region "UDP Communications"

        #endregion

        #region "Other Communications"

        #endregion

        #region "ACK/NAK"

        internal static void CheckForAck()
        {
            foreach (AckResponsePair pair in g_AckResponsePairList)
            {
                if (g_RecieveData.Contains(pair.Ack))
                {
                    if (g_SerialPortOpen)
                    {
                        g_ComPort.Write(pair.Response);
                        g_SendData = pair.Response;
                        g_RecieveData = "";
                        return;
                    }

                    else if (g_UDPPortOpen)
                    {
                        //g_SendData = pair.Response;
                        //g_UDPPort.SendData(pair.Response + "\n");
                        if (g_CurrentMessageIn.Contains("AK"))
                            g_SendData = g_CurrentMessageIn.Replace("KA", "AK");
                        else
                            g_SendData = pair.Response + "\n";
                        g_UDPPort.SendData(g_SendData);
                        g_RecieveData = "";
                        return;
                    }
                }
            }

            g_RecieveData = "";
            return;
        }

        public static void ShowList()
        {
            g_AckResponsePairList.Add(new AckResponsePair("192754", "AT024TAI***********192754000000000C"));
            g_AckResponsePairList.Add(new AckResponsePair("192713", "AT024TAI***********192713000000000C"));
            g_AckResponsePairList.Add(new AckResponsePair("192723", "AT024TAI***********192723000000000C"));
            g_AckResponsePairList.Add(new AckResponsePair("192787", "AT024TAI***********192787000000000C"));
            g_AckResponsePairList.Add(new AckResponsePair("192712", "AT024TAI***********192712000000000C"));
            g_AckResponsePairList.Add(new AckResponsePair("192709", "AT024TAI***********192709000000000C"));
            g_AckResponsePairList.Add(new AckResponsePair("192746", "AT024TAI***********192746000000000C"));
            g_AckResponseList.Close();
            g_AckResponseList = new AckResponseList();
            g_AckResponseList.Show();
        }
        #endregion

    }
}

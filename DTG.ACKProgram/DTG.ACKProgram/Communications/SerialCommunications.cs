using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using DTG.ACKProgram.Communications;

namespace DTG.ACKProgram
{
    public class SerialCommunications : ICommunicationsMethod
    {
        private String m_PortName = "COM3";
        private int m_BaudRate = 19200;
        private int m_DataBits = 8;
        private Parity m_Parity = Parity.None;
        private StopBits m_StopBits = StopBits.One;
        private Handshake m_Handshake = Handshake.None;

        public void Connect()
        {
            if (!Globals.g_SerialPortOpen)
            {
                try
                {
                    Globals.g_ComPort.PortName = m_PortName;
                    Globals.g_ComPort.BaudRate = m_BaudRate;
                    Globals.g_ComPort.DataBits = m_DataBits;
                    Globals.g_ComPort.StopBits = m_StopBits;
                    Globals.g_ComPort.Handshake = m_Handshake;
                    Globals.g_ComPort.Parity = m_Parity;
                    Globals.g_ComPort.Open();
                    Globals.g_SerialPortOpen = true;

                    Globals.g_SerialStatusColor = System.Drawing.Color.Green;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public void Close()
        {
            Globals.g_SerialStatusColor = System.Drawing.Color.Red;
            Globals.g_ComPort.Close();
            Globals.g_SerialPortOpen = false;
        }

        public String PortName {
            get
            {
                return m_PortName;
            }
            set
            {
                m_PortName = value;
            }

        }public int BaudRate {
            get
            {
                return m_BaudRate;
            }
            set
            {
                m_BaudRate = value;
            }
        }
    }
}

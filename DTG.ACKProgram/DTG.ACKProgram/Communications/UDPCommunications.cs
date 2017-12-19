using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using DTG.ACKProgram.Communications;
using System.Threading;

namespace DTG.ACKProgram
{
    public class UDPCommunications : ICommunicationsMethod
    {
        private const int LANBUFFERSIZE = 8192;

        private UdpClient m_UDPClient = new UdpClient(0);
        private Thread m_listenerThread = null;
        private IPEndPoint m_Listener = null;
        private IPEndPoint m_Sender = null;

        private IPAddress m_DestinationIPAddress = IPAddress.Parse("010.216.016.055");
        private int m_DestinationPortNumber = 2025;
        private Byte[] m_RecieveData = new Byte[1024];
        private Byte[] m_SendData = new Byte[1024];

        public void Connect()
        { 
            try
            {
                SetUDPVariables();
                m_UDPClient = new UdpClient(m_DestinationPortNumber);
                m_Listener = new IPEndPoint(IPAddress.Broadcast, m_DestinationPortNumber);

                IPAddress[] localIPS = Dns.GetHostAddresses(Dns.GetHostName());
                foreach (IPAddress ip in localIPS)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                        m_DestinationIPAddress = ip;
                }
                m_Sender = new IPEndPoint(m_DestinationIPAddress, m_DestinationPortNumber);

                Globals.g_UDPPortOpen = true;
                Globals.g_UDPStatusColor = System.Drawing.Color.Green;
                m_listenerThread = new Thread(new ThreadStart(ServerThread));
                m_listenerThread.Start();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        public void Close()
        {
            try
            {
                m_listenerThread = null;
                m_UDPClient = new UdpClient();
                Globals.g_UDPPortOpen = false;
                Globals.g_UDPStatusColor = System.Drawing.Color.Red;
    }
            catch (ThreadStateException ex) { Console.WriteLine("Thread Exception: " + ex); }
            catch (Exception ex) { Console.WriteLine("Exception: " + ex); }
            }

        public void ServerThread()
        {
            while (Globals.g_UDPPortOpen)
            {
                m_RecieveData = m_UDPClient.Receive(ref m_Listener);
                Globals.g_CurrentMessageIn = Globals.g_RecieveData += Encoding.ASCII.GetString(m_RecieveData);
            }
            Globals.g_UDPPortOpen = false;
            Globals.g_UDPStatusColor = System.Drawing.Color.Red;
        }

        public void SetUDPVariables()
        {
            m_DestinationIPAddress = Globals.g_IPAddress;
            m_DestinationPortNumber = Globals.g_PortNumber;
        }

        public void SendData(String dataToSend)
        {
            try
            {
                m_SendData = Encoding.ASCII.GetBytes(dataToSend);
                m_UDPClient.Send(m_SendData, m_SendData.Length, m_Listener);
                Globals.g_SendData += " Sent!";
            }
            catch (Exception e)
            {
                Globals.g_SendData = e.Message;
                Globals.g_SendData += " Not Sent!";
            }
        }
    }
}

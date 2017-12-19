using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;

namespace DTG.ACKProgram
{
    public partial class AckResponse : Form
    {
        public AckResponse()
        {
            InitializeComponent();
            LoadComPorts();
        }

        protected void LoadComPorts()
        {
            ComDropDown.Items.Clear();
            Globals.LoadComPorts();
            String[] tempArray = new String[Globals.g_ComPortList.Count()];

            for (int i = Globals.g_ComPortList.Count() - 1; i >= 0; i--)
            {
                tempArray[i] = Globals.g_ComPortList.ElementAt<String>(i);
            }


            foreach (String port in tempArray)
            {
                ComDropDown.Items.Add(port);
            }

            if (!(ComDropDown.Items.Count > 0))
                ComDropDown.Items.Add("No Com Ports");
        }

        private void AddButon_Click(object sender, EventArgs e)
        {
            String ack = AckEntry.Text;
            String response = ResponseEntry.Text;

            Globals.g_AckResponsePairList.Add(new AckResponsePair(ack, response));
        }

        private void PortTimer_Tick(object sender, EventArgs e)
        {
            LoadComPorts();
        }

        private void AckResponseListButton_Click(object sender, EventArgs e)
        {
            Globals.ShowList();
        }

        private void BaudRateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.g_SerialPort.BaudRate = Convert.ToInt32(BaudRateBox.Text);
        }

        private void ComDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.g_SerialPort.PortName = ComDropDown.Text;
        }

        private void RecieveData_Tick(object sender, EventArgs e)
        {
            if (Globals.g_ComPort.IsOpen)
            {
                if (Globals.g_ComPort.ReadBufferSize > 0)
                    Globals.g_RecieveData = Globals.g_ComPort.ReadLine();

                if (Globals.g_RecieveData != "")
                {
                    CommunicationBox.Text += Globals.g_RecieveData;
                    Globals.CheckForAck();
                    CommunicationsBoxOut.Text = Globals.g_SendData;
                }
            }

            if (Globals.g_UDPPortOpen)
            {
                if (Globals.g_RecieveData != "")
                {
                    CommunicationBox.Text += Globals.g_RecieveData;
                    Globals.CheckForAck();
                    CommunicationsBoxOut.Text = Globals.g_SendData;
                }
            }

            if (SerialComStatus.BackColor != Globals.g_SerialStatusColor)
                SerialComStatus.BackColor = Globals.g_SerialStatusColor;

            if (UDPComStatus.BackColor != Globals.g_UDPStatusColor)
                UDPComStatus.BackColor = Globals.g_UDPStatusColor;

        }

        private void SerialButton_Click(object sender, EventArgs e)
        {
            if (!Globals.g_ComPort.IsOpen)
            {
                Globals.g_SerialPort.Connect();

                if (Globals.g_SerialPortOpen)
                {
                    SerialButton.Text = "Disconnect";
                    CommunicationBox.Text = "";
                    CommunicationsBoxOut.Text = "";
                }
            }
            else
            {
                Globals.g_SerialPort.Close();

                if (!Globals.g_SerialPortOpen)
                {
                    SerialButton.Text = "Connect";
                    CommunicationBox.Text = "Communication Closed";
                    CommunicationsBoxOut.Text = "Communication Closed";
                }
            }
        }

        private void UDPButton_Click(object sender, EventArgs e)
        {
            if (!Globals.g_UDPPortOpen)
            {
                Globals.g_IPAddress = IPAddress.Parse(IPAddressBox.Text);
                Globals.g_PortNumber = int.Parse(PortNumberBox.Text);
                Globals.g_UDPPort.Connect();

                if (Globals.g_UDPPortOpen)
                {
                    UDPButton.Text = "Disconnect";
                    CommunicationBox.Text = "";
                    CommunicationsBoxOut.Text = "";
                }
            }
            else
            {
                Globals.g_UDPPort.Close();
                UDPButton.Text = "Connect";
                CommunicationBox.Text = "Communication Closed";
                CommunicationsBoxOut.Text = "Communication Closed";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Boolean convertToASCII = true;
        private Boolean includeTerminals = true;
        private String input = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            convert();
        }

        private void InputBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                InputBox.Text.Trim();
                convert();
            }
        }


        public void convert()
        {
            input = InputBox.Text;
            OutputBox.Text = "";

            if (convertToASCII)
            {
                input.Replace(" ", "");
                changeByteToAscii();
            }
            else
                changeAsciiToByte();
        }

        private void changeByteToAscii()
        {
            while (input != "")
            {
                if (input.Length > 8)
                {
                    OutputBox.Text += byteToAscii(input.Substring(0, 8));
                    input = input.Substring(8);
                }
                else
                {
                    OutputBox.Text += byteToAscii(input);
                    input = "";
                }
            }
        }

        private void changeAsciiToByte()
        {
            for (int i = 0; i < input.Length; i++)
                OutputBox.Text += asciiToByte(input[i]);
        }

        private String byteToAscii(String byteToConvert)
        {
            String asciiString = "";
            int sum = 0;
            double baseValue = 7;

            while (byteToConvert != "")
            {
                if (byteToConvert[0] == '1')
                    sum += (Int32) Math.Pow(2.0,baseValue);

                if (byteToConvert.Length > 1)
                    byteToConvert = byteToConvert.Substring(1);
                else
                    byteToConvert = "";

                baseValue--;
            }

            asciiString = asciiString + ((Char) sum);

            return asciiString;
        }

        private String asciiToByte(Char charToConvert)
        {
            String byteString = "";
            int asciiValue = (Int32)charToConvert;
            int powerValue = 7;

            while (powerValue >= 0)
            {
                int denominator = (Int32) Math.Pow(2.0,powerValue);

                if (asciiValue >= denominator)
                {
                    byteString += "1";
                    asciiValue -= denominator;
                }
                else
                    byteString += "0";

                if (powerValue-- == 4)
                    byteString += " ";
            }

            return byteString + " ";
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            if (convertToASCII)
            {
                convertToASCII = false;
                InputLabel.Text = "ASCII";
                OutputLabel.Text = "Binary";
            }
            else
            {
                convertToASCII = true;
                InputLabel.Text = "Binary";
                OutputLabel.Text = "ASCII";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OutputBox.Text = "";
            InputBox.Text = "";
        }
    }
}

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
        #region "Variables"
            System.Drawing.Color currentColor = System.Drawing.Color.White;
            private int numberOfYellow = 9;
            private int numberOfOrange = 9;
            private int numberOfWhite = 9;
            private int numberOfRed = 9;
            private int numberOfGreen = 9;
            private int numberOfBlue = 9;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region "ColorPicker"
        private void PickYellow_Click(object sender, EventArgs e)
        {
            currentColor = System.Drawing.Color.Yellow;
        }

        private void PickOrange_Click(object sender, EventArgs e)
        {
            currentColor = System.Drawing.Color.Orange;
        }

        private void PickWhite_Click(object sender, EventArgs e)
        {
            currentColor = System.Drawing.Color.White;
        }

        private void PickGreen_Click(object sender, EventArgs e)
        {
            currentColor = System.Drawing.Color.Green;
        }

        private void PickRed_Click(object sender, EventArgs e)
        {
            currentColor = System.Drawing.Color.Red;
        }

        private void PickBlue_Click(object sender, EventArgs e)
        {
            currentColor = System.Drawing.Color.Blue;
        }
        #endregion

        #region "Cube"
            #region "YellowCenter"

            private void Yellow1_Click(object sender, EventArgs e)
            {
                changeColorValues(Yellow1.BackColor, currentColor);
                Yellow1.BackColor = currentColor;
            }

            private void Yellow2_Click(object sender, EventArgs e)
            {
                changeColorValues(Yellow2.BackColor, currentColor);
                Yellow2.BackColor = currentColor;
            }

            private void Yellow3_Click(object sender, EventArgs e)
            {
                changeColorValues(Yellow3.BackColor, currentColor);
                Yellow3.BackColor = currentColor;
            }

            private void Yellow4_Click(object sender, EventArgs e)
            {
                changeColorValues(Yellow4.BackColor, currentColor);
                Yellow4.BackColor = currentColor;
            }

            private void Yellow6_Click(object sender, EventArgs e)
            {
                changeColorValues(Yellow6.BackColor, currentColor);
                Yellow6.BackColor = currentColor;
            }

            private void Yellow7_Click(object sender, EventArgs e)
            {
                changeColorValues(Yellow7.BackColor, currentColor);
                Yellow7.BackColor = currentColor;
            }

            private void Yellow8_Click(object sender, EventArgs e)
            {
                changeColorValues(Yellow8.BackColor, currentColor);
                Yellow8.BackColor = currentColor;
            }

            private void Yellow9_Click(object sender, EventArgs e)
            {
                changeColorValues(Yellow9.BackColor, currentColor);
                Yellow9.BackColor = currentColor;
            }
            #endregion

            #region "OrangeCenter"
            private void Orange1_Click(object sender, EventArgs e)
            {
                changeColorValues(Orange1.BackColor, currentColor);
                Orange1.BackColor = currentColor;
            }

            private void Orange2_Click(object sender, EventArgs e)
            {
                changeColorValues(Orange2.BackColor, currentColor);
                Orange2.BackColor = currentColor;
            }

            private void Orange3_Click(object sender, EventArgs e)
            {
                changeColorValues(Orange3.BackColor, currentColor);
                Orange3.BackColor = currentColor;
            }

            private void Orange4_Click(object sender, EventArgs e)
            {
                changeColorValues(Orange4.BackColor, currentColor);
                Orange4.BackColor = currentColor;
            }

            private void Orange6_Click(object sender, EventArgs e)
            {
                changeColorValues(Orange6.BackColor, currentColor);
                Orange6.BackColor = currentColor;
            }

            private void Orange7_Click(object sender, EventArgs e)
            {
                changeColorValues(Orange7.BackColor, currentColor);
                Orange7.BackColor = currentColor;
            }

            private void Orange8_Click(object sender, EventArgs e)
            {
                changeColorValues(Orange8.BackColor, currentColor);
                Orange8.BackColor = currentColor;
            }

            private void Orange9_Click(object sender, EventArgs e)
            {
                changeColorValues(Orange9.BackColor, currentColor);
                Orange9.BackColor = currentColor;
            }

            #endregion

            #region "WhiteCenter"
            private void White1_Click(object sender, EventArgs e)
            {
                changeColorValues(White1.BackColor, currentColor);
                White1.BackColor = currentColor;
            }

            private void White2_Click(object sender, EventArgs e)
            {
                changeColorValues(White2.BackColor, currentColor);
                White2.BackColor = currentColor;
            }

            private void White3_Click(object sender, EventArgs e)
            {
                changeColorValues(White3.BackColor, currentColor);
                White3.BackColor = currentColor;
            }

            private void White4_Click(object sender, EventArgs e)
            {
                changeColorValues(White4.BackColor, currentColor);
                White4.BackColor = currentColor;
            }

            private void White6_Click(object sender, EventArgs e)
            {
                changeColorValues(White6.BackColor, currentColor);
                White6.BackColor = currentColor;
            }

            private void White7_Click(object sender, EventArgs e)
            {
                changeColorValues(White7.BackColor, currentColor);
                White7.BackColor = currentColor;
            }

            private void White8_Click(object sender, EventArgs e)
            {
                changeColorValues(White8.BackColor, currentColor);
                White8.BackColor = currentColor;
            }

            private void White9_Click(object sender, EventArgs e)
            {
                changeColorValues(White9.BackColor, currentColor);
                White9.BackColor = currentColor;
            }
            #endregion

            #region "RedCenter"
            private void Red1_Click(object sender, EventArgs e)
            {
                changeColorValues(Red1.BackColor, currentColor);
                Red1.BackColor = currentColor;
            }

            private void Red2_Click(object sender, EventArgs e)
            {
                changeColorValues(Red2.BackColor, currentColor);
                Red2.BackColor = currentColor;
            }

            private void Red3_Click(object sender, EventArgs e)
            {
                changeColorValues(Red3.BackColor, currentColor);
                Red3.BackColor = currentColor;
            }

            private void Red4_Click(object sender, EventArgs e)
            {
                changeColorValues(Red4.BackColor, currentColor);
                Red4.BackColor = currentColor;
            }

            private void Red6_Click(object sender, EventArgs e)
            {
                changeColorValues(Red6.BackColor, currentColor);
                Red6.BackColor = currentColor;
            }

            private void Red7_Click(object sender, EventArgs e)
            {
                changeColorValues(Red7.BackColor, currentColor);
                Red7.BackColor = currentColor;
            }

            private void Red8_Click(object sender, EventArgs e)
            {
                changeColorValues(Red8.BackColor, currentColor);
                Red8.BackColor = currentColor;
            }

            private void Red9_Click(object sender, EventArgs e)
            {
                changeColorValues(Red9.BackColor, currentColor);
                Red9.BackColor = currentColor;
            }

            #endregion

            #region "GreenCenter"
            private void Green1_Click(object sender, EventArgs e)
            {
                changeColorValues(Green1.BackColor, currentColor);
                Green1.BackColor = currentColor;
            }

            private void Green2_Click(object sender, EventArgs e)
            {
                changeColorValues(Green2.BackColor, currentColor);
                Green2.BackColor = currentColor;
            }

            private void Green3_Click(object sender, EventArgs e)
            {
                changeColorValues(Green3.BackColor, currentColor);
                Green3.BackColor = currentColor;
            }

            private void Green4_Click(object sender, EventArgs e)
            {
                changeColorValues(Green4.BackColor, currentColor);
                Green4.BackColor = currentColor;
            }

            private void Green6_Click(object sender, EventArgs e)
            {
                changeColorValues(Green6.BackColor, currentColor);
                Green6.BackColor = currentColor;
            }

            private void Green7_Click(object sender, EventArgs e)
            {
                changeColorValues(Green7.BackColor, currentColor);
                Green7.BackColor = currentColor;
            }

            private void Green8_Click(object sender, EventArgs e)
            {
                changeColorValues(Green8.BackColor, currentColor);
                Green8.BackColor = currentColor;
            }

            private void Green9_Click(object sender, EventArgs e)
            {
                changeColorValues(Green9.BackColor, currentColor);
                Green9.BackColor = currentColor;
            }
            #endregion

            #region "BlueCenter"
            private void Blue1_Click(object sender, EventArgs e)
            {
                changeColorValues(Blue1.BackColor, currentColor);
                Blue1.BackColor = currentColor;
            }

            private void Blue2_Click(object sender, EventArgs e)
            {
                changeColorValues(Blue2.BackColor, currentColor);
                Blue2.BackColor = currentColor;
            }

            private void Blue3_Click(object sender, EventArgs e)
            {
                changeColorValues(Blue3.BackColor, currentColor);
                Blue3.BackColor = currentColor;
            }

            private void Blue4_Click(object sender, EventArgs e)
            {
                changeColorValues(Blue4.BackColor, currentColor);
                Blue4.BackColor = currentColor;
            }

            private void Blue6_Click(object sender, EventArgs e)
            {
                changeColorValues(Blue6.BackColor, currentColor);
                Blue6.BackColor = currentColor;
            }

            private void Blue7_Click(object sender, EventArgs e)
            {
                changeColorValues(Blue7.BackColor, currentColor);
                Blue7.BackColor = currentColor;
            }

            private void Blue8_Click(object sender, EventArgs e)
            {
                changeColorValues(Blue8.BackColor, currentColor);
                Blue8.BackColor = currentColor;
            }

            private void Blue9_Click(object sender, EventArgs e)
            {
                changeColorValues(Blue9.BackColor, currentColor);
                Blue9.BackColor = currentColor;
            }
            #endregion

        #endregion

        #region "Color Number Updates"
        public void changeColorValues(System.Drawing.Color oldColor, System.Drawing.Color newColor)
        {
            switch (oldColor.Name)
            {
                case "Yellow":
                    numberOfYellow--;
                    break;

                case "Orange":
                    numberOfOrange--;
                    break;

                case "White":
                    numberOfWhite--;
                    break;

                case "Red":
                    numberOfRed--;
                    break;

                case "Green":
                    numberOfGreen--;
                    break;

                case "Blue":
                    numberOfBlue--;
                    break;
            }

            switch (newColor.Name)
            {
                case "Yellow":
                    numberOfYellow++;
                    break;

                case "Orange":
                    numberOfOrange++;
                    break;

                case "White":
                    numberOfWhite++;
                    break;

                case "Red":
                    numberOfRed++;
                    break;

                case "Green":
                    numberOfGreen++;
                    break;

                case "Blue":
                    numberOfBlue++;
                    break;
            }
        }

        public void updateCounts()
        {
            yellowCount.Text = numberOfYellow + "";
            orangeCount.Text = numberOfOrange + "";
            whiteCount.Text = numberOfWhite + "";
            redCount.Text = numberOfRed + "";
            greenCount.Text = numberOfGreen + "";
            blueCount.Text = numberOfBlue + "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateCounts();
        }
            #endregion

        #region "Moves"
        public void R()
        {
            System.Drawing.Color whiteStart3 = White3.BackColor;
            System.Drawing.Color whiteStart6 = White6.BackColor;
            System.Drawing.Color whiteStart9 = White9.BackColor;

            White3.BackColor = Red3.BackColor;
            White6.BackColor = Red6.BackColor;
            White9.BackColor = Red9.BackColor;

            Red3.BackColor = Yellow3.BackColor;
            Red6.BackColor = Yellow6.BackColor;
            Red9.BackColor = Yellow9.BackColor;

            Yellow3.BackColor = Orange3.BackColor;
            Yellow6.BackColor = Orange6.BackColor;
            Yellow9.BackColor = Orange9.BackColor;

            Orange3.BackColor = whiteStart3;
            Orange6.BackColor = whiteStart6;
            Orange9.BackColor = whiteStart9;
        }

        public void Ri()
        {
            System.Drawing.Color whiteStart3 = White3.BackColor;
            System.Drawing.Color whiteStart6 = White6.BackColor;
            System.Drawing.Color whiteStart9 = White9.BackColor;

            White3.BackColor = Orange3.BackColor;
            White6.BackColor = Orange6.BackColor;
            White9.BackColor = Orange9.BackColor;

            Orange3.BackColor = Yellow3.BackColor;
            Orange6.BackColor = Yellow6.BackColor;
            Orange9.BackColor = Yellow9.BackColor;

            Yellow3.BackColor = Red3.BackColor;
            Yellow6.BackColor = Red6.BackColor;
            Yellow9.BackColor = Red9.BackColor;

            Red3.BackColor = whiteStart3;
            Red6.BackColor = whiteStart6;
            Red9.BackColor = whiteStart9;
        }
        #endregion

        #region "Start Button"
        private void button1_Click(object sender, EventArgs e)
        {
            Ri();
        }
        #endregion
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyMain());

            Boolean inTile = false;
            Form[][] grid = new Form[7][];

            for (int i = 0; i < grid.Length; i++)
            {
                grid[i] = new Form[7];
                for (int j = 0; j < grid[i].Length; j++)
                {
                    String tileID = ((char) (97 + i)).ToString() + j;
                    
                }
            }

            while (true)
            {
                if (inTile)
                {
                    //leaveTile(System.Windows.Forms.Panel.);
                }
            }
        }

        public static void enterTile(Form targetTile)
        {
            targetTile.BackColor = System.Drawing.Color.Green;
        }

        public static void leaveTile(Form targetTile)
        {
            targetTile.BackColor = System.Drawing.Color.LightGray;
        }
    }
}

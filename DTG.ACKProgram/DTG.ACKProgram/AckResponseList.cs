using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTG.ACKProgram
{
    public partial class AckResponseList : Form
    {
        public AckResponseList()
        {
            InitializeComponent();
            FillTable();
        }

        public void FillTable()
        {
            foreach (AckResponsePair pair in Globals.g_AckResponsePairList)
            {
                AckResponseTable.Rows.Add(pair.Ack, pair.Response);
            }
        }
    }
}

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Logger
{
    public partial class LoggerInterface : Form
    {
        #region Variables and Constructor
        private Boolean m_TextUsed = false;

        private String m_path = "C:\\Desktop\\" + "\\Logs\\" 
            + System.DateTime.Today.Month.ToString() + "-" 
            + System.DateTime.Today.Day.ToString() + ".txt";

        private StreamWriter m_Writer = null;
        private StreamReader m_Reader = null;

        public LoggerInterface()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (m_TextUsed == false)
                m_TextUsed = true;
        }

        private void FileBox_TextChanged(object sender, EventArgs e)
        {
            if (m_TextUsed == true)
                m_TextUsed = false;
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            Log();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)13)
                Log();
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)13)
                this.TextBox.Text = "";
        }

        private void TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            this.TextBox.SelectAll();
        }

        private void FileBox_MouseClick(object sender, MouseEventArgs e)
        {
            this.FileBox.SelectAll();
        }

        private void FileBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)13)
                Log();
        }

        private void FileBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)13)
                this.FileBox.Text = "";
        }
        #endregion

        #region methods
        private void Log()
        {
            if (m_Writer == null)
                m_Writer = File.AppendText(m_path);

            if (m_TextUsed == true)
            {
                LogText();
                this.TextBox.Text = "";
            }
            else
                LogFile();
        }

        private void LogText()
        {
            String tempText = DateTime.Now.Hour.ToString() + ":"
                            + DateTime.Now.Minute.ToString() + ":"
                            + DateTime.Now.Second.ToString();

            tempText = tempText + ": " + this.TextBox.Text;
            m_Writer.WriteLine(tempText);

            m_Writer.Close();
            m_Writer = null;
        }

        private void LogFile()
        {
            try
            {
                String line = "";
                String readPath = this.FileBox.Text;
                m_Reader = new StreamReader(readPath);

                m_Writer.WriteLine(readPath + " transfered over at "
                            + DateTime.Now.Hour.ToString() + ":"
                            + DateTime.Now.Minute.ToString() + ":"
                            + DateTime.Now.Second.ToString());

                while ((line = m_Reader.ReadLine()) != null)
                {
                    m_Writer.WriteLine(line);
                }

                m_Writer.WriteLine("End of " + readPath);

            }
            catch (Exception e)
            {
                m_Writer.WriteLine("Error reading file!");
                m_Writer.WriteLine(e.Message);
            }
            finally
            {
                m_Reader.Close();
                m_Writer.Close();
                m_Reader = null;
                m_Writer = null;
            }
        }

        #endregion
    }
}

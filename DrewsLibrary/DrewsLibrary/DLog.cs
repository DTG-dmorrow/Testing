using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DrewsLibrary
{
    class DLog
    {
        private String m_Path = "C:\\Desktop\\Logs\\";
        private String m_FileName = "Drew_Logs";
        private String m_FullFilePath = "";

        private StreamWriter m_Writer = null;
        private StreamReader m_Reader = null;

        #region "Constructors"
        public DLog()
        {
            m_FullFilePath = m_Path + m_FileName;

            if (!Directory.Exists(m_Path))
                Directory.CreateDirectory(m_Path);

            if (!File.Exists(m_FullFilePath))
                File.CreateText(m_FullFilePath);
        }
        #endregion

        #region "Methods"
        public void Log(String stringToLog)
        {
            String tempText = DateTime.Now.Hour.ToString() + ":"
                            + DateTime.Now.Minute.ToString() + ":"
                            + DateTime.Now.Second.ToString();

            if (m_Writer == null)
                m_Writer = File.AppendText(m_FullFilePath);

            tempText = tempText + ": " + stringToLog;
            m_Writer.WriteLine(tempText);

            m_Writer.Close();
            m_Writer = null;
        }
        #endregion

        #region "Properties"
        public String GetPath()
        {
            return m_Path;
        }

        public String GetFileName()
        {
            return m_FileName;
        }

        public void SetPath(String value)
        {
            m_Path = value;
            m_FullFilePath = value + m_FileName;
        }

        public void SetFileName(String value)
        {
            m_FileName = value;
            m_FullFilePath = m_Path + value;
        }

        #endregion
    }
}

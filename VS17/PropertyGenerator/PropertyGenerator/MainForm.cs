using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            string[] lines = null;
            string[] words = null;
            string variableName = "";
            string variableType = "";
            Boolean inClass = false;
            OutputBox.Text = "";

            lines = VariablesBox.Text.Split((char)13);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].ToLower().Contains("class"))
                {
                    if (lines[i].ToLower().Contains("end"))
                    {
                        if (inClass)
                        {
                            OutputBox.Text += "}\r\n\r\n";
                            inClass = false;
                        }
                    }
                    else
                    {
                        words = lines[i].Split(' ');

                        for (int j = 0; j < words.Length; j++)
                        {
                            if (words[j].ToLower() == "class")
                            {
                                if (inClass)
                                    OutputBox.Text += "}\r\n\r\n";

                                OutputBox.Text += "public Class " + words[j + 1] + "\r\n{\r\n";
                                inClass = true;
                            }
                        }
                    }
                }

                if (lines[i].ToLower().Contains("dim"))
                {
                    words = lines[i].Trim().Split(' ');
                    if (words.Length > 3)
                    {
                        variableName = words[1];
                        if (words[3].ToLower() == "new")
                            variableType = ConvertType(words[4]);
                        else
                            variableType = ConvertType(words[3]);
                    }

                    if (variableName.ToLower().Contains("m_") || variableName.ToLower().Contains("g_"))
                        variableName = variableName.Substring(1);

                    if (variableName.Length > 2)
                        variableName = variableName.Substring(0, 2).ToLower() + variableName.Substring(2);

                    OutputBox.Text += "public " + variableType + " " + variableName.Substring(1, 1).ToUpper() + variableName.Substring(2) + "\r\n";
                    OutputBox.Text += "{" + "\r\n";
                    OutputBox.Text += "{ get " + variableName + "}\r\n";
                    OutputBox.Text += "{ set ref " + variableName + "}\r\n";
                    OutputBox.Text += "}\r\n";
                    OutputBox.Text += "private " + variableType + " " + variableName + ";\r\n\r\n";
                }
            }

            if (inClass)
            {
                OutputBox.Text += "}\r\n\r\n";
                inClass = false;
            }
        }

        public string ConvertType(string type)
        {
            switch (type)
            {
                case "Decimal":
                    return "decimal";
                case "Date":
                    return "DateTime";

                case "String":
                    return "string";

                case "Byte":
                    return "byte";

                case "Boolean":
                    return "bool";

                case "Short":
                    return "short";

                case "Char":
                    return "char";

                case "Integer":
                    return "int";

                case "Long":
                    return "long";

                case "Single":
                    return "float";

                case "Double":
                    return "double";

                default:
                    return type;
            }
        }
    }
}

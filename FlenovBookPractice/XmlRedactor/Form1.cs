using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace XmlRedactor
{
    public partial class Form1 : Form
    {
        string fileName = "D:\\test748.xml";

        public Form1()
        {
            InitializeComponent();
            SaveProject();
        }

        void SaveProject()
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            XmlTextWriter xmlWriter = new XmlTextWriter(fs, Encoding.Unicode);
            xmlWriter.Formatting = Formatting.Indented;

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteComment("Это пример работы с XML.");
            xmlWriter.WriteComment("Author: SilentHill");

            xmlWriter.WriteStartElement("RosePlant");
            xmlWriter.WriteAttributeString("Version", "1");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
            fs.Close();
        }
    }
}

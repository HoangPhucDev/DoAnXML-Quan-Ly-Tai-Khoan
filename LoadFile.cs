using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DXDoAnXML
{
    public class LoadFile
    {
        public static string FILENAME = Application.StartupPath + "\\accounts.xml";
        public XElement xmlLoadFile { set; get; }
        public LoadFile()
        {
            try { xmlLoadFile = XElement.Load(@FILENAME);  }
            catch{}
            
        }
        public LoadFile(string path)
        {
            xmlLoadFile = XElement.Load(path);
        }
    }
}

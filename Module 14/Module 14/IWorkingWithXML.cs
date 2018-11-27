using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module_14
{
    interface IWorkingWithXML
    {
        void WriteTOXml(string path);
        XElement ReadFromXml(string path);    

    }
}

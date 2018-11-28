using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Module_15
{
    [Serializable]
    public class Catalog
    {
        [XmlAttribute("date")]
        public DateTime Date { get; set; }
        public List<Book> Books { get; set; } 

       
    }
}

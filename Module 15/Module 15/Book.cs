using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Module_15
{
    public enum Genre
    {
        Fantasy,
        Computer,
        ScienceFiction,
        Romance
    }

    [Serializable]
    public class Book
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("genre")]
        public Genre Genre { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("publishDate")]
        public DateTime PublishDate { get; set; }

        [XmlElement("registrationDate")]
        public DateTime RegistrationDate { get; set; }

            

    }
}

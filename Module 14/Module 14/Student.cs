using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module_14
{
    class Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Faculty { get; set; }
        public string Group { get; set; }
        public string Course { get; set; }
        //public DateTime StartRead { get; set; }
        //public DateTime EndRead { get; set; }       


        public void WriteTOXml(string path)
        {
            XDocument xdoc = XDocument.Load(path);

            XElement newStudent = new XElement("students");

            XElement nameEl = new XElement("name", Name);
            XElement addressEl = new XElement("address", Address);
            XElement faculty = new XElement("faculty", Faculty);
         
            XAttribute groupAt = new XAttribute("group", Group);
            XAttribute courseAt = new XAttribute("course", Course);

            faculty.Add(groupAt);
            faculty.Add(courseAt);

            newStudent.Add(nameEl);
            newStudent.Add(addressEl);
            newStudent.Add(faculty);
           
            XElement students = xdoc.Element("students");

            if (students == null)
            {
                students = new XElement("students");
                xdoc.Add(students);

            }

            students.Add(newStudent);


            xdoc.Save(path);
        }

    }
}

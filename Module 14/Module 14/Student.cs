using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module_14
{
    class Student : IWorkingWithXML
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Faculty { get; set; }
        public string Group { get; set; }
        public string Course { get; set; }
       

        /// <summary>
        ///Write in XMl
        /// </summary>
        /// <param name="path">path for file</param>
        public void WriteTOXml(string path)
        {
            XDocument xdoc;
            try
            {
                xdoc = XDocument.Load(path);
            }
            catch (FileNotFoundException e)
            {
                xdoc = new XDocument();
                XElement xElement = new XElement("students", "");
                xdoc.Add(xElement);
            }

            XElement newStudent = new XElement("student");

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

        /// <summary>
        /// Read form XML file
        /// </summary>
        /// <param name="path">path</param>
        /// <returns>XElements</returns>
        public XElement ReadFromXml(string path)
        {
            XDocument xdoc = XDocument.Load(path);
            XElement root = xdoc.Element("students");
            return root;
        }

        /// <summary>
        /// Convert XML book to class student list
        /// </summary>
        /// <param name="xel">element</param>
        /// <returns>List student</returns>
        public static List<Student> ConvertXelementToListStudent(XElement xel)
        {
            List<Student> listBook = new List<Student>();
            foreach (XElement item in xel.Elements("student"))
            {
                Student tmp = new Student();
                tmp.Address = item.Element("address").Value;
                tmp.Name = item.Element("name").Value;
                tmp.Faculty = item.Element("faculty").Value;               
                tmp.Group = item.Element("faculty").Attribute("group").Value;
                tmp.Course = item.Element("faculty").Attribute("course").Value;

                listBook.Add(tmp);
            }


            return listBook;
        }


    }
}

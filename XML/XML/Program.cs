using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument XML = new XmlDocument();
            XML.Load("File1.xml");

            XmlElement root = XML.DocumentElement;
            XDocument xDoc = XDocument.Load("File1.xml");

            //foreach (XmlNode item in root)
            //{
            //    Console.WriteLine(item.InnerXml);
            //}

            // get Attributes with values
            //if (root.HasChildNodes){
            //    var tmp = root.ChildNodes;
            //    foreach (XmlNode item in tmp)
            //    {
            //        if (item.Attributes.Count > 0)
            //        {
            //            foreach (XmlAttribute xxx in item.Attributes)
            //            {
            //                Console.WriteLine(xxx.Name + ": "+ xxx.Value);
            //            }
            //        }
            //    }
            //}

            //Get elements
            //foreach (XmlNode item in root.ChildNodes)
            //{
            //    if (item.HasChildNodes)
            //    {                    
            //        foreach (XmlElement x in item)
            //        {
            //            Console.WriteLine(x.Name + ": " + x.InnerText);
            //        }
            //    }

            //}


            //add element 
            //XmlElement userElem = XML.CreateElement("user");

            //XmlAttribute nameAttr = XML.CreateAttribute("name");

            //XmlElement companyElem = XML.CreateElement("company");
            //XmlElement ageElem = XML.CreateElement("age");

            //XmlText nameText = XML.CreateTextNode("Sergey Davydov");
            //XmlText companyText = XML.CreateTextNode("EPAM");
            //XmlText ageText = XML.CreateTextNode("28");




            ////добавляем узлы
            //nameAttr.AppendChild(nameText);
            //companyElem.AppendChild(companyText);
            //ageElem.AppendChild(ageText);
            //userElem.Attributes.Append(nameAttr);
            //userElem.AppendChild(companyElem);
            //userElem.AppendChild(ageElem);
            //root.AppendChild(userElem);
            //XML.Save("File1.xml");




            ////Add element with using LINQ
            //XElement user = new XElement("user");

            //XAttribute atr = new XAttribute("name", "Segrey Davydov2");
            //XElement agge = new XElement("age", "28");
            //XElement cpmpany = new XElement("company", "EPAm");

            //user.Add(atr);
            //user.Add(agge);
            //user.Add(cpmpany);

            //XElement xroot = xDoc.Element("users");
            //xroot.Add(user);

            //xDoc.Save("File1.xml");

            // All elements
            //foreach (XElement item in xDoc.Element("users").Elements("user"))
            //{
            //    XAttribute at = item.Attribute("name");
            //    XElement el = item.Element("company");
            //    XElement age = item.Element("age");

            //    Console.WriteLine(at.Value + " " + el.Value + " " + age.Value);
            //}


            ////Edit information
            //XElement xEl = xDoc.Element("users");
            //foreach(XElement xE in xEl.Elements("user"))
            //{
            //    if(xE.Attribute("name").Value == "Segrey Davydov2")
            //    {
            //        xE.Attribute("name").Value = "Kirill Boreiko";
            //        xE.Element("company").Value = "EPAM";
            //        xE.Element("age").Value = "21";
            //    }
            //}

            //xDoc.Save("File1.xml");



            //Console.Read();

            }
        }
    }

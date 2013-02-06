using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace ROTCHAK_Luft
{
    class databaseop
    {
        public static void CreateXMLDocument(string filepath)
        {
            XmlTextWriter xtw = new XmlTextWriter(filepath, Encoding.UTF8);
            xtw.WriteStartDocument();
            xtw.WriteStartElement("izmerenie");
            xtw.WriteEndDocument();
            xtw.Close();
        }  
        public static void WriteData (string filepath, string vin, string leftangle,string number)
        {
            XmlDocument basedoc = new XmlDocument();
            if (!File.Exists(filepath))
            {
                CreateXMLDocument(filepath);
            }
            basedoc.Load(filepath);
            XmlElement wr = basedoc.CreateElement("izmerenie");
            wr.SetAttribute("номер", number);
            wr.SetAttribute("вин", vin);
            wr.SetAttribute("расхождение_угла", leftangle);
            basedoc.DocumentElement.AppendChild(wr);
            basedoc.Save(filepath);
            //XmlWriter writer = null;
            //if (!File.Exists(filepath))
            //        {
            //            CreateXMLDocument(filepath);
            //        }
            //writer = new XmlTextWriter(filepath, Encoding.UTF8);
            //writer.WriteStartDocument();
            //writer.WriteStartElement("izmereniya");
            //writer.WriteStartElement("izmerenie");
            //writer.WriteAttributeString("id", number);
            //writer.WriteAttributeString("vin", vin);
            //writer.WriteAttributeString("leftangle", leftangle);
            //writer.WriteEndElement();
            //writer.WriteEndElement();
            //writer.WriteEndDocument();

        }
        // ReadData -- данная функция возвращает строковый массив в соответствии с именем аттрибута
        public static string[] ReadData(string filepath, string attrname)
        {
           string[] buffer = new string[200]; // it's very very bad
           XmlTextReader reader = null;
           int i = 0;
           reader = new XmlTextReader(filepath);
            while (reader.Read())
           {
               if (reader.Name == "izmerenie")
               {
                   buffer[i] = reader.GetAttribute(attrname);
                   i++;
               }
               
           }
            return buffer;
            //XmlDocument basedoc = new XmlDocument();
            //basedoc.Load(filepath);
            //XmlNodeList list = basedoc.GetElementsByTagName("izmerenie");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (basedoc.Attributes.nam)
            //}
        }
    }
}

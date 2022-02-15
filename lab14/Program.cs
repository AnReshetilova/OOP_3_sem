using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using lab14.Vehicles;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml.Linq;
using System.Xml.XPath;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Corvette corvette = new Corvette("Vendetta", "Steve", 16);
            CustomSerializer<Corvette>.Serialize(corvette, 1);
            CustomSerializer<Corvette>.Serialize(corvette, 2);
            CustomSerializer<Corvette>.Serialize(corvette, 3);

            object obj = new object();
            CustomSerializer<Corvette>.Desirialize(out obj, 1);
            Console.WriteLine(obj.ToString());
            CustomSerializer<Corvette>.Desirialize(out obj, 2);
            CustomSerializer<Corvette>.Desirialize(out obj, 3);

            List<object> list = new List<object>();

            list.Add(new object());

            CustomSerializer<List<object>>.Serialize(list, 1);
            CustomSerializer<List<object>>.Serialize(list, 2);
            CustomSerializer<List<object>>.Serialize(list, 3);

            List<object> list1 = new List<object>();

            foreach (var o in list)
            {
                CustomSerializer<object>.Desirialize(out obj, 3);
                obj.ToString();
                list1.Add(obj);
            }

            XPathDocument doc = new XPathDocument("object.xml");
            XPathNavigator nav = doc.CreateNavigator();

            foreach (XPathItem item in nav.Select("//task/Signed"))
            {
                Console.WriteLine(item.Value);
            }

            XDocument Xdoc = new XDocument();
            XElement root = new XElement("Garden");
            XElement plant = new XElement("plant");
            XElement name = new XElement("name");
            XElement color = new XElement("color");

            name.Value = "rose";
            color.Value = "red";
            plant.Add(name);
            plant.Add(color);
            root.Add(plant);

            plant = new XElement("animal");
            name = new XElement("name");
            color = new XElement("age");
            name.Value = "flower";
            color.Value = "blue";
            plant.Add(name);
            plant.Add(color);
            root.Add(plant);

            Xdoc.Add(root);
            Xdoc.Save(@"garden.xml");

            foreach (var item in root.Elements("plant").Where(m => m.Element("name").Value == "rose"))
            {
                Console.WriteLine(item.Element("name").Value);
            }
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml;
using System.IO;
using System.Xml.Linq;


namespace Lab_14
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("\nBinary");
            Clock clock = new Clock("Clock", "Festina", 150, "No Limite");

            Console.WriteLine("Object is Create");
            BinaryFormatter binary = new BinaryFormatter();

            using (FileStream file = new FileStream("Clock.dat", FileMode.OpenOrCreate))
            {
                binary.Serialize(file, clock);
                Console.WriteLine("Object is Serialize");
            }

            using (FileStream file1 = new FileStream("Clock.dat", FileMode.OpenOrCreate))
            {
                Clock clockDeserialize = (Clock)binary.Deserialize(file1);
                Console.WriteLine(clockDeserialize.ClockName + " " + clockDeserialize.Cost);
            }
            Console.WriteLine("\nSoap");
            Clock clock1 = new Clock("Clock", "Festina", 150, "No Limite");
            Clock clock2 = new Clock("Clock", "Luch", 100, "No Limite");
            Clock[] clockArr = new Clock[] { clock1, clock2 };
            SoapFormatter soap = new SoapFormatter();
            using (FileStream file = new FileStream("Clock.soap", FileMode.OpenOrCreate))
            {
                soap.Serialize(file, clockArr);
                Console.WriteLine("Object is Serialize");
            }
            using (FileStream file1 = new FileStream("Clock.soap", FileMode.OpenOrCreate))
            {
                Clock[] clockDeserialize1 = (Clock[])soap.Deserialize(file1);
                foreach (Clock p in clockDeserialize1)
                {
                    Console.WriteLine(p.ClockName + " " + p.Cost);
                }

            }

            Console.WriteLine("\nXML");

            XmlSerializer xml = new XmlSerializer(typeof(Clock));
            using (FileStream file2 = new FileStream("Clock.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(file2, clock);
                Console.WriteLine("Object is Serialize");
            }

            using (FileStream file2 = new FileStream("Clock.xml", FileMode.OpenOrCreate))
            {
                Clock clockDeserialize = (Clock)xml.Deserialize(file2);
                Console.WriteLine(clockDeserialize.ClockName + " " + clockDeserialize.Cost);
            }
            Console.WriteLine("\nJSON");
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Clock));
            using (FileStream file3 = new FileStream("Clock.json", FileMode.OpenOrCreate))
            {
                jsonSerializer.WriteObject(file3, clock);
                Console.WriteLine("Object is Serialize");
            }

            using (FileStream file2 = new FileStream("Clock.json", FileMode.OpenOrCreate))
            {
                jsonSerializer.ReadObject(file2);
                Console.WriteLine(clock.ClockName + " " + clock.Cost);
            }
            Console.WriteLine("XPath");
            Console.WriteLine("Child nodes");
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("Clock.xml");
            XmlElement root = xmlDocument.DocumentElement;
            XmlNodeList xmlNode = root.SelectNodes("*");
            foreach (XmlNode n in xmlNode)
            {
                Console.WriteLine(n.OuterXml);
            }
            Console.WriteLine("Name");
            XmlNode childnode = root.SelectSingleNode("//Clock");
            if (childnode != null)
            {
                Console.WriteLine(childnode.OuterXml);
            }


            Console.WriteLine("XML-Document");
            XDocument xdoc = new XDocument(new XElement("Clock", new XElement("company", "luch"), new XElement("cost", "400")));
            xdoc.Save("Clock1.xml");

            XmlDocument xmlDocument1 = new XmlDocument();
            xmlDocument1.Load("Clock1.xml");
            XmlElement root1 = xmlDocument1.DocumentElement;
            XmlNodeList xmlNode1 = root1.SelectNodes("//Clock");
            foreach (XmlNode n in xmlNode1)
            {
                Console.WriteLine(n.OuterXml);
            }
            Console.WriteLine();
            XmlNodeList xmlNode2 = root1.SelectNodes("company");
            foreach (XmlNode n in xmlNode2)
            {
                Console.WriteLine(n.OuterXml);
            }
        }
    }
}

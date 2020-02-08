using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Xml1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmld = new XmlDocument();
            xmld.Load(@"C:\Users\Admin\source\repos\books.xml");
            XmlNode currentnode = xmld.DocumentElement.FirstChild;
            Console.WriteLine(currentnode.InnerText);
            XmlNode nextnode = currentnode.NextSibling;
            Console.WriteLine(nextnode.InnerText);
            XmlNode node2 = nextnode.NextSibling;
            Console.WriteLine(node2.InnerText);
        }
        
    }
}

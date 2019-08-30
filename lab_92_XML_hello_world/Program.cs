using System;
using System.Xml.Linq;

namespace lab_92_XML_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nHello World First Element\n");
            var xml01 = new XElement("testElement", 100);
            Console.WriteLine(xml01);


            Console.WriteLine("\n\nAdd Sub Element\n");
            var xml02 = new XElement("testElement", 
                new XElement("subElement",200));
            Console.WriteLine(xml02);

            Console.WriteLine("\n\nAdd Multiple Elements\n");
            var xml03 = new XElement("testElement",
                new XElement("subElement", 200),
                new XElement("subElement", 200),
                new XElement("subElement", 200),
                new XElement("subElement", 200),
                new XElement("subElement", 200),
                new XElement("subElement", 200),
                new XElement("subElement", 200)
                );
            Console.WriteLine(xml03);



            Console.WriteLine("\n\nAdd Multiple Elements\n");
            var xml04 = new XElement("testElement",
                new XElement("subElement", 
                    new XAttribute("width",200),
                    new XElement("SubSubElement",
                    new XElement("SubSubSubElement",600)
                    )
                    ),
                new XElement("subElement",
                    new XAttribute("width", 200), 300),
                new XElement("subElement",
                    new XAttribute("width", 200), 300),
                new XElement("subElement",
                    new XAttribute("width", 200), 300),
                new XElement("subElement",
                    new XAttribute("width", 200), 300)
                );
            Console.WriteLine(xml04);





        }
    }
}

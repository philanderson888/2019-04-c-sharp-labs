using System;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Xml.Serialization;
using System.IO;

namespace lab_93_Entity_XML
{
    class Program
    {

        static List<Product> products;
        static Product product = new Product();
        static Product product2 = new Product();



        static void Main(string[] args) { 
            using (var db = new Northwind())
            {
                products = db.Products.ToList();
                products.ForEach(p => Console.WriteLine(p.ProductName));

                // just get first product
                product = products.FirstOrDefault();
                product2 = products.Skip(1).FirstOrDefault();

                Console.WriteLine("\n\nFirst Product\n");
                var xmlProduct = new XElement("Product",
                    new XElement("ProductID",product.ProductID),
                    new XElement("ProductName",product.ProductName),
                    new XElement("UnitPrice",product.Cost),
                    new XElement("CategoryID",product.CategoryID)
                    );
                Console.WriteLine(xmlProduct);

                // save to file
                xmlProduct.Save("xmlOneProduct.xml");


                var xmlProductSave = new XDocument(XElement.Parse(xmlProduct.ToString()));
                var xmlProductSave2 = new XDocument(xmlProduct);

                xmlProductSave.Save("xmlOneProductv2.xml");
                 





                Console.WriteLine("\n\nNow listing all products");
                Console.WriteLine("============================\n");
                var xmlProducts = new XElement("Products",
                    from p in products
                    select new XElement("Product",
                        new XElement("ProductID", p.ProductID),
                        new XElement("ProductName", p.ProductName),
                        new XElement("UnitPrice", p.Cost),
                        new XElement("CategoryID", p.CategoryID))
                    );
                Console.WriteLine(xmlProducts);


                //Console.WriteLine("\n\nNow listing all products");
                //Console.WriteLine("============================\n");
                //var xmlProductsWithCategory = new XElement("Products",
                //    from p in products
                //    select new XElement("Product",
                //        new XElement("ProductID", p.ProductID),
                //        new XElement("ProductName", p.ProductName),
                //        new XElement("UnitPrice", p.Cost),
                //        new XElement("Category",p.Category.CategoryName)                        
                //        )
                //    );
                //Console.WriteLine(xmlProductsWithCategory);
                //xmlProductsWithCategory.Save("Products.xml");




                // write new file to xml then de-serialize it back
                // write new file
                products = db.Products.ToList();

                var xmlProductsOutput = new XElement(
                    "Products",
                    from product in products
                    select new XElement(
                        "Product",
                            new XElement("ProductID", product.ProductID),
                            new XElement("ProductName", product.ProductName),
                            new XElement("CategoryID", product.CategoryID)
                        )
                   );
                xmlProductsOutput.Save("xmlProductsOutput.xml");


                Console.WriteLine("\n\nNow Print Out List Of Deserialized Products\n");
                var productsDeserialized = new Products();

                using (var reader = new StreamReader("xmlProductsOutput.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Products));
                    productsDeserialized = (Products)serializer.Deserialize(reader);
                }
                // at this point productsDeserialized should hold our Product List

                productsDeserialized.ProductList.ForEach(p => {
                    Console.WriteLine($"{p.ProductID,-10}{p.ProductName,-25},{p.CategoryID}");
                });
            }
        }
    }


    // annotation to let system know part of deserializion
    [XmlRoot("Products")]
    public class Products
    {
        [XmlElement("Product")]
        public List<Product> ProductList { get; set; }
    }
}

using System;
using Newtonsoft.Json;

namespace lab_88_JSON_Newtonsoft
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new MyClass()
            {
                MyClassID = 1,
                MyClassName = "Bob",
                DateOfBirth = new DateTime(2000, 10, 01)
            };

            // serialise to JSON
            var jsonObject = JsonConvert.SerializeObject(instance);
            Console.WriteLine(jsonObject);


            // get data back as an object : deserialize
            var instance02 = JsonConvert.DeserializeObject<MyClass>(jsonObject);
            Console.WriteLine($"{instance02.MyClassID,-10}{instance02.MyClassName,-50}{instance02.DateOfBirth}");

        }
    }



    class MyClass
    {
        public int MyClassID { get; set; }
        public string MyClassName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

}

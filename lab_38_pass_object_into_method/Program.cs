using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_38_pass_object_into_method
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Animal("lion",12,200);
            var b = new Animal("tiger", 13, 150);
            ProcessAnimal(a); // 
            ProcessAnimal(a);
            Console.WriteLine($"after processing animal has age {a.Age} and weight {a.Weight}");
        }

        // process animals
        static void ProcessAnimal(Animal animal) {
            var newAnimal = new Animal(animal.Type, animal.Age, animal.Weight);
            // .. process newAnimal;
            animal.Age++;
            animal.Weight += 20;
        }
    }

    class Animal {
        public string Type { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        // constructor
        public Animal(string type,int age,double weight) {
            this.Type = type;
            this.Age = age;
            this.Weight = weight;
        }
    }


}

using System;
namespace LearningClasses
{
    internal class Person
    {
        //default parameterless constructor
        public Person()
        {
            Console.WriteLine("Name is not defined:");
        }
        public Person(string n, string add)
        {
            this.Name = n;
            this.Address = add;

        }
        //parameterized constructor
        public Person(string n, string add, byte a)
        {
            this.Name = n;
            this.Address = add;
            this.Age = a;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public byte Age { get; set; }

        public static string ScientificName ="homo-saphiens";

        public static void Do()
        {
            
        }


    }
}
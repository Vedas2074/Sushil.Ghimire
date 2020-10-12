using System;
// namespace AccessModifiersAndMethd
using LearningClasses;
class Program
{
    static void Main123()
    {
        // AccessModifiers accessModifiers =new AccessModifiers();
        // accessModifiers.DoSomething();
        // person person=new person();
        // person.Name="sushil";
        // person.Age=100;
        // var x=person.Age;
        // var y=person.Address;
        // var person1 = new Person("sushil","lalitpur",22);
        // var person2 = new Person("sushant","ktm",26);
        // var person3 = new Person("Dipan","Bhaktpur",16);
        
        // var person4 = new Person();
        // var x=person4.Name;
        //accessing static members
        // var x=Person.ScientificName;
        // Person.Do();
        // var s=Math.Sqrt(44);
        // var s1= Calculator.Sum<int>(23,25);
        // var s2= Calculator.Sum<decimal>(2323.12m,2565432.67m);
        //inheritence 
        // Rectangle rectangle = new Rectangle();
        // rectangle.Length=23.4;
        // rectangle.Breadth=6.12;
        // var result =rectangle.GetArea();
        // Console.WriteLine("The Area Of rectangle is "+result);
        Rectangle r= new Rectangle(23.7,6.32);
        Rectangle r1= new Rectangle(24.7,61.32);
        r.PrintDetails();
        r1.PrintDetails();
        r.GetDiagonalLength();

        // {
        //     //object initializer
        //     // Length=23.7,
        //     // Breadth =6.32
        // };
        var rArea = r.GetArea();
        var r1Area = r1.GetArea();

        Shape s= new Square(34.5);
        // var sPerimeter=s.GetPerimeter();
        s.PrintDetails();
       

        Shape c= new Circle(23.4);
        // var cArea = c.GetArea();

    }
}








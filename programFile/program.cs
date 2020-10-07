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
        var person1 = new Person("sushil","lalitpur",22);
        var person2 = new Person("sushant","ktm",26);
        var person3 = new Person("Dipan","Bhaktpur",16);
        
        var person4 = new Person();
        // var x=person4.Name;
        //accessing static members
        var x=Person.ScientificName;
        Person.Do();
        var s=Math.Sqrt(44);
        var s1= Calculator.Sum<int>(23,25);
        var s2= Calculator.Sum<decimal>(2323.12m,2565432.67m);
        







    }
}







    }
}
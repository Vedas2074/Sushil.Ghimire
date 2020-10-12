using System;
public abstract class Shape//abstruct means implementation on the own way under the class
{
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public virtual void PrintDetails()
    {
        Console.WriteLine("printing details for shape...");

    }
}

public  class Rectangle : Shape

{
    public Rectangle(double l, double b)
    {
        this.Length = l;
        this.Breadth = b;
    }
    public double Length { get; set; }
    public double Breadth { get; set; }

    public override double GetArea() => Length * Breadth;
    public override double GetPerimeter() => 2 * (Length * Breadth);
    public override double GetDiagonalLength() => Math.Sqrt(Length*Length+Breadth*Breadth);
    public override void PrintDetails()
    {
        Console.WriteLine("printing details for shape...");
        Console.WriteLine($"Length:{Length}, Breadt:{Breadth}");
        Console.WriteLine($"Area:{this.GetArea()},Perimeter:{this.GetPerimeter()}");
        

    }
}
public interface IDiagonalComputable
{
    public double GetDiagonalLength();
    
}
public class Square:Rectangle
{
    public Square(double s) : base(s,s)
    {

    }
    
}
public class Circle : Shape
{
    public Circle(double r)
    {
        Radius=r;
    }
    public double Radius { get; set; }
    public override double GetArea() => Math.PI * Radius * Radius;
    public override double GetPerimeter() => 2 * Math.PI * Radius;
}
//single inheritence
//multilevel inheritence
class A
{

}
class B : A
{

}
class C : B
{

}
//multiple inheritence is supported by the use of interfaces
class D : A, IX, IV
{

}
interface IX
{

}
interface IV
{

}


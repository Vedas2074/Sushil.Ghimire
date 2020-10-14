using System;
class IterationStatement
{
    public void LearnForLoop()
    {
        for(int i=0;i<10;i++)
        {
            Console.WriteLine("Program is my life:");
        }
        int[] numbers = {32,45,6,78,9};
        foreach(int x in numbers)
        {
            if(x % 2==0)
            {
                Console.WriteLine($"{x} is even:");
            }
            else{
                Console.WriteLine($"{x} is odd:");
            }
        }
    }
    public void LearnWhileLoop()
    {
        char option='y';
        while(option=='y')
        {
            Console.WriteLine("I love coding:");
            Console.WriteLine("print one more time?");
            option= Console.ReadKey().KeyChar;
        }
        do
        {
            Console.WriteLine("I love coding:");
            Console.WriteLine("print one more time?");
            option= Console.ReadKey().KeyChar;
        }while(option=='y');
    }
    static void Main()
    {
        IterationStatement s= new IterationStatement();
        s.LearnWhileLoop();
    }
}
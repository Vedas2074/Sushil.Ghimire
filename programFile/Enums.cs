using System;
enum DayOfWeeks
{
    Saturday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Sunday
}
internal class Demo
{
    public DayOfWeek DayOfWeek { set; get; }
    void PrintGreetings()
    {
        if (DayOfWeek == DayOfWeek.Saturday)
        {
            Console.WriteLine("What a day today,iam so fun:Alright");
        }
        else if (DayOfWeek == DayOfWeek.Sunday)
        {
            Console.WriteLine("What a cold day today,Interesting");

        }
        else
        {
            Console.WriteLine("Oh gosh, work day:,Good good");
        }
    }
}
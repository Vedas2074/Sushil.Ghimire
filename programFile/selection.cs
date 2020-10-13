using System;
namespace LearnAboutSelection
{
    public class Selection
    {
        public void LearnIfElse()
        {
            Console.WriteLine("Enter your age:");
            string input = Console.ReadLine();
            byte age = byte.Parse(input);
            if (age > 5 && age < 18)
            {
                Console.WriteLine("You are enter the first stage of study");
            }
            else if (age == 18)
            {
                Console.WriteLine("You are in high school");
            }
            else if (age > 18 && age < 75)
            {
                Console.WriteLine("you are ready to ride a bike:");
            }
            else
            {
                Console.WriteLine("Imagination is more improtant than knowlwdge:");
            }
        }
        public void LearnAboutSwitchSelect()
        {
            Char c = 'c';
            switch (c)
            {
                case 'a':
                    Console.WriteLine("You are choose A");
                    break;
                case 'b':
                    Console.WriteLine("You are choose B");
                    break;
                case 'c':
                    Console.WriteLine("You are choose C best age regarding in above portion");
                    break;
                default:
                    Console.WriteLine("Next year, you will try best:");
                    break;
            }

        }
        static void Main()
        {
            Selection s = new Selection();
            s.LearnAboutSwitchSelect();
            s.LearnIfElse();
        }
    }

}
using System;

namespace PalindromeString
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user to enter the name of the string
            //reverse the string
            //compere the string
            string a = string.Empty;
            Console.Write("Enter the name of the string:");
            a = Console.ReadLine();
            char[] temp = a.ToCharArray();
            Array.Reverse(temp);
            string b = new string(temp);

            if (a.ToLower().Equals(b.ToLower()))
            {
                Console.Write("palindrome:");
            }
            else
            {
                Console.Write("is not palindrome:");
            }


        }
    }
}

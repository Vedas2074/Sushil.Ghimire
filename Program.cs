using System;

namespace C__tuto
{
    class PalindromeExample
    {
        static void Main(string[] args)
        {
            int n,temp,r,sum=0;
            Console.WriteLine("Enter the integer:");
            n=int.Parse(Console.ReadLine());
            temp=n;
            while(n>0)
            {
                r=n%10;
                sum=(sum*10)+r;
                n/=10;
            }
            Console.WriteLine("given number is ={0}",temp);
            Console.WriteLine("its reverse is ={0}",sum);
            if(temp==sum)
            {
                Console.WriteLine("given Number {0} is palindrome",temp);
            }
            else
            {
                Console.WriteLine("given Number {0} is not palindrome",temp);

            }

        }
    }
}

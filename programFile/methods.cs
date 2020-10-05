using System;
namespace AccessModifiersAndMethd
{


    class Methods
    {
        void Printinfo()
        {
            Console.WriteLine("printing something:");
            Multiply(23.4f, 55.8f);
            Multiply(234.5f, 34.6f, 768.88f);
            Sum(2, 3, 4, 567, 7);
            GreeL("sushil", "Mr.");
            GreeL("suman");
            byte[] numbers = { 2, 4, 6, 78, 9, 67 };
            (byte Min, byte Max) result = FindMinMax(numbers);
            PrintCustomerDetails(address: "kathmandu", name: "sushil", email: "ghimires2054@gmail.com", age: 23);//named arguments

        }
        void Printsomething(string message)

        {
            Console.WriteLine(message);
        }
        float Multiply(float firstnum, float secondnum)
        {
            float product = firstnum * secondnum;
            return product;
        }
        float Multiply(float firstnum, float secondnum, float thirdnum)
        {
            float product = firstnum * secondnum * thirdnum;
            return product;
        }
        double Sum(params double[] numbers)//params keyword store many variables
        {
            double sum = 0;
            foreach (double num in numbers)
            {

                sum = sum + num;

            }
            return sum;
        }
        // optional arguments
        string GreeL(string name, string prefix = "Mr.")//optional arguments
        {
            string FullName = $"{prefix},{name}";//$ sign string interpolation
            return FullName;
        }
        //return multiple value
        (byte, byte) FindMinMax(byte[] numbers)
        {
            byte max = numbers.Math();
            byte min = numbers.Min();
            return (min, max);

        }
        void PrintCustomerDetails(string name, string address, string email, byte age)
        {
            Console.WriteLine($"{name},{address},{email},{age}");
        }
        //ecpression bodied method syntax
        float Subtract(float firstnum, float secondnum) => firstnum - secondnum;

        //touple ranging from 0-255 which is 8 bit

    }
}
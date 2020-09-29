using System;

namespace programFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("how many string do you want?");
            // string can = Console.ReadLine();
            // Console.Write("I will get 4 more candies" + (Convert.ToInt32(can) + 4));
            // Console.Write(true && true);
            // Console.Write(true && false);
            // Console.Write(false && false);
            // Console.Write(!false);
            //  Console.Write(!true);


            // int a=4;
            // float b=34.3F;
            // implicity type casting 
            // char to int to long to float to double
            // int x=4;
            // int z='a';
            // convert to char to int which is possible(implicit)
            // double y=x;
            // implicit type casting
            // int m=(int)3.5;
            // explicit type casting
            // float varr=Convert.ToInt32(34.6);
            // Console.Write("Enter your name:");
            // string name=Console.ReadLine();
            // Console.Write("My name is " +name);
            // Console.ReadLine();
            // Console.Write("the number is {0} \n",a);
            // Console.Write("the number is {0} \n",b);
            // Console.Write("the number is {0} \n",m);
            // Console.Write("the number is {0} \n",y);
            // Console.Write("the ASCII value of a is {0} \n",z);
            // Console.Write("the number is {0} \n",varr);
            // Console.WriteLine("Hello World!");
            // int num,rem,temp,sum=0;
            // Console.Write("Enter the integer:");
            // num=int.Parse(Console.ReadLine());
            // temp=num;
            // while(num>0)
            // {
            //     rem=num%10;
            //     sum=sum+(rem*rem*rem);
            //     num=num/10;
            // }
            // Console.Write("the given number is {0} \n",temp);
            // if(sum==temp)
            // {
            //     Console.Write("The number {0} is armstrong\n",temp);
            // }
            // else{
            //     Console.Write("The number {0} is not armstrong",temp);

            // }
            // int a = Math.Max(23, 87);
            // Console.Write("The maximum value is {0}", a);
            // double b = Math.Sqrt(121);
            // Console.Write("The squRT value is {0}", b);
            // int c=Math.Abs(-44);
            // Console.Write("The  value is {0} \n",c);
            // string name ="This is my name ";
            // Console.Write(name.Length);
            // Console.Write(name.ToUpper());
            // Console.Write(string.Concat(name,"sushil ghimire"));
            // or console.write(name+"sushil ghimire")
            // sting interpolation
            // string namik=Console.ReadLine();
            // string candies=Console.ReadLine();
            // Console.Write($"your name is {namik}. you will get {candies} candies");
            // string var="hello welcome \" friends";//escape sequence in c#
            // Console.Write(var[0]);
            // Console.Write(var.IndexOf("fri"));
            // Console.Write(var.Substring(1));
            // Console.Write(var);
            Console.Write("enter your age:");
            string namas=Console.ReadLine();
            int age =Convert.ToInt32(namas);
            if(age<2)
            {
                Console.Write("you are just born:");
            }
            else if(age<10)
            {
            Console.Write("please you first pass the high school:");
            }
            else if(age<18)
            {
                Console.Write("your age is below 18 try again leter:");
            }

            else if(age<75){
                Console.Write("absolutely you can drive:");
            }
            else{
                Console.Write("you can't drive:");
            }




        }
    }
}

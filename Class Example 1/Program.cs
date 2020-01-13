using System;

namespace Class_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int avg = (num1 + num2 + num3) / 3;

            if(avg < 10)
            {
                Console.WriteLine("Fail!");
            }
            if(avg >= 10)
            {
                Console.WriteLine("Pass!");
            }
        }
    }
}

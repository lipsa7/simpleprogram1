using System;
using System.Collections.Generic;
using System.Linq;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the first list");
            string num1 = Console.ReadLine();
            Console.WriteLine("Enter second list of numbers");
            string num2 = Console.ReadLine();
            //char[] ch = new char[num1.Length];
            //for(int i )
            List<string> result1 = num1.Split(' ').ToList();

            List<string> result2 = num2.Split(new char[] { ' ' }).ToList();
            var CommonNumbers = (result1.Intersect(result2)).ToList();
            //Console.WriteLine(CommonNumbers[0]);
            foreach(var item in CommonNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Display odd");
            foreach(var item in result1)
            {
                if((Convert.ToInt32(item))%2!=0)
                {
                    Console.Write(item);
                }
            }
            foreach (var item in result2)
            {
                if ((Convert.ToInt32(item)) % 2 != 0)
                {
                    Console.Write(item);
                }
            }
        }
    }
}

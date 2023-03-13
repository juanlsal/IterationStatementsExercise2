using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Channels;

namespace IterationStatements
{
    class Program
    {

        static void Main(string[] args)
        {
            //exercise 1
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 100; i <= 150; i+=10)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"{i}");
            }
            for (double i = 4.0; i >= 0; i-=0.25)
            {
                Console.WriteLine($"{i}");
            }
            string p = "L";
            for (int i = 0; i < 10; i++)
            {
                Console.Write(p);
            }



            //exercise 2
            Ex1();
        }

        //exercise 2
        static void Ex1()
        {
            var numbers = new List<int>();
            int num = 0; 
            do
            {
                num++;
                numbers.Add(num);
            } while (num < 100);// <---- While your variable is less than 100
            
            while (num < 200)// <--- While num is less than 200
            {
                num++;

                numbers.Add(num);
            }

            Console.WriteLine("Increase:");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            for (int i = 199; i <= (numbers.Count) && i >= 0; i--)
            {
                Console.WriteLine(i);

            }
        }
    }
}

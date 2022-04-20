using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        /// <summary>
        /// The following lines of code are two solutions in solving this challenge one has the {} containers
        /// whereas the other solution does not my aim was to not use or rely on the else keyword 
        /// i will revisit this challenge later on 
        /// and upload a more complete version without the else keyword
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int j = 1; j <= 100; j++)
            {
                if (j % 3 == 0 && j % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (j % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (j % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(j);
                }
            }
            Console.ReadLine();

            //OR

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
            //    else if (i % 5 == 0) Console.WriteLine("Buzz");
            //    else if (i % 3 == 0) Console.WriteLine("Fizz");
            //    else Console.WriteLine(i);
            //}
            //Console.ReadKey();
        }

    }
    
}
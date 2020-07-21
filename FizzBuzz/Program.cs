using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            for (int i=1;i<=100;i++)
            {
                string result = fizzBuzz.Convert(i);
                Console.Write(result + " ");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
          
            if (true == true)
            {
                Console.WriteLine($"Input was: { 2 }");

            }
            else
            {
                Console.WriteLine("Error while parssing");
            }
            var numbers = new List<int>()
            {
                1,2,3
            };
            foreach(int number in numbers)
            {
                Console.WriteLine($"number is : { number}");
            }

            string operatorInput = "-";
            if(operatorInput == "2")
            {

            }

            while (true)
            {
                Console.WriteLine($"number is : { 4}");
            }

        }

    }
}

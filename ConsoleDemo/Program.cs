using System;
using System.Collections.Generic;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
              if (true == true)
              {
                  Console.WriteLine($"Input was: { 2 }");

              }
              else
              {
                  Console.WriteLine("Error while parssing");
              }

              Console.WriteLine("=====================================================");
              var inputString = Int32.Parse(Console.ReadLine());
              Console.WriteLine($"number is : { inputString}");


              Console.WriteLine("=====================================================");

              string caseSwitch = "+";

              switch (caseSwitch)
              {
                  case "/":
                      Console.WriteLine($"number is //// : { inputString}");
                      break;
                  case "+":
                      Console.WriteLine($"number is ++++ : { inputString}");
                      break;
                  case "-":
                      Console.WriteLine($"number is ++++ : { inputString}");
                      break;
                  default:
                      Console.WriteLine("Default case");
                      break;
              }


              Console.WriteLine("=====================================================");
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

           */
            var sebClient = new Customer()
            {
                Forenames = "Jaunius",
                LastNames = "Pinelis"
             };
            var bank1 = new Bank()
            {
                Name = "SEB bank",
                Customers = new List<Customer>()
                {
                    sebClient
                }
            };
            var bank2 = new Bank()
            {
                Name = "Danske bank",
                Customers = new List<Customer>()
                {
                    sebClient
                }
            };
            var bank3 = new Bank()
            {
                Name = "Swedbank",
                Customers = new List<Customer>()
                {
                    sebClient
                }
            };
            Console.WriteLine(bank2.GetInformation());
           // bank2.SetDeleted(true);

           // Console.WriteLine(bank2.Deleted);
        }

    }
}

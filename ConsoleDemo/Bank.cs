using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo
{
    class Bank
    {
        public string Name { get; set; }

        public List<Customer> Customers { get; set; }

        public Bank()
        {
            Name = "Default Bank";
        }

        public bool Deleted {  get;  private set; } = false;

        public string GetInformation()
        {
            return Name;
        }

        public void SetDeleted(bool value) 
        {
            Deleted = value;
        
        }
    }
}

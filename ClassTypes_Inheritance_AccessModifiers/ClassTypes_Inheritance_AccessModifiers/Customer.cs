using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypes_Inheritance_AccessModifiers
{
    //Customer IS-A Person
    internal class Customer : Person
    {
        public int CustomerId { get; set; }
        public override bool ChangeAddress(string oldestAddress, string newAddress)
        {
            Console.WriteLine($"Customer has changed the address from {oldestAddress} to {newAddress}!");
            return true;
        }
    }
}

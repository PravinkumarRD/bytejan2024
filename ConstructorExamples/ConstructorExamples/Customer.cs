using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExamples
{
    internal class Customer : Person
    {
        public int CustomerId { get; set; }
        public Customer()
        {
            Console.WriteLine("Customer class Default Constructor Executed!");
        }
        public Customer(int cid, int socialId, string name, string city) : base(socialId, name, city)
        {
            Console.WriteLine("Customer class Parameterized Constructor Executed!");
            CustomerId = cid;
        }
        public Customer(Customer customer)
        {
            Console.WriteLine("Customer class Copy Constructor Executed!");
            CustomerId = customer.CustomerId;
            ContactName = customer.ContactName;
            City = customer.City;
            SocialId = customer.SocialId;
            Console.WriteLine($"Customer {ContactName} lives in city {City}!");
        }
    }
}

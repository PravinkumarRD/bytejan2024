using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExamples
{
    internal abstract class Person
    {
        static Person()
        {
            Console.WriteLine("Person class Static Constructor Executed!");
        }
        public Person()
        {
            Console.WriteLine("Person class Default Constructor Executed!");
        }
        public Person(int adharCardNo,string name,string city):this()
        {
            Console.WriteLine("Person class Parameterized Constructor Executed!");
            SocialId = adharCardNo;
            ContactName = name;
            City = city;
        }
        public int SocialId { get; set; }
        public string? ContactName { get; set; }
        public string? City { get; set; }
    }
}

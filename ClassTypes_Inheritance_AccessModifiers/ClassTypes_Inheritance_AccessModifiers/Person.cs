using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypes_Inheritance_AccessModifiers
{
    internal abstract class Person
    {
        private int SocialId { get; set; }
        public string? ContactName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public int Zipcode { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string GetPersonInfo()
        {
            return $"Person {ContactName} lives in city {City}";
        }
        public abstract bool ChangeAddress(string oldestAddress, string newAddress);
    }
}

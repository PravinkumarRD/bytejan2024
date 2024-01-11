using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypes_Inheritance_AccessModifiers
{
    //PrimeCustomer IS-A Customer
    internal sealed class PrimeCustomer:Customer
    {
        public int PrimeId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypes_Inheritance_AccessModifiers
{
    internal static class Counter
    {
        public static int Count { get; set; } = 1;
        public static void IncrementCount()
        {
            Count++;
        }
    }
}

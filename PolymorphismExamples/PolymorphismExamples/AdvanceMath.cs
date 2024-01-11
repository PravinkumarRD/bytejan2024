using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExamples
{
    internal class AdvanceMath : BasicMath
    {
        public override int Addition(int num1, int num2)
        {
            return num1 + num2 - 1000;
        }
    }
}

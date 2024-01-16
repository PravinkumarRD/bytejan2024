using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamExamples
{
    internal class Dummy : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose Method of Dummy class called!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypes_Inheritance_AccessModifiers
{
    internal class Parent
    {
        public int ParentId { get; set; }
    }

    class Child : Parent
    {
        public int ChildId { get; set; }
    }
    class GrandChild : Child
    {
        public int GrandChildId { get; set; }
    }
}

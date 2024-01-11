using AP=India.AndhraPradesh;
using MH=India.Maharashtra;
namespace ClassTypes_Inheritance_AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Different Class Types");
            PrimeCustomer c1 = new PrimeCustomer();
            Console.WriteLine(Counter.Count);
            Counter.IncrementCount();
            Counter.IncrementCount();
            Counter.IncrementCount();
            Console.WriteLine(Counter.Count);
            Math math = new Math();
            
            
        }
    }
}
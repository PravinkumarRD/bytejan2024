using BajajCalculation.MathLibrary;

namespace BajajCalculation.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bajaj Calculation UI Application!");
            IndianSales sales = new IndianSales();


        }
    }

    class MyClass1 : Parent
    {
        public MyClass1()
        {

        }
    }
    class MyClass2 : Parent
    {
        Parent p1 = new Parent();
        public MyClass2()
        {

        }
    }
}

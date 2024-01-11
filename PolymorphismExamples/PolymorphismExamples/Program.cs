namespace PolymorphismExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method Overloading
            /*
             DubaiSales sales = new DubaiSales();
            Console.WriteLine($"Sales Net Profit without GST - INR {sales.SalesNetProfit(12000, 13000, 150000)}/-");
            Console.WriteLine($"Sales Net Profit with 18% GST - INR {sales.SalesNetProfit(12000, 13000, 150000, 18)}/-");
            Console.WriteLine($"Sales Net Profit with 18% GST and Shipping Charges - INR {sales.SalesNetProfit(12000, 13000, 150000, 18, 10000)}/-");
            */
            BasicMath basicMath = new BasicMath();
            Console.WriteLine(basicMath.Addition(1000,1000));
            AdvanceMath advanceMath = new AdvanceMath();
            Console.WriteLine(advanceMath.Addition(1000, 1000));
            BasicMath baMath=new AdvanceMath();
            Console.WriteLine(baMath.Addition(1000, 1000));
        }
    }
}
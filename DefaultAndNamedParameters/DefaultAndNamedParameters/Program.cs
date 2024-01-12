namespace DefaultAndNamedParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sales sales = new Sales();
            Console.WriteLine($"Sales Net Profit is {sales.SalesNetProfit(12000,13000,150000)}");
            Console.WriteLine($"Sales Net Profit is {sales.SalesNetProfit(cogs: 13000, actualSales: 150000)}");
        }
    }
}

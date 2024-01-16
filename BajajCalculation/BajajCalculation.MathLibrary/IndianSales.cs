namespace BajajCalculation.MathLibrary
{
    public class IndianSales : Sales
    {
        public double SalesNetProfit(double cogs, double expense, double actualSales, int gstPercent = 0)
        {
            double gstAmount = actualSales * gstPercent / 100;
            return actualSales - (cogs + expense + gstAmount);
        }
    }
}

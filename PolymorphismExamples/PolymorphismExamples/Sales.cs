using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExamples
{
    //Calculate Sales Net Profit = Incoming Money - Outgoing Money
    //COGS - Cost of Goods and Services [Outgoing]
    //Expense - Outgoing Money
    //GST - Outgoing Money
    //ActualSales - Incoming Money
    internal class Sales
    {
        public double SalesNetProfit(double cogs,double expense, double actualSales)
        {
            return actualSales - (cogs + expense);
        }
        public double SalesNetProfit(double cogs, double expense, double actualSales, int gstPercent)
        {
            double gstAmount = actualSales * gstPercent / 100;
            return actualSales - (cogs + expense + gstAmount);
        }
    }
}

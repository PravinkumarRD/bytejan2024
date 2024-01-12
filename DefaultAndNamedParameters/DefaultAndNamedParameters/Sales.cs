using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultAndNamedParameters
{
    internal class Sales
    {
        public double SalesNetProfit(double cogs = 12000, double expense = 15000, double actualSales = 0, int gstPercent = 18)
        {
            double gstAmount = actualSales * gstPercent / 100;
            return actualSales - (cogs + expense + gstAmount);
        }
    }
}

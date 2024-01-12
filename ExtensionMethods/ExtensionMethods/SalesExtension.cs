using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal static class SalesExtension
    {
        public static double SalesNetProfitWithGst(this IndiaSales sales, double cogs, double expense, double actualSales, int gstPercent)
        {
            double gstAmount = actualSales * gstPercent / 100;
            return actualSales - (cogs + expense + gstAmount);
        }
    }
}

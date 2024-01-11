using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExamples
{
    internal class DubaiSales:Sales
    {
        public double SalesNetProfit(double cogs, double expense, double actualSales, int gstPercent, double shippingCharges)
        {
            double gstAmount = actualSales * gstPercent / 100;
            return actualSales - (cogs + expense + gstAmount + shippingCharges);
        }
    }
}

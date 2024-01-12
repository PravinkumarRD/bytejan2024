using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal sealed class IndiaSales
    {
        public double SalesNetProfit(double cogs, double expense, double actualSales)
        {
            return actualSales - (cogs + expense);
        }
    }
}

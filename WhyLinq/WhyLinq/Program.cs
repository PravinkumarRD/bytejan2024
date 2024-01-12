namespace WhyLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bajaj Customers Application!");
            /*//Object Initializer
            Customer customer = new Customer() { CustomerId = 1, ContactName = "Manish K.", City = "London" };
            */

            //List<Result> results = new List<Result>();
            //foreach (Customer customer in GetAllCustomers())
            //{
            //    Result? res = results.Find(delegate (Result r) { return r.City == customer.City; });
            //    if (res != null)
            //    {
            //        res.Count++;
            //    }
            //    else
            //    {
            //        res = new();
            //        res.City = customer.City;
            //        res.Count = 1;
            //        results.Add(res);
            //    }
            //}
            /*var results = from customer in GetAllCustomers()
                          group customer by customer.City into groupResult
                          select new Result() { City = groupResult.Key, Count = groupResult.Count() };
            foreach (Result result in results)
            {
                Console.WriteLine($"In city {result.City}, there is/are {result.Count} number of customers!");
            }*/
            //Local Variable Inference Type
            /*var query1 = from customer in GetAllCustomers()
                             //where customer.City == "Berlin"
                         orderby customer.City descending, customer.ContactName ascending
                         select customer;
            foreach (var cust in query1)
            {
                Console.WriteLine($"Customer {cust.ContactName} lives in city {cust.City}!");
            }*/
            var CustomersOrders = from customer in GetAllCustomers()
                                  join
                                  order in GetAllOrders()
                                  on customer.CustomerId equals order.CustomerId
                                  select new { CustomerName=customer.ContactName, City=customer.City, ODate=order.OrderDate };
            foreach (var co in CustomersOrders)
            {
                Console.WriteLine($"Customer {co.CustomerName} from city {co.City} has placed an order on {co.ODate}!");
            }

        }
        private static List<Customer> GetAllCustomers()
        {
            //Collection initializer
            return new List<Customer>()
            {
                new(){CustomerId=1001,ContactName="Alisha C.", City="Mumbai"},
                new(){CustomerId=1002,ContactName="Manisha K.", City="Mumbai"},
                new(){CustomerId=1003,ContactName="Anjala Johns", City="Berlin"},
                new(){CustomerId=1004,ContactName="John Mark", City="Berlin"},
            };
        }
        private static List<Order> GetAllOrders()
        {
            return new List<Order>()
            {
                new(){OrderId=1,OrderDate=DateTime.Now,Quantity=10,CustomerId=1001},
                new(){OrderId=2,OrderDate=DateTime.Now,Quantity=12,CustomerId=1001},
                new(){OrderId=3,OrderDate=DateTime.Now,Quantity=14,CustomerId=1003},
                new(){OrderId=4,OrderDate=DateTime.Now,Quantity=15,CustomerId=1003}
            };
        }
    }
}

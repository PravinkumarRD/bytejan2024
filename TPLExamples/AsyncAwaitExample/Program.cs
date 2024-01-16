namespace AsyncAwaitExample
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            Console.WriteLine($"Main Method executing on Thread Id {Thread.CurrentThread.ManagedThreadId}");

            try
            {
                var Customers = await GetAllCustomersAsync();
                var MyCustomersList = await GetCustomersByNameAsync(Customers, "P");
                var PuneCityCustomers = await GetCustomersByCityAsync(MyCustomersList, "Raipur");
                foreach (var cust in MyCustomersList)
                {
                    await Console.Out.WriteLineAsync($"Customer {cust.ContactName} is from {cust.City}!");
                }
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
            }
        }
        private static async Task<List<Customer>> GetAllCustomersAsync()
        {
            Console.WriteLine($"Task - 1 executing on Thread Id {Thread.CurrentThread.ManagedThreadId}");
            return await Task<List<Customer>>.FromResult(new List<Customer>() {
                    new(){CustomerId=1,ContactName="Pravinkumar R. D.",City="Pune"},
                    new(){CustomerId=2,ContactName="Yash P. D.",City="Pune"},
                    new(){CustomerId=3,ContactName="Alisha C.",City="Mumbai"},
                    new(){CustomerId=4,ContactName="Panish K.",City="Raipur"},
                    new(){CustomerId=5,ContactName="Prasad K. P.",City="Pune"}
                });
        }
        private static async Task<List<Customer>> GetCustomersByCityAsync(List<Customer> customers, string cityName)
        {
            Console.WriteLine($"Task - 2 executing on Thread Id {Thread.CurrentThread.ManagedThreadId}");
            return await Task<List<Customer>>.FromResult(customers.Where(c => c.City == cityName).ToList());
        }
        private async static Task<List<Customer>> GetCustomersByNameAsync(List<Customer> customers, string filterChar)
        {
            Console.WriteLine($"Task - 3 executing on Thread Id {Thread.CurrentThread.ManagedThreadId}");

            return await Task<List<Customer>>.FromResult(customers.Where(c => c.ContactName.StartsWith(filterChar)).ToList());
        }
    }
}

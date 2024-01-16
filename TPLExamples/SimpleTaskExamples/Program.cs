namespace SimpleTaskExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Method executing on Thread Id {Thread.CurrentThread.ManagedThreadId}");
            /* 
             Task.Run(() =>
             {
                 Console.WriteLine($"Task - 1 executing on Thread Id {Thread.CurrentThread.ManagedThreadId}");
             });
             Task.Run(() =>
             {
                 Console.WriteLine($"Task - 2 executing on Thread Id {Thread.CurrentThread.ManagedThreadId}");
             });
            
            string result = Task.Run<string>(() => {
                Console.WriteLine($"Task - 1 executing on Thread Id {Thread.CurrentThread.ManagedThreadId}");
                return "Welcome To Bajaj"; 
            }).Result;
            Console.WriteLine(result);*/
            /*
            List<Customer> customers = Task.Run<List<Customer>>(() =>
            {
                Console.WriteLine($"Task - 1 executing on Thread Id {Thread.CurrentThread.ManagedThreadId}");
                return new List<Customer> {
                    new(){CustomerId=1,ContactName="Pravinkumar R. D.",City="Pune"},
                    new(){CustomerId=2,ContactName="Yash P. D.",City="Pune"},
                    new(){CustomerId=3,ContactName="Alisha C.",City="Mumbai"},
                    new(){CustomerId=4,ContactName="Manish K.",City="Raipur"},
                    new(){CustomerId=5,ContactName="Prasad K. P.",City="Pune"}
                };
            }).ContinueWith<List<Customer>>(customers =>
            {
                Console.WriteLine($"Task - 2 executing on Thread Id {Thread.CurrentThread.ManagedThreadId}");
                return customers.Result.Where(c => c.City == "Pune").ToList();
            }).ContinueWith<List<Customer>>(customers =>
            {
                Console.WriteLine($"Task - 3 executing on Thread Id {Thread.CurrentThread.ManagedThreadId}");
                return customers.Result.Where(c => c.ContactName.StartsWith(Convert.ToChar("P"))).ToList();
            }).Result;
            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer {customer.ContactName} lives in city {customer.City}");
            }
            */

            /*
            Task<string> finalResult = Task.WhenAny(Task.Factory.StartNew<string>(() =>
            {
                Task.Delay(3000).Wait();
                return "Welcome To India!";
            }),
            Task.Factory.StartNew<string>(() =>
            {
                Task.Delay(3000).Wait();
                return "Welcome To Maharashtra!";
            }),
            Task.Factory.StartNew<string>(() =>
            {
                Task.Delay(5000).Wait();
                return "Welcome To Pune!";
            }),
            Task.Factory.StartNew<string>(() =>
            {
                Task.Delay(1000).Wait();
                return "Welcome To Bajaj!";
            })).Result;
            Console.WriteLine(finalResult.Result);
            */
            string[] finalResult = Task.WhenAll(Task.Factory.StartNew<string>(() =>
            {
                Console.WriteLine($"Task - 1 executing on Thread Id {Thread.CurrentThread.ManagedThreadId}");
                Task.Delay(3000).Wait();
                return "Welcome To India!";
            }),
            Task.Factory.StartNew<string>(() =>
            {
                Console.WriteLine($"Task - 2 executing on Thread Id {Thread.CurrentThread.ManagedThreadId}");
                Task.Delay(3000).Wait();
                return "Welcome To Maharashtra!";
            }),
            Task.Factory.StartNew<string>(() =>
            {
                Console.WriteLine($"Task - 3 executing on Thread Id {Thread.CurrentThread.ManagedThreadId}");
                Task.Delay(5000).Wait();
                return "Welcome To Pune!";
            }),
            Task.Factory.StartNew<string>(() =>
            {
                Console.WriteLine($"Task - 4 executing on Thread Id {Thread.CurrentThread.ManagedThreadId}");
                Task.Delay(1000).Wait();
                return "Welcome To Bajaj!";
            })).Result;
            Console.WriteLine(finalResult[0]);
            foreach (var item in finalResult)
            {
                Console.WriteLine(item);
            }
        }
    }
}

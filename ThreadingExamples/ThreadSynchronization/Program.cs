namespace ThreadSynchronization
{
    internal class Program
    {
        static int Counter = 1;
        static object o = new object();
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Method is executing on Thread No. - {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Main Thread Started!");
            Thread t1 = new Thread(new ThreadStart(Job1));
            Thread t2 = new Thread(new ThreadStart(Job2));
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;
            t2.Start();
            t1.Start();
            t1.Join();
            t2.Join();

            Console.WriteLine("Main Thread Ended!");
        }
        private static void Job1()
        {
            Monitor.Enter(o);
            //lock (o)
            //{
                Console.WriteLine($"Job-1 Method is executing on Thread No. - {Thread.CurrentThread.ManagedThreadId}");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Acquired Ticket No by Job - 1 is - {Counter}");
                    Counter++;
                }
            //}
            Monitor.Exit(o);
        }
        private static void Job2()
        {
            Monitor.Enter(o);
            //lock (o)
            //{
                Console.WriteLine($"Job-2 Method is executing on Thread No. - {Thread.CurrentThread.ManagedThreadId}");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Acquired Ticket No by Job - 2 is - {Counter}");
                    Counter++;
                    if (i == 5) Thread.Sleep(3000);
                }
            //}
            Monitor.Exit(o);
        }
    }
}

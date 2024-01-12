namespace GenericCollectionsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<string> names = new List<string>();
            names.Add("First");
            names.Add("Second");
            names.Add("Third");
            
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            
            Stack<string> books = new();
            books.Push("Book-1");
            books.Push("Book-2");
            books.Push("Book-3");
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            
            
            Queue<int> tickets=new Queue<int>();
            tickets.Enqueue(100);
            tickets.Enqueue(101);
            tickets.Enqueue(102);
            tickets.Enqueue(103);
            foreach (int no in tickets)
            {
                Console.WriteLine(no);
            }
            */
            Dictionary<int, string> employees = new();
            employees.Add(1000, "One");
            employees.Add(1002, "Two");
            employees.Add(1003, "Three");
            employees.Add(1004, "Four");
            foreach (int employeeId in employees.Keys)
            {
                Console.WriteLine($"Employee Id is {employeeId} and name is {employees[employeeId]}!");
            }
        }
    }
}

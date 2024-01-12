using System.Collections;

namespace NonGenericCollectionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ArrayList names = new ArrayList();
             names.Add(1000);
             names.Add("Manish");
             names.Add(true);

            Stack books = new Stack();
             books.Push("Book-1");//Boxing
             books.Push("Book-2");
             books.Push("Book-3");
             string lastBook = books.Pop().ToString();//Unboxing
            Queue tickets = new Queue();
            tickets.Enqueue(1000);//Boxing
            int firstTicket = Convert.ToInt32(tickets.Dequeue()); //Unboxing*/
            Hashtable employees = new Hashtable();
            employees.Add(1000, "One");//Boxing
            employees.Add(1000, "One");//Boxing
            string employee1 = employees[1000].ToString();
        }
    }
}

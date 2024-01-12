namespace ConstructorExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Customer customer1 = new Customer(1000, 238293892, "Manish K.", "Pune");
            Customer customer2 = new Customer(customer1);
        }
    }
}

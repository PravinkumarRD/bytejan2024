namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your full name!");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your age!");
            int age = int.Parse(Console.ReadLine());
            if (age>90)
            {
                //Console.WriteLine("Person {0} can not travel by air as his/her age is more than 90!",name);
                Console.WriteLine($"Person {name} can not travel by air as his/her age is more than 90!");
            }
            else
            {
                Console.WriteLine($"Person {name} can travel by the air! His/her age is {age}");
            }
        }
    }
}
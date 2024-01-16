using UI.Dal;
using UI.Models;
namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic Example!");
            Customer customer1 = new Customer() { CustomerId = 100, ContactName = "Alicia C.", City = "Berlin" };
            Customer customer2 = new Customer() { CustomerId = 101, ContactName = "John Mark", City = "London" };
            ICommonRespository<Customer> customerRepo = new CommonRespository<Customer>();
            customerRepo.Insert(customer1);
            customerRepo.Insert(customer2);

            foreach (var cust in customerRepo.GetAll())
            {
                Console.WriteLine($"Customer {cust.ContactName} lives in city {cust.City}!");
            }
            Console.WriteLine("");
            Category category1 = new Category() { CategoryId = 1, CategoryName = "Electronics", Description = "All Electronic products!" };
            Category category2 = new Category() { CategoryId = 2, CategoryName = "Electrical", Description = "All Electrical products!" };
            ICommonRespository<Category> catRepo=new CommonRespository<Category>();
            catRepo.Insert(category1);
            catRepo.Insert(category2);
            foreach (var cat in catRepo.GetAll())
            {
                Console.WriteLine($"Category {cat.CategoryName} contains {cat.Description}!");
            }
        }
    }
}

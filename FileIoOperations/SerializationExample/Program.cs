using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
namespace SerializationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Serialization Example!");
            //SerializeOrderInXml();
            DeserializeOrderFromXml();
        }
        private static void SerializeOrderInXml()
        {
            Order order = new Order()
            {
                OrderId = 1,
                OrderDate = DateTime.Now,
                RequiredDate = DateTime.Now.AddDays(2),
                Quantity = 100,
            };
            using (FileStream FS = new FileStream("CustomerOrder.xml", FileMode.OpenOrCreate, FileAccess.Write))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Order));
                xml.Serialize(FS, order);
                FS.Close();
            }
        }
        private static void DeserializeOrderFromXml()
        {
            using (FileStream FS = new FileStream("CustomerOrder.xml", FileMode.Open, FileAccess.Read))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Order));
                //Order existingOrder = (Order)xml.Deserialize(FS);
                Order existingOrder = xml.Deserialize(FS) as Order;
                if (existingOrder != null)
                {
                    Console.WriteLine($"Order Id {existingOrder.OrderId} has order date {existingOrder.OrderDate} with quantity {existingOrder.Quantity}");
                }
                else
                {
                    Console.WriteLine("We did not find any existing order!");
                }
                FS.Close();
            }
        }
    }
}

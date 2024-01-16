namespace StreamExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StreamWriter and StreamReader Example!");
            //using(Dummy dummy = new Dummy())
            //{

            //}
            
            string filePath = @"D:\WebxTraining\Bajaj-Jan-2024-Byte-Programme\C# Basics\bajaj-messages.txt";
            using (StreamWriter SW = new StreamWriter(filePath, true)) 
            {
                SW.WriteLine("Welcome To Bajaj Pune!");
                SW.WriteLine("Welcome To Bajaj Bangalore!");
                SW.Close();
            }
            using (StreamReader SR=new StreamReader(filePath))
            {
                Console.WriteLine(SR.ReadToEnd());
                SR.Close();
            }
        }
    }
}

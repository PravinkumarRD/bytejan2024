namespace BasicIOOperations_FileClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduction to File Class Methods!");
            string filePath = @"D:\WebxTraining\Bajaj-Jan-2024-Byte-Programme\C# Basics\logger.txt";
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                FileStream FS = File.Create(filePath);
                FS.Close();
                FS.Dispose();
                StreamWriter SW = File.AppendText(filePath);
                SW.WriteLine("Welcome To India!!!");
                SW.WriteLine("Welcome To Maharashtra!");
                SW.WriteLine("Welcome To Pune!");
                SW.WriteLine("Welcome To Bajaj!");
                SW.Close();
                SW.Dispose();
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine(uae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Always Executed!");
            }

            Console.WriteLine(File.ReadAllText(filePath));
        }
    }
}

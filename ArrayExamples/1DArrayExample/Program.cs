namespace _1DArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-D Array Example!");
            string[] names = new string[5] { "A", "B", "C", "D", "E" };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("2-D Array Example!");
            int[,] numbers = new int[2, 2] { { 10, 100 }, { 20, 200 } };
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine(numbers[row, col]);
                }
            }
            Console.WriteLine("Jagged Array Example!");
            int[][] marks = new int[3][];
            marks[0] = new int[4] { 10, 20, 30, 40 };
            marks[1] = new int[2] { 10, 20 };
            marks[2] = new int[3] { 10, 20, 40 };
            for (int row = 0; row < 3; row++)
            {
                Console.WriteLine($"{row} - Student Marks are - ");
                for (int col = 0; col < marks[row].Length; col++)
                {
                    Console.Write(marks[row][col] + "\t");
                }
                Console.WriteLine("");
            }
        }
    }
}

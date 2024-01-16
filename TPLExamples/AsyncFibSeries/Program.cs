namespace AsyncFibSeries
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            Console.WriteLine("Starting!");
            int result = await Fibonacci(10);
            await Console.Out.WriteLineAsync(result.ToString());
            Console.WriteLine("Ending!");
        }
        static async Task<int> Fibonacci(int number)
        {
            if (number <= 1)
                return number;
            return await Task<int>.FromResult(Fibonacci(number - 1).Result + Fibonacci(number - 2).Result);
        }
    }
}

using System;
using System.Threading.Tasks;

namespace MultiTask
{
    internal class Program
    {
        static async Task<int> Print1()
        {
            await Task.Delay(3000);
            Console.WriteLine(5);
            return 5;
        }

        static async Task<int> Print2()
        {
            await Task.Delay(1000);
            Console.WriteLine(6);
            return 6;
        }

        static async Task Main(string[] args)
        {
            Task<int> task = Print1();
            Task<int> task2 = Print2();
            int res1 = await task;
            int res2 = await task2;
            Console.WriteLine($"{res1} {res2}");
        }
    }
}

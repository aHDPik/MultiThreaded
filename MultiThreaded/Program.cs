using System;
using System.Diagnostics;
using System.Threading;

namespace MultiThreaded
{
    internal class Program
    {
        static int a;

        static Semaphore semaphore = new Semaphore(0, 1);

        static void PrintEveryTwoSeconds()
        {

            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine("2");
            }
            semaphore.Release();
        }

        static void PrintEverySecond()
        {
            semaphore.WaitOne();
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine("1");
            }

        }

        static void Main(string[] args)
        {
            a = 0;
            Thread t1 = new Thread(PrintEverySecond);
            Thread t2 = new Thread(PrintEveryTwoSeconds);
            t1.IsBackground = true;
            t2.IsBackground = true;
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine(a);
        }
    }
}

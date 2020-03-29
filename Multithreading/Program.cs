using System;
using System.Threading;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Functions.Function01);
            Thread thread2 = new Thread(Functions.Function02);
            thread1.Start();
            thread2.Start();
            Console.ReadLine();
        }
    }
}

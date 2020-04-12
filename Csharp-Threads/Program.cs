using System;
using System.Threading;

namespace Csharp_Threads
{
    class Program
    {
        static void NewThread()
        {
            Console.WriteLine("I am a new thread");
            Thread.Sleep(1000);
            Console.WriteLine("Thread finished to sleep.");
        }

        static void Main(string[] args)
        {
            Thread th = Thread.CurrentThread;
            th.Name = "This is the Main Thread";
            Console.WriteLine($"Starting new thread...");
            ThreadStart newTh = new ThreadStart(NewThread);
            Thread thread = new Thread(newTh);
            thread.Start();
            Console.WriteLine($"Ending new thread...");
            Console.ReadLine();
        }
    }
}

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_Threads
{
    class Program
    {
        static void CustomThread()
        {
            for (int index = 0; index < 100; index++)
            {
                Console.WriteLine("Thread Process: {0}", index);
                Thread.Sleep(0);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(CustomThread));
            t.Start();
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine("This is the main the main thread !");
                Thread.Sleep(0);
            }
            t.Join();
        }
    }
}

﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];
                new Task(() => results[0] = 0, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2, TaskCreationOptions.AttachedToParent).Start();
                return results;
            });

            var finalTask = parent.ContinueWith(parentTask =>
            {
                foreach (int index in parentTask.Result)
                {
                    Console.WriteLine(index);
                }
            });
            Console.WriteLine("Press any key to finish the program...");
            Console.ReadLine();
        }
    }
}

using System;
using System.Threading;

namespace SecureImage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting...");
            int i = 1;
            while(true)
            {
                Console.WriteLine($"Starting cycle {i}");
                Thread.Sleep(1000);
                Console.WriteLine($"Finished cycle {i}");
                i++;
            }
        }
    }
}

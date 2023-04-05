using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TesteCustoComputacional
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();

            for (int i = 0; i < 10000; i++)
            {
                if (i % 2 == 0)
                {
                    if (i % 4 == 0)
                    {
                        if (i % 8 == 0)
                        {
                            Console.WriteLine($"{i}");
                        }
                    }
                }
            }
            watch.Stop();

            var watch2 = Stopwatch.StartNew();

            for (int j = 0; j < 10000; j++)
            {
                if (j % 2 == 0 && j % 4 == 0 && j % 8 == 0)
                {
                    Console.WriteLine($"{j}");
                }
            }

            watch2.Stop();

            Console.WriteLine($"Tempo de execução: {watch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Tempo de execução: {watch2.ElapsedMilliseconds} ms");
        }
    }
}
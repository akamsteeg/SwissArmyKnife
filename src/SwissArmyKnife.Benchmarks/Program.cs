using Minibench.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissArmyKnife.Benchmarks
{
    class Program
    {
        private static int Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var run = BenchmarkRunner.RunFromCommandLine(typeof(Program).Assembly);
            sw.Stop();

            Console.WriteLine();
            Console.WriteLine("Running all tests took {0} seconds".FormatThis(sw.Elapsed.TotalSeconds));
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();

            return run == null ? 1 : 0;
        }
    }
}

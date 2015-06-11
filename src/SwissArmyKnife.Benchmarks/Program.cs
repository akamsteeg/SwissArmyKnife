using Minibench.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissArmyKnife.Benchmarks
{
    class Program
    {
        private static int Main(string[] args)
        {
            var run = BenchmarkRunner.RunFromCommandLine(typeof(Program).Assembly);
            return run == null ? 1 : 0;
        }
    }
}

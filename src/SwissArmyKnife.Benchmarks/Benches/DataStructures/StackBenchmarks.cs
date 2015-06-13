using Minibench.Framework;
using SwissArmyKnife.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissArmyKnife.Benchmarks.Benches.DataStructures
{
    internal class StackBenchmarks
    {
        [Benchmark]
        public void PushAnItem()
        {
            var stack = new Stack();
            stack.Push("item");
        }

        [Benchmark]
        public void PopAnItem()
        {
            var stack = new Stack();            
            var item = stack.Pop();
        }
    }
}

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
        private readonly Stack _stack;
        protected Stack Stack
        {
            get { return this._stack; }
        }

        public StackBenchmarks()
        {
            this._stack = new Stack();
            this.Stack.Push("root");
        }

        [Benchmark]
        public void PushAnItem()
        {
            this.Stack.Push("item");
        }

        [Benchmark]
        public void PopAnItem()
        {
            var item = this.Stack.Pop();
        }
    }
}

using BenchmarkDotNet.Attributes;
using SwissArmyKnife.DataStructures.CircularBuffer;

namespace SwissArmyKnife.Benchmarks.Benches.DataStructures
{
    public class CircularBufferBenchmarks
    {
        [Benchmark]
        public void Add_50PercentOverfillAndGet()
        {
            var buffer = Create();

            var numberOfItems = buffer.Size * 1.5;

            for (var i = 0; i < numberOfItems; i++)
            {
                buffer.Add(i);
            }

            for (var i = 0; i < buffer.Size; i++)
            {
                buffer.Get();
            }
        }

        private static ICircularBuffer<int> Create()
        {
            const int size = 10;

            var result = new CircularBuffer<int>(size);

            return result;
        }
    }
}

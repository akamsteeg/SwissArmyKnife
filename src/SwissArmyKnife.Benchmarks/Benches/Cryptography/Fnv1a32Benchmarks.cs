using BenchmarkDotNet.Attributes;
using SwissArmyKnife.Cryptography;

namespace SwissArmyKnife.Benchmarks.Benches.Cryptography
{
    public class Fnv1a32Benchmarks
    {
        private Fnv1a32 _hasher;

        public Fnv1a32Benchmarks()
        {
            this._hasher = new Fnv1a32();
        }

        [Benchmark]
        public byte[] Hash()
        {
            var input = new byte[] { 8, 8, 8, 8 };

            var result = this._hasher.ComputeHash(input);

            return result;
        } 
    }
}

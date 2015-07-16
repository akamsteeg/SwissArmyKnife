namespace SwissArmyKnife.Cryptography
{
    /// <summary>
    /// An 32-bits Fowler-Noll-Vo 1a implementation
    /// </summary>
    /// <remarks>
    /// FNV is not intended to be a cryptographically safe
    /// hash function
    /// </remarks>
    public sealed class Fnv1a32 : Fnv1aBase
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Fnv1a32"/>
        /// </summary>
        public Fnv1a32()
            : base(unchecked(2166136261), unchecked(16777619))
        {
            this.HashSizeValue = 32;
        }
    }
}

namespace SwissArmyKnife.Cryptography
{
    /// <summary>
    /// An 64-bits Fowler-Noll-Vo 1a implementation
    /// </summary>
    /// <remarks>
    /// FNV is not intended to be a cryptographically safe
    /// hash function
    /// </remarks>
    public sealed class Fnv1a64 : Fnv1aBase
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Fnv1a32"/>
        /// </summary>
        public Fnv1a64()
            : base(unchecked(14695981039346656037), unchecked(1099511628211))
        {
            this.HashSizeValue = 64;

        }
    }
}
}

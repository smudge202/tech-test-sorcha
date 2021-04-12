namespace Speik.TechnicalTest
{
    public sealed class LotteryOptions
    {
        public const short DefaultMinimum = 1;
        public const short DefaultMaximum = 45;
        
        /// <summary>
        /// Minimum number that can be generated
        /// </summary>
        /// <remarks>Defaults to <see cref="DefaultMinimum"/></remarks>
        public short InclusiveMinimum { get; set; } = DefaultMinimum;

        /// <summary>
        /// Maximum number that can be generated
        /// </summary>
        /// <remarks>Defaults to <see cref="DefaultMaximum"/></remarks>
        public short InclusiveMaximum { get; set; } = DefaultMaximum;
    }
}
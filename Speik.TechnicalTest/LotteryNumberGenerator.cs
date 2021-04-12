using System.Collections.Generic;
using System.Linq;

namespace Speik.TechnicalTest
{
    internal sealed class LotteryNumberGenerator : ILotteryNumberGenerator
    {
        private readonly IRandomNumberGenerator _random;
        private readonly LotteryOptions _options;

        public LotteryNumberGenerator(IRandomNumberGenerator random, LotteryOptions options)
        {
            _random = random;
            _options = options;
        }
        
        public IEnumerable<short> Generate(short count)
        {
            var range = Enumerable.Range(_options.InclusiveMinimum,
                _options.InclusiveMaximum - _options.InclusiveMinimum)
                .Select(x => (short)x)
                .ToList();
            
            for (var i = 0; i < count; i++)
            {
                if (range.Count == 0)
                    yield break;
                var index = _random.GetNumber(range.Count - 1);
                yield return range[index];
                range.RemoveAt(index);
            }
        }
    }
}
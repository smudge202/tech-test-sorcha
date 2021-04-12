using System.Collections.Generic;

namespace Speik.TechnicalTest
{
    public interface ILotteryNumberGenerator
    {
        IEnumerable<short> Generate(short count);
    }
}
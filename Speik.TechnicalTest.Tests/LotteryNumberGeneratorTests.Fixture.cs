using System;
using Microsoft.Extensions.DependencyInjection;

namespace Speik.TechnicalTest.Tests
{
    partial class LotteryNumberGeneratorTests
    {
        private TestContext Fixture { get; } = new();

        private class TestContext
        {
            public short Count => (LotteryOptions.DefaultMaximum - LotteryOptions.DefaultMinimum);
            
            public Func<ILotteryNumberGenerator> Generator { get; }

            public TestContext() => Generator = () => new ServiceCollection()
                .AddLotteryNumberGenerator()
                .BuildServiceProvider()
                .GetRequiredService<ILotteryNumberGenerator>();
        }
    }
}
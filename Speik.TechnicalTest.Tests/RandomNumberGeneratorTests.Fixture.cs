using Microsoft.Extensions.DependencyInjection;

namespace Speik.TechnicalTest.Tests
{
    partial class RandomNumberGeneratorTests
    {
        private TestContext Fixture { get; } = new();

        private class TestContext
        {
            public IRandomNumberGenerator Random { get; }

            public TestContext() => Random = new ServiceCollection()
                .AddLotteryNumberGenerator()
                .BuildServiceProvider()
                .GetRequiredService<IRandomNumberGenerator>();
        }
    }
}
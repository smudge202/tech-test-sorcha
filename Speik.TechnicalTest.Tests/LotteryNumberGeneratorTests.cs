using System.Linq;
using FluentAssertions;
using Xunit;

namespace Speik.TechnicalTest.Tests
{
    public sealed partial class LotteryNumberGeneratorTests
    {
        [Fact]
        public void IsResolvable() => Fixture.Generator
            .Should().NotThrow();

        [Theory]
        [InlineData(1)]
        [InlineData(6)]
        [InlineData(7)]
        public void ReturnsSpecifiedQuantityOfNumbers(short count) => Fixture.Generator()
            .Generate(count)
            .Should().HaveCount(count);

        [Fact]
        public void ReturnsUniqueNumbers() => Fixture.Generator()
            .Generate(Fixture.Count)
            .Should().BeEquivalentTo(Enumerable.Range(LotteryOptions.DefaultMinimum, Fixture.Count));

        [Fact]
        public void YieldBreaksWhenComplete() => Fixture.Generator()
            .Generate(short.MaxValue).ToList()
            .Should().HaveCount(Fixture.Count);
        
        // TODO : override min/max values in options but my hour's up
    }
}
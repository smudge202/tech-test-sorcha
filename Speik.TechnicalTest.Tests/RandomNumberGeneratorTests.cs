using FluentAssertions;
using Xunit;

namespace Speik.TechnicalTest.Tests
{
    public sealed partial class RandomNumberGeneratorTests
    {
        // it's a random number generator so there's no guarantees
        private const int MaxAttempts = 100000000;

#if LONG_RUNNING_TESTS
        [Theory, InlineData(10)]
        public void MinimumIsInclusive(short max)
        {
            var found = false;
            var attempt = 0;
            while (!found && attempt++ < MaxAttempts)
                found = Fixture.Random.GetNumber(max) == 0;
            
            found.Should().BeTrue();
        }
#else
        [Fact(Skip = "Randomly generated sequence can take a long time to confirm")]
        public void MinimumIsInclusive() { }
#endif
        
#if LONG_RUNNING_TESTS
        [Theory, InlineData(45)]
        public void MaximumIsInclusive(short max)
        {
            var found = false;
            var attempt = 0;
            while (!found && attempt++ < MaxAttempts)
                found = Fixture.Random.GetNumber(max) == max;
            found.Should().BeTrue();
        }
#else
        [Fact(Skip = "Randomly generated sequence can take a long time to confirm")]
        public void MaximumIsInclusive() { }
#endif

        [Fact]
        public void ZeroMaximumReturnsZero() => Fixture.Random
            .GetNumber(0)
            .Should().Be(0);
    }
}
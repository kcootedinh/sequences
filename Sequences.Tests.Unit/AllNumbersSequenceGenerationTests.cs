using Sequences.Logic.Generators;
using Shouldly;
using Xunit;

namespace Sequences.Tests.Unit
{
    public class AllNumbersSequenceGeneratorTests
    {
        private readonly AllNumbersSequenceGenerator generator;

        public AllNumbersSequenceGeneratorTests()
        {
            generator = new AllNumbersSequenceGenerator();
        }
        
        [Fact]
        public void Test_AllToPositiveNumber_Success()
        {
            var number = 10;

            var sequence = generator.Generate(number);

            sequence.ShouldBe(new[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"});
        }
    }
}
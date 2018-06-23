using Sequences.Logic.Generators;
using Shouldly;
using Xunit;

namespace Sequences.Tests.Unit
{
    public class EvenNumbersSequenceGeneratorTests
    {
        private readonly EvenNumbersSequenceGenerator generator;

        public EvenNumbersSequenceGeneratorTests()
        {
            generator = new EvenNumbersSequenceGenerator();
        }
        
        [Fact]
        public void Test_AllToPositiveNumber_Success()
        {
            var number = 10;

            var sequence = generator.Generate(number);

            sequence.ShouldBe(new[] {"2", "4", "6", "8", "10"});
        }
    }
}
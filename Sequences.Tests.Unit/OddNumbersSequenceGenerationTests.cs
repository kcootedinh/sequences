using System;
using System.Linq;
using Sequences.Logic.Generators;
using Shouldly;
using Xunit;

namespace Sequences.Tests.Unit
{
    public class OddNumbersSequenceGeneratorTests
    {
        private readonly OddNumbersSequenceGenerator generator;

        public OddNumbersSequenceGeneratorTests()
        {
            generator = new OddNumbersSequenceGenerator();
        }

        [Fact]
        public void Test_AllToPositiveNumber_Success()
        {
            var number = 10;

            var sequence = generator.Generate(number);

            sequence.ShouldBe(new[] {"1", "3", "5", "7", "9"});
        }
        
        [Fact]
        public void NegativeNumber_ShouldThrowArgumentOutOfRange()
        {
            var number = -15;

            Should.Throw<ArgumentOutOfRangeException>(() => generator.Generate(number).ToArray());
        }
    }
}
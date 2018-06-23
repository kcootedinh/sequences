using Sequences.Logic.Generators;
using Shouldly;
using Xunit;

namespace Sequences.Tests.Unit
{
    public class AllExceptMultiplesSequenceGeneratorTests
    {
        private readonly AllExceptMultiplesSequenceGenerator generator;

        public AllExceptMultiplesSequenceGeneratorTests()
        {
            generator = new AllExceptMultiplesSequenceGenerator();
        }
        
        [Fact]
        public void Test_UpTo15_Success()
        {
            var number = 15;

            var result = generator.Generate(number);
            
            result.ShouldBe(new [] { 
                "1", "2", "C", "4", "E", 
                "C", "7", "8", "C", "E", 
                "11", "C", "13", "14", "Z", 
            });
        }
    }
}
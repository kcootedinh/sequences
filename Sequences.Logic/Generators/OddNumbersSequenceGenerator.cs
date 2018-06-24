using System;
using System.Collections.Generic;
using System.Linq;
using Sequences.Logic.Interfaces;

namespace Sequences.Logic.Generators
{
    public class OddNumbersSequenceGenerator: ISequenceGenerator
    {
        public IEnumerable<string> Generate(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException(
                    nameof(number),
                    number,
                    "Number to generate sequence must be positive.");
            
            return Enumerable.Range(1, number)
                             .Where(i => i % 2 == 1)
                             .Select(i => i.ToString());
        }
    }
}
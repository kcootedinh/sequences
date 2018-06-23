using System;
using System.Collections.Generic;
using System.Linq;
using Sequences.Logic.Interfaces;

namespace Sequences.Logic.Generators
{
    public class EvenNumbersSequenceGenerator: ISequenceGenerator
    {
        public IEnumerable<string> Generate(int number)
        {
            if(number < 0) throw new ArgumentOutOfRangeException("number", number, "Number to generate sequence must be positive.");
            
            return Enumerable.Range(1, (int) number)
                             .Where(i => i % 2 == 0)
                             .Select(i => i.ToString());
        }
    }
}
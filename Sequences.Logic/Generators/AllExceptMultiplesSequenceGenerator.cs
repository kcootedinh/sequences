using System;
using System.Collections.Generic;
using System.Linq;
using Sequences.Logic.Interfaces;

namespace Sequences.Logic.Generators
{
    public class AllExceptMultiplesSequenceGenerator : ISequenceGenerator
    {
        public IEnumerable<string> Generate(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException(
                    nameof(number),
                    number,
                    "Number to generate sequence must be positive.");
            
            var sequence = Enumerable.Range(1, number);

            foreach (var i in sequence)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    yield return "Z";
                }
                else if (i % 3 == 0)
                {
                    yield return "C";
                }
                else if (i % 5 == 0)
                {
                    yield return "E";
                }
                else
                {
                    yield return i.ToString();
                }
            }
        }
    }
}
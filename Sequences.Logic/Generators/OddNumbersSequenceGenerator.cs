using System.Collections.Generic;
using System.Linq;
using Sequences.Logic.Interfaces;

namespace Sequences.Logic.Generators
{
    public class OddNumbersSequenceGenerator: ISequenceGenerator
    {
        public IEnumerable<string> Generate(int number)
        {
            return Enumerable.Range(1, (int) number)
                             .Where(i => i % 2 == 1)
                             .Select(i => i.ToString());
        }
    }
}
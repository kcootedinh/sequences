using System.Collections.Generic;
using System.Linq;
using Sequences.Logic.Interfaces;

namespace Sequences.Logic.Generators
{
    public class AllNumbersSequenceGenerator: ISequenceGenerator
    {
        public IEnumerable<string> Generate(int number)
        {
            return Enumerable.Range(1, (int) number)
                             .Select(i => i.ToString());
        }
    }
}
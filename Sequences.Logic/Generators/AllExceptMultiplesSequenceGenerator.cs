using System.Collections.Generic;
using System.Linq;
using Sequences.Logic.Interfaces;

namespace Sequences.Logic.Generators
{
    public class AllExceptMultiplesSequenceGenerator : ISequenceGenerator
    {
        public IEnumerable<string> Generate(int number)
        {
            var sequence = Enumerable.Range(1, (int) number);

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
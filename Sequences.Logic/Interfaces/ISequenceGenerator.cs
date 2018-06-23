using System.Collections.Generic;

namespace Sequences.Logic.Interfaces
{
    public interface ISequenceGenerator
    {
        IEnumerable<int> Generate(uint number);
    }
}
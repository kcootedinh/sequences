﻿using System.Collections.Generic;

namespace Sequences.Logic.Interfaces
{
    public interface ISequenceGenerator
    {
        IEnumerable<string> Generate(int number);
    }
}
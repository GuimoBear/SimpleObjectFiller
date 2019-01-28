using System;

namespace SimpleObjectFiller.Generators.Contracts
{
    internal interface IBaseGenerator
    {
        Type GeneratedType { get; }
        object Randomize();
    }
}

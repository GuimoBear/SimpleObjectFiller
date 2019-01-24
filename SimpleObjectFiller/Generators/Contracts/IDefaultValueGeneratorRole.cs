using System;

namespace SimpleObjectFiller.Generators.Contracts
{
    /// <summary>
    /// This role represents the default value that will be created when the Generate() method is called
    /// </summary>
    public interface IDefaultValueGeneratorRole<T>
    {
        T DefaultValue { get; set; }
    }
}

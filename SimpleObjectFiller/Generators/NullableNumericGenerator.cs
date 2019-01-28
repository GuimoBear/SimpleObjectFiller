using SimpleObjectFiller.Generators.Contracts;
using System;

namespace SimpleObjectFiller.Generators
{
    public abstract class NullableNumericGenerator<T> : NullableBaseGenerator<T>, IValueRangeGeneratorRole<T>
        where T : struct
    {
        public T MinValue { get; set; }
        public T MaxValue { get; set; }
    }
}

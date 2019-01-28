using SimpleObjectFiller.Generators.Contracts;

namespace SimpleObjectFiller.Generators
{
    public abstract class NumericGenerator<T> : BaseGenerator<T>, IValueRangeGeneratorRole<T>
        where T : struct
    {
        public T MinValue { get; set; }
        public T MaxValue { get; set; }
    }
}

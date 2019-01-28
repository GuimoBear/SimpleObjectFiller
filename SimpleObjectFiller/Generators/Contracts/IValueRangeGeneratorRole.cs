namespace SimpleObjectFiller.Generators.Contracts
{
    public interface IValueRangeGeneratorRole<T>
        where T: struct
    {
        T MinValue { get; set; }
        T MaxValue { get; set; }
    }
}

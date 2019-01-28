namespace SimpleObjectFiller.Generators.Primitives
{
    public class ULongGenerator : NumericGenerator<ulong>
    {
        public ULongGenerator()
        {
            MinValue = ushort.MinValue;
            MaxValue = ushort.MaxValue;
        }

        protected override ulong Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            return (ushort)random.NextULong(MinValue, MaxValue);
        }
    }
}

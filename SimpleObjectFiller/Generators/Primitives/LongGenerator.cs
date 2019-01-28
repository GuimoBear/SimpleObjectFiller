namespace SimpleObjectFiller.Generators.Primitives
{
    public class LongGenerator : NumericGenerator<long>
    {
        public LongGenerator()
        {
            MinValue = long.MinValue;
            MaxValue = long.MaxValue;
        }

        protected override long Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            return random.NextLong(MinValue, MaxValue);
        }
    }
}

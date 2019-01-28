namespace SimpleObjectFiller.Generators.Primitives.Nullables
{
    public class NullableLongGenerator : NullableNumericGenerator<long>
    {
        public NullableLongGenerator()
        {
            MinValue = long.MinValue;
            MaxValue = long.MaxValue;
        }

        protected override long? Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            if (NullWeight.HasValue && NullWeight.Value > random.NextDouble())
                return null;
            int tempIntValue = random.Next();
            if (tempIntValue % 3 == 0)
                return null;
            return random.NextLong(MinValue, MaxValue);
        }
    }
}

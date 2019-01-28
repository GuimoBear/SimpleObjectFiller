namespace SimpleObjectFiller.Generators.Primitives.Nullables
{
    public class NullableULongGenerator : NullableNumericGenerator<ulong>
    {
        public NullableULongGenerator()
        {
            MinValue = ulong.MinValue;
            MaxValue = ulong.MaxValue;
        }

        protected override ulong? Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            if (NullWeight.HasValue && NullWeight.Value > random.NextDouble())
                return null;
            int tempIntValue = random.Next();
            if (tempIntValue % 3 == 0)
                return null;
            return random.NextULong(MinValue, MaxValue);
        }
    }
}

namespace SimpleObjectFiller.Generators.Primitives.Nullables
{
    public class NullableDecimalGenerator : NullableNumericGenerator<decimal>
    {
        public NullableDecimalGenerator()
        {
            MinValue = decimal.MinValue;
            MaxValue = decimal.MaxValue;
        }

        protected override decimal? Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            if (NullWeight.HasValue && NullWeight.Value > random.NextDouble())
                return null;
            int tempIntValue = random.Next();
            if (tempIntValue % 3 == 0)
                return null;
            return random.NextDecimal(MinValue, MaxValue);
        }
    }
}

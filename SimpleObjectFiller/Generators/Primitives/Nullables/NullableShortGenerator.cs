namespace SimpleObjectFiller.Generators.Primitives.Nullables
{
    public class NullableShortGenerator : NullableNumericGenerator<short>
    {
        public NullableShortGenerator()
        {
            MinValue = short.MinValue;
            MaxValue = short.MaxValue;
        }

        protected override short? Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            if (NullWeight.HasValue && NullWeight.Value > random.NextDouble())
                return null;
            int tempIntValue = random.Next();
            if (tempIntValue % 3 == 0)
                return null;
            return (short)random.Next(MinValue, MaxValue);
        }
    }
}

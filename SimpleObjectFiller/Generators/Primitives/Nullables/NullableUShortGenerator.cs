namespace SimpleObjectFiller.Generators.Primitives.Nullables
{
    public class NullableUShortGenerator : NullableNumericGenerator<ushort>
    {
        public NullableUShortGenerator()
        {
            MinValue = ushort.MinValue;
            MaxValue = ushort.MaxValue;
        }

        protected override ushort? Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            if (NullWeight.HasValue && NullWeight.Value > random.NextDouble())
                return null;
            int tempIntValue = random.Next();
            if (tempIntValue % 3 == 0)
                return null;
            return (ushort)random.Next(MinValue, MaxValue);
        }
    }
}

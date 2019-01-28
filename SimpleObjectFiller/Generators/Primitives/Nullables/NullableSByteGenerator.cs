namespace SimpleObjectFiller.Generators.Primitives.Nullables
{
    public class NullableSByteGenerator : NullableNumericGenerator<sbyte>
    {
        public NullableSByteGenerator()
        {
            MinValue = sbyte.MinValue;
            MaxValue = sbyte.MaxValue;
        }

        protected override sbyte? Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            if (NullWeight.HasValue && NullWeight.Value > random.NextDouble())
                return null;
            int tempIntValue = random.Next();
            if (tempIntValue % 3 == 0)
                return null;
            return (sbyte)random.Next(MinValue, MaxValue);
        }
    }
}

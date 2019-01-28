namespace SimpleObjectFiller.Generators.Primitives.Nullables
{
    public class NullableByteGenerator : NullableNumericGenerator<byte>
    {
        public NullableByteGenerator()
        {
            MinValue = byte.MinValue;
            MaxValue = byte.MaxValue;
        }

        protected override byte? Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            if (NullWeight.HasValue && NullWeight.Value > random.NextDouble())
                return null;
            int tempIntValue = random.Next();
            if (tempIntValue % 3 == 0)
                return null;
            return (byte)random.Next(MinValue, MaxValue);
        }
    }
}

namespace SimpleObjectFiller.Generators.Primitives
{
    public class ByteGenerator : NumericGenerator<byte>
    {
        public ByteGenerator()
        {
            MinValue = byte.MinValue;
            MaxValue = byte.MaxValue;
        }

        protected override byte Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            return (byte)random.Next(MinValue, MaxValue);
        }
    }
}

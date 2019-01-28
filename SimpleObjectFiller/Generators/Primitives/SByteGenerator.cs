namespace SimpleObjectFiller.Generators.Primitives
{
    public class SByteGenerator : NumericGenerator<sbyte>
    {
        public SByteGenerator()
        {
            MinValue = sbyte.MinValue;
            MaxValue = sbyte.MaxValue;
        }

        protected override sbyte Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            return (sbyte)random.Next(MinValue, MaxValue);
        }
    }
}

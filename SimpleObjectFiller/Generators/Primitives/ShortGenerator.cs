namespace SimpleObjectFiller.Generators.Primitives
{
    public class ShortGenerator : NumericGenerator<short>
    {
        public ShortGenerator()
        {
            MinValue = short.MinValue;
            MaxValue = short.MaxValue;
        }

        protected override short Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            return (short)random.Next(MinValue, MaxValue);
        }
    }
}

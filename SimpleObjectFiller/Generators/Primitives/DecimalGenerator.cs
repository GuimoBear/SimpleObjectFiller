namespace SimpleObjectFiller.Generators.Primitives
{
    public class DecimalGenerator : NumericGenerator<decimal>
    {
        public DecimalGenerator()
        {
            MinValue = decimal.MinValue;
            MaxValue = decimal.MaxValue;
        }

        protected override decimal Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            return random.NextDecimal(MinValue, MaxValue);
        }
    }
}

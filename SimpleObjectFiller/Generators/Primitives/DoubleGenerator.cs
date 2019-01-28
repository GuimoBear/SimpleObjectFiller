namespace SimpleObjectFiller.Generators.Primitives
{
    public class DoubleGenerator : NumericGenerator<double>
    {
        public DoubleGenerator()
        {
            MinValue = double.MinValue;
            MaxValue = double.MaxValue;
        }

        protected override double Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            return (ushort)random.NextDouble(MinValue, MaxValue);
        }
    }
}

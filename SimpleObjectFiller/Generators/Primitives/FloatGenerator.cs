namespace SimpleObjectFiller.Generators.Primitives
{
    public class FloatGenerator : NumericGenerator<float>
    {
        public FloatGenerator()
        {
            MinValue = float.MinValue;
            MaxValue = float.MaxValue;
        }

        protected override float Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            return (float)random.NextDouble(MinValue, MaxValue);
        }
    }
}

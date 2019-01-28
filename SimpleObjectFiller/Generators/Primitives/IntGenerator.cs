namespace SimpleObjectFiller.Generators.Primitives
{
    public class IntGenerator : NumericGenerator<int>
    {
        public IntGenerator()
        {
            MinValue = int.MinValue;
            MaxValue = int.MaxValue;
        }

        protected override int Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            return random.Next(MinValue, MaxValue);
        }
    }
}

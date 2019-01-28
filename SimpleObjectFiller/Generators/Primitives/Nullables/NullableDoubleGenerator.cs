namespace SimpleObjectFiller.Generators.Primitives.Nullables
{
    class NullableDoubleGenerator : NullableNumericGenerator<double>
    {
        public NullableDoubleGenerator()
        {
            MinValue = double.MinValue;
            MaxValue = double.MaxValue;
        }

        protected override double? Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            if (NullWeight.HasValue && NullWeight.Value > random.NextDouble())
                return null;
            int tempIntValue = random.Next();
            if (tempIntValue % 3 == 0)
                return null;
            return random.NextDouble(MinValue, MaxValue);
        }
    }
}

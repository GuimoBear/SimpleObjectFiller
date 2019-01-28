namespace SimpleObjectFiller.Generators.Primitives.Nullables
{
    public class NullableFloatGenerator : NullableNumericGenerator<float>
    {
        public NullableFloatGenerator()
        {
            MinValue = float.MinValue;
            MaxValue = float.MaxValue;
        }

        protected override float? Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            if (NullWeight.HasValue && NullWeight.Value > random.NextDouble())
                return null;
            int tempIntValue = random.Next();
            if (tempIntValue % 3 == 0)
                return null;
            return (float)random.NextDouble(MinValue, MaxValue);
        }
    }
}

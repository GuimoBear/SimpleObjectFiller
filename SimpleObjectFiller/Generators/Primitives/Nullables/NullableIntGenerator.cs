namespace SimpleObjectFiller.Generators.Primitives.Nullables
{
    public class NullableIntGenerator : NullableNumericGenerator<int>
    {
        public NullableIntGenerator()
        {
            MinValue = int.MinValue;
            MaxValue = int.MaxValue;
        }

        protected override int? Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            if (NullWeight.HasValue && NullWeight.Value > random.NextDouble())
                return null;
            int tempIntValue = random.Next();
            if (tempIntValue % 3 == 0)
                return null;
            return random.Next(MinValue, MaxValue);
        }
    }
}

namespace SimpleObjectFiller.Generators.Primitives
{
    class UShortGenerator : NumericGenerator<ushort>
    {
        public UShortGenerator()
        {
            MinValue = ushort.MinValue;
            MaxValue = ushort.MaxValue;
        }

        protected override ushort Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            return (ushort)random.Next(MinValue, MaxValue);
        }
    }
}

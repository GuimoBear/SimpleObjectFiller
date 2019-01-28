using System;

namespace SimpleObjectFiller.Generators.Primitives
{
    public class UIntGenerator : NumericGenerator<uint>
    {
        public UIntGenerator()
        {
            MinValue = uint.MinValue;
            MaxValue = uint.MaxValue;
        }

        protected override uint Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            return (uint)random.NextULong(MinValue, MaxValue);
        }
    }
}

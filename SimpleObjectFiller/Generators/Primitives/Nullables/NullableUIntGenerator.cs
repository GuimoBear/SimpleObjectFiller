using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleObjectFiller.Generators.Primitives.Nullables
{
    public class NullableUIntGenerator : NullableNumericGenerator<uint>
    {
        public NullableUIntGenerator()
        {
            MinValue = uint.MinValue;
            MaxValue = uint.MaxValue;
        }

        protected override uint? Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            if (NullWeight.HasValue && NullWeight.Value > random.NextDouble())
                return null;
            int tempIntValue = random.Next();
            if (tempIntValue % 3 == 0)
                return null;
            return (uint)random.NextULong(MinValue, MaxValue);
        }
    }
}

using System;

namespace SimpleObjectFiller.Generators.Primitives.Nullables
{
    public class NullableBoolGenerator : NullableBaseGenerator<bool>
    {
        private double? trueWeight;
        public virtual double? TrueWeight
        {
            get => trueWeight;
            set
            {
                if (value.HasValue && (value.Value < 0 || value.Value >= 1))
                    throw new ArgumentException("The TrueWeight must be greater than or equal to 0 and less than 1");
                trueWeight = value;
            }
        }

        protected override bool? Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            if (TrueWeight.HasValue)
            {
                bool isLessThanOrEqualTheTrueWeight = random.NextDouble() <= TrueWeight.Value;
                if (!isLessThanOrEqualTheTrueWeight)
                {
                    if (NullWeight.HasValue && random.NextDouble() <= NullWeight.Value)
                        return null;
                    else if (NullWeight.HasValue)
                        return false;
                    else
                        return random.Next() % 2 == 0 ? null : (bool?)false;
                }
                return true;
            }
            return random.Next() % 2 == 0;
        }
    }
}

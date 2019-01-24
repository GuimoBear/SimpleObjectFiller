using SimpleObjectFiller.Generators.Contracts;
using System;

namespace SimpleObjectFiller.Generators
{
    public abstract class NullableBaseGenerator<T> : BaseGenerator<T?>, INullWeightGeneratorRole
        where T : struct
    {
        private double? nullWeight;

        public virtual double? NullWeight
        {
            get => nullWeight;
            set
            {
                if (value.HasValue && (value.Value < 0 || value.Value >= 1))
                    throw new ArgumentException("The NullWeight must be greater than or equal to 0 and less than 1");
                nullWeight = value;
            }
        }
    }
}

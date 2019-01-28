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
                    throw new ArgumentException("The TrueWeight must be greater than or equal to 0.0 and less than 1.0");
                trueWeight = value;
            }
        }

        protected override bool? Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            var tempRndValue = random.NextDouble();
            if (TrueWeight.HasValue && NullWeight.HasValue)
            {
                var tempTrueWeight = TrueWeight.Value;
                var tempNullWeight = NullWeight.Value + tempTrueWeight;
                if (tempRndValue <= tempTrueWeight)
                    return true;
                if (tempRndValue <= tempNullWeight)
                    return null;
                return false;
            }
            int tempIntValue = random.Next();
            bool isEven = tempIntValue % 2 == 0;
            if (TrueWeight.HasValue)
            {
                if (tempRndValue <= TrueWeight.Value)
                    return true;
                return isEven ? null : (bool?)false;
            }
            if(NullWeight.HasValue)
            {
                if (tempRndValue <= NullWeight.Value)
                    return null;
                return isEven ? true : false;
            }
            switch(tempIntValue % 3)
            {
                case (0):
                    return null;
                case (1):
                    return true;
                case (2):
                    return false;
            }
            return true;
        }
    }
}

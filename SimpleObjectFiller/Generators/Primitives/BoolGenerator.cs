using SimpleObjectFiller.Generators.Contracts;

namespace SimpleObjectFiller.Generators.Primitives
{

    public class BoolGenerator : BaseGenerator<bool>, ITrueWeightBoolGeneratorRole
    {
        public double? TrueWeight { get; set; }

        protected override bool Generate()
        {
            if (hasDefaultValue)
                return DefaultValue;
            if(TrueWeight.HasValue)
                return random.NextDouble() <= TrueWeight.Value;
            return random.Next() % 2 == 0;
        }
    }
}

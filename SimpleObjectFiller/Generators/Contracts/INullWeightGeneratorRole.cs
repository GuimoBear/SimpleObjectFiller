﻿namespace SimpleObjectFiller.Generators.Contracts
{
    /// <summary>
    /// this role represents the probability(greater than or equal to 0.0 and less than 1.0) of chance of the generator returns a null value
    /// </summary>
    public interface INullWeightGeneratorRole
    {
        double? NullWeight { get; set; }
    }
}

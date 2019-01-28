using SimpleObjectFiller.Generators.Contracts;
using System;

namespace SimpleObjectFiller.Generators
{
    public abstract class BaseGenerator<TType> : IBaseGenerator, IDefaultValueGeneratorRole<TType>
    {
        protected static readonly Random random = new Random(247558);

        public Type GeneratedType => typeof(TType);

        protected bool hasDefaultValue;
        private TType defaultValue;
        /// <summary>
        /// value that will be returned by the Generate() method
        /// </summary>
        public TType DefaultValue
        {
            get => defaultValue;
            set
            {
                hasDefaultValue = true;
                defaultValue = value;
            }
        }

        protected abstract TType Generate();

        public object Randomize()
        {
            return Generate();
        }
    }
}

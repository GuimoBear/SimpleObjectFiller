using System;
using System.Security.Cryptography;

namespace SimpleObjectFiller.Generators
{
    public class RandomGenerator
    {
        Random random = new Random();

        public int Next()
            => random.Next();

        public int Next(int low, int hi)
            => random.Next(low, hi);

        public long NextLong()
            => NextLong(long.MinValue, long.MaxValue);

        public ulong NextULong(ulong low, ulong hi)
        {
            if (low >= hi)
                throw new ArgumentException("low must be < hi");
            byte[] buf = new byte[8];
            double num;

            //Generate a random double
            random.NextBytes(buf);
            num = Math.Abs(BitConverter.ToDouble(buf, 0));

            //We only use the decimal portion
            num = num - Math.Truncate(num);

            //Return a number within range
            return (ulong)(num * (hi - low) + low);
        }

        public ulong NextULong()
            => NextULong(ulong.MinValue, ulong.MaxValue);

        public long NextLong(long low, long hi)
        {
            if (low >= hi)
                throw new ArgumentException("low must be < hi");
            byte[] buf = new byte[8];
            double num;

            //Generate a random double
            random.NextBytes(buf);
            num = Math.Abs(BitConverter.ToDouble(buf, 0));

            //We only use the decimal portion
            num = num - Math.Truncate(num);
            //Return a number within range
            return (long)(num * (hi - low) + low);
        }

        public double NextDouble()
            => random.NextDouble();

        public double NextDouble(double low, double hi)
        {
            if (low >= hi)
                throw new ArgumentException("low must be < hi");
            byte[] buf = new byte[8];
            double num;

            //Generate a random double
            random.NextBytes(buf);
            num = Math.Abs(BitConverter.ToDouble(buf, 0));

            //We only use the decimal portion
            num = num - Math.Truncate(num);

            //Return a number within range
            return num * (hi - low) + low;
        }

        public decimal NextDecimal()
            => NextDecimal(decimal.MinValue, decimal.MaxValue);

        public decimal NextDecimal(decimal low, decimal hi)
        {
            if (low >= hi)
                throw new ArgumentException("low must be < hi");

            //Generate a random double
            var num = new decimal(random.NextDouble());

            //Return a number within range
            return (num * (hi - low) + low);
        }
    }
}

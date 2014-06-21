using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace AccountPresentationSystem.Infrastructure
{
    public class ReferenceGenerator
    {
        public string GenerateReference()
        {
            return RandomProvider.GetThreadRandom().NextDouble().ToString("0.000000").Substring(2, 6);
        }

        #region helpers
        private static class RandomProvider
        {
            private static int seed = Environment.TickCount;

            private static ThreadLocal<Random> randomWrapper = new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref seed)));

            public static Random GetThreadRandom()
            {
                return randomWrapper.Value;
            }
        }

        #endregion
    }
}
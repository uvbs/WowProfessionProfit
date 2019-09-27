using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WowProfitCalcProfessions.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Add<T>(this IEnumerable<T> e, T value)
        {
            foreach (var cur in e)
            {
                yield return cur;
            }
            yield return value;
        }
    }
}

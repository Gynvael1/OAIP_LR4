using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОАИП_ЛР4_Малых
{
    public interface IStrategy
    {
        int[] Algorithm(int[] array, Action<string> updateAction, out int comparisons, out int permutations);
    }
}

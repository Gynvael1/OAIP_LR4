using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОАИП_ЛР4_Малых
{
    public class SortResult
    {
        public int Comparisons { get; }
        public int Permutations { get; }
        public long TimeMs { get; }

        public SortResult(int comp, int perm, long time)
        {
            Comparisons = comp;
            Permutations = perm;
            TimeMs = time;
        }
    }
}

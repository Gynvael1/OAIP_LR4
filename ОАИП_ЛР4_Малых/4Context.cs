using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОАИП_ЛР4_Малых
{
    public class Context
    {
        public IStrategy Strategy { get; set; }
        public int[] Array { get; set; }

        public Context(IStrategy strategy)
        {
            Strategy = strategy;
        }

        public void Execute(Action<string> updateAction, out int comparisons, out int permutations)
        {
            Array = Strategy.Algorithm(Array, updateAction, out comparisons, out permutations);
        }
    }
}

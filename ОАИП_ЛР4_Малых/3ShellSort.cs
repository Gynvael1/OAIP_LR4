using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОАИП_ЛР4_Малых
{
    public class ShellSort : IStrategy
    {
        public int[] Algorithm(int[] array, Action<string> updateAction, out int comparisons, out int permutations)
        {
            comparisons = 0;
            permutations = 0;
            int iteration = 0;
            int d = array.Length / 2;

            while (d >= 1)
            {
                updateAction?.Invoke($"\nРасстояние между элементами: {d}");
                for (var i = d; i < array.Length; i++)
                {
                    int j = i;
                    while (j >= d && array[j - d] > array[j])
                    {
                        iteration++;
                        updateAction?.Invoke($"Итерация {iteration}\nСравниваем [{array[j - d]}] и [{array[j]}]");
                        comparisons++;

                        permutations++;
                        int temp = array[j];
                        array[j] = array[j - d];
                        array[j - d] = temp;
                        j -= d;

                        updateAction?.Invoke($"Перестановка [{temp}] и [{array[j]}]\n{GetArrayState(array, j, j + d)}");
                    }
                }
                d /= 2;
            }
            return array;
        }

        private string GetArrayState(int[] arr, int idx1 = -1, int idx2 = -1)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == idx1 || i == idx2)
                    sb.Append($"[{arr[i]}] ");
                else
                    sb.Append($"{arr[i]} ");
            }
            return "Текущий массив: " + sb.ToString().Trim();
        }
    }
}

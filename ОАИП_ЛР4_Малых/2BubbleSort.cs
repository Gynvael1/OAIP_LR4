using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОАИП_ЛР4_Малых
{
    public class BubbleSort : IStrategy
    {
        public int[] Algorithm(int[] array, Action<string> updateAction, out int comparisons, out int permutations)
        {
            comparisons = 0;
            permutations = 0;
            int iteration = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool swapped = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    iteration++;
                    updateAction?.Invoke($"Итерация {iteration}\nСравниваем [{array[j]}] и [{array[j + 1]}]");
                    comparisons++;

                    if (array[j] > array[j + 1])
                    {
                        permutations++;
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;

                        updateAction?.Invoke($"Перестановка [{temp}] и [{array[j]}]\n{GetArrayState(array, j, j + 1)}");
                    }
                }
                if (!swapped) break;
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
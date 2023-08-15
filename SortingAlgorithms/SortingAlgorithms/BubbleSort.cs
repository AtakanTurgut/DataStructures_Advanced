using SortingAlgorithms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class BubbleSort
    {
        /// <summary>
        /// Time Complexity : O(n^2)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++) 
            {
                for(int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)      // 1
                    {
                        Sorting.Swap<T>(array, j, j + 1);
                    }
                }
            }
        }

        public static void Sort<T>(T[] array,
            SortDirection sortDirection = SortDirection.Ascending) where T : IComparable
        {
            var comparer = new Shared.CustomComparer<T>(sortDirection, Comparer<T>.Default);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (comparer.Compare(array[j + 1], array[j]) < 0)   
                    {
                        Sorting.Swap<T>(array, j, j + 1);
                    }
                }
            }
        }
    }
}

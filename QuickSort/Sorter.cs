using System;

// ReSharper disable InconsistentNaming
namespace QuickSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with quick sort algorithm.
        /// </summary>
        public static void QuickSort(this int[]? array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            RecursiveQuickSort(array);
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive quick sort algorithm.
        /// </summary>
        public static void RecursiveQuickSort(this int[]? array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            RQuickSort(array, 0, array.Length - 1);
        }

        public static void RQuickSort(this int[]? array, int start, int end)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (start < end)
            {
                int index = start;
                for (int i = start; i <= end; i++)
                {
                    if (array[i] <= array[end])
                    {
                        int temp = array[index];
                        array[index] = array[i];
                        array[i] = temp;
                        index += 1;
                    }
                }

                index -= 1;
                RQuickSort(array, start, index - 1);
                RQuickSort(array, index + 1, end);
            }
        }
    }
}

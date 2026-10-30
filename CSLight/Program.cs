using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 2, 1 };
            int[] secondArray = { 3, 2 };
            List<int> mergedArray = MergeArrays(firstArray, secondArray);
            ShowList(mergedArray);
        }

        private static void ShowList(List<int> mergedArray)
        {
            foreach (int item in mergedArray)
            {
                Console.Write(item + " ");
            }
        }

        private static List<int> MergeArrays(int[] firstArray, int[] secondArray)
        {
            List<int> mergedArray = new List<int>();

            AddElements(mergedArray, firstArray);
            AddElements(mergedArray, secondArray);

            return mergedArray;
        }

        private static void AddElements(List<int> mergedArray, int[] array)
        {
            foreach (int element in array)
            {
                if (mergedArray.Contains(element) == false)
                {
                    mergedArray.Add(element);
                }
            }

        }
    }
}

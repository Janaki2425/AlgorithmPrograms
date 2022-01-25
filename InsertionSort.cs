using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    internal class InsertionSort
    {
        public void insertionsort()
        {
            int[] arr = { 10, 2, 14, 3, 1, 5, 9 };
            for (int i = 1; i < arr.Length; i++)
            {
                int k = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > k)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = k;
            }
        
        
            Console.WriteLine(" Sorted array for insertion is : ");
            foreach (int p in arr)
            {
                Console.WriteLine(p + "");
            }
        }
        
    }
}

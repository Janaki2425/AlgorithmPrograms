using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    internal class Bubblesort
    {
        public static void bubblesort()
        {
            int[] arr = { 12, 23, 55, 6, 78 };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i < arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;

                    }
                }
            }
            Console.WriteLine("Bubble Sorted array:");
            foreach (int p in arr)
            {
                Console.WriteLine(p + "");
            }
        }
    }
}
        
    


    


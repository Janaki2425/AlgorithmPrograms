using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    internal class PrimeRange
    {
        int end = 1000, count = 0;
        public void FindPrime()
        {
            Console.WriteLine("Prime numbers between 0 to 1000 are: ");
           
            for (int i = 1; i < end; i++)
            {
                for (int j = 1; j < end; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                   
                    Console.WriteLine(i+" ");
                   
                }
                count = 0;
                
               
            }
        }
    }
}

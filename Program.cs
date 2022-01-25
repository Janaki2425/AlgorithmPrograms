using System;
namespace AlgorithmProgram
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Anagram anagrm = new Anagram();
            Anagram.anagram();
            Bubblesort bubble = new Bubblesort();
            Bubblesort.bubblesort();
           /* BinarySearch<string> binarySearch = new BinarySearch<string>();
            string txtpath = File.ReadAllText(@"C:/Users/91936/Binary.txt");
            BinarySearch search = new BinarySearch();
            List<string> words = new List<string>(txtpath.Split(" "));
            BinarySearch.BinarySearchWord(words);
            words.Sort();*/
            InsertionSort Insertionsort = new InsertionSort();
            Insertionsort.insertionsort();
            int[] arr2 = { 32, 12, 9, 65, 24, 5 };
            MergeSort mergeSort = new MergeSort();
            MergeSort.Sort(arr2, 0, arr2.Length - 1);
            PrimeRange primeRange = new PrimeRange();
            primeRange.FindPrime();
            ExtendPrime extendPrime = new ExtendPrime();
            Console.WriteLine("Enter First number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int res1 = ExtendPrime.FindPrime(num1);
            int res2 = ExtendPrime.FindPrime(num2);
            bool palindromes = ExtendPrime.IsPalindrome(num1);
            bool anagramRes = ExtendPrime.FindAnagram(Convert.ToString(num1), Convert.ToString(num2));
            if (palindromes)
            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is not a palindrome");
            }
            if (anagramRes)
            {
                Console.WriteLine("both values are anagrams");

            }
            else
            {
                Console.WriteLine("both the values are not anagrams");
            }



        }
    }
}
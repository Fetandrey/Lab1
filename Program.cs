using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Shift");
            Console.WriteLine("2. Pairs");
            int decision = Convert.ToInt32(Console.ReadLine());
            switch(decision)
            {
                case 1:
                    Shift();
                    break;
                case 2:
                    Pairs();
                    break;
                default:
                    break;
            }
        }
        private static void Shift()
        {
            Console.Write("Set the number of elements in the array:\nN = ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = FillArray(N);
            Console.Write("Set shift:\nK = ");
            int K = Convert.ToInt32(Console.ReadLine());
            Console.Write("Before: ");
            PrintArray(A);
            int[] B = ChangeArray(A, K);
            Console.Write("After:  ");
            PrintArray(B);
            Console.ReadLine();
        }
        private static void Pairs()
        {
            bool valid = false;
            int N = 0;
            while(!valid)
            {
                Console.Write("Set the number of elements in the array. IT MUST BE ODD:\nN = ");
                N = Convert.ToInt32(Console.ReadLine());
                if(N%2 == 0)
                {
                    Console.Clear();
                    Console.WriteLine("This number is even. Please try again!");
                }
                else
                valid = true;
            }
            Console.WriteLine("Fill the array with pairs of numbers. One number leave without a pair.");
            int[] A = FillArray(N);
            Console.WriteLine("Number without pair is {0}", FindNumber(A));
            Console.ReadLine();
        }
        private static int[] ChangeArray(int[] initialArray, int shift)
        {
            int N = initialArray.Length;
            int[] changedArray = new int[N];
            for (int i = 0; i < N; i++)
                changedArray[(i + shift) % N] = initialArray[i];
            return changedArray;
        }
        private static int FindNumber(int[] array)
        {
            int N = array.Length;
            Dictionary<int, int> matches = new Dictionary<int, int>();
            int i = 0;
            for (i = 0; i < N; i++)
            {
                if (!matches.ContainsKey(array[i]))
                {
                    matches[array[i]] = 1;
                }
                else
                {
                    int value = Convert.ToInt32(matches[array[i]]);
                    value++;
                    matches[array[i]] = value;
                }
            }
            int result = 0;
            foreach (int key in matches.Keys)
            {
                //Console.WriteLine("Key = " + key + "\tValue = " + matches[key]);
                if (matches[key] % 2 != 0)
                {
                    result = key;
                    break;
                }
            }
            return result;
        }
        private static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array[i]);
            Console.WriteLine();
        }
        private static int[] FillArray(int length)
        {
            int[] array = new int[length];
            int i = 0;
            Console.WriteLine("Fill the array of {0} elements with integers (whole numbers). "+ 
            "Separate each number by space or by pressing \"Enter\":", length);
            while(i < length)
            {
                string currentLine = Console.ReadLine();
                string[] numbers = currentLine.Split(' ');
                for(int j = 0; j < numbers.Length; j++)
                {
                    array[i] = Convert.ToInt32(numbers[j]);
                    i++;
                }
            }
            return array;
        }
    }
}

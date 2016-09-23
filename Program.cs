using System;

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
            int[] B = new int[N];
            for(int i = 0; i < N; i++)
                B[(i+K)%N] = A[i];
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
            int[] matches = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int i = 0;
            for(i = 0; i < N; i++)
            {
                matches[A[i]]++;
            }
            valid = false;
            i = 0;
            while(!valid)
            {
                if(matches[i]%2 != 0)
                    valid = true;
                i++;
            }
            Console.WriteLine("Number without pair is {0}", i-1);
            Console.ReadLine();
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

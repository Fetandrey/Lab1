using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Shift();
        }
        private static void Shift()
        {
            Console.WriteLine("Set the number of elements in the array:\nN=");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[N];
            int i = 0;
            Console.WriteLine("Fill the array of {0} elements with integers (whole numbers). "+ 
            "Separate each number by whitespace or by pressing \"Enter\":", N);
            while(i < N)
            {
                string currentLine = Console.ReadLine();
                string[] numbers = currentLine.Split(' ');
                for(int j = 0; j < numbers.Length; j++)
                {
                    A[i] = Convert.ToInt32(numbers[j]);
                    i++;
                }
            }
            Console.WriteLine("Set shift:\nK");
            int K = Convert.ToInt32(Console.ReadLine());
            Console.Write("Before: ");
            PrintArray(A);
            int[] B = new int[N];
            for(i = 0; i < N; i++)
                B[(i+K)%N] = A[i];
            PrintArray(B);
            Console.ReadLine();
        }
        private static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
                Console.Write("{0}; ", array[i]);
            Console.WriteLine();
        }
    }
}

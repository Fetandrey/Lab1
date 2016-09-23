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
            int desicion = Convert.ToInt32(Console.ReadLine());
            switch(desicion)
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
            Console.WriteLine("Shift chosen");
            Console.ReadLine();
        }
        private static void Pairs()
        {
            Console.WriteLine("Pairs chosen");
            Console.ReadLine();
        }
    }
}

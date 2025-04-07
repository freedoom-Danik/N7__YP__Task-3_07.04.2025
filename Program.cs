using System.Numerics;

namespace N7__YP__Task_3_07._04._2025
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("input Text ");
            string input = Console.ReadLine();

            int count = 0;
            foreach (char c in input) 
            {
                if (c == '.' || c == '!' || c== '?') count++;
            }
            Console.Write($"Count string: {count}");       
        }
    }
}

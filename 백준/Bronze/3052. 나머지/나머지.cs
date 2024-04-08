using System;
using System.Threading.Channels;

namespace CodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] B = new int[10];
            Dictionary<int, int> D = new Dictionary<int, int>();

            for (int i = 0; i < 10; i++) 
            {
                B[i] = int.Parse(Console.ReadLine());
                int C = B[i] % 42;
                if (!D.ContainsKey(C))
                {
                    D.Add(C, 1);
                }
            }

            Console.WriteLine(D.Count);
        }
    }
}

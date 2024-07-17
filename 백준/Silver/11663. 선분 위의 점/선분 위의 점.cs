using System.Text;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            int[] dots = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(dots);

            for (int i = 0; i < M; ++i)
            {
                string[] line = Console.ReadLine().Split();
                int start = int.Parse(line[0]);
                int end = int.Parse(line[1]);

                int startIndex = LowerBound(dots, start);
                int endIndex = UpperBound(dots, end);

                sb.AppendLine((endIndex - startIndex).ToString());
            }

            Console.WriteLine(sb);
        }// main

        //주어진 값보다 크거나 같은 첫 번째 인덱스를 찾습니다.
        static int LowerBound(int[] array, int value)
        {
            int low = 0;
            int high = array.Length;

            while (low < high)
            {
                int mid = (low + high) / 2;
                if (array[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }

            return low;
        }

        //주어진 값보다 큰 첫 번째 인덱스를 찾습니다.
        static int UpperBound(int[] array, int value)
        {
            int low = 0;
            int high = array.Length;

            while (low < high)
            {
                int mid = (low + high) / 2;
                if (array[mid] <= value)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }

            return low;
        }

    }
}
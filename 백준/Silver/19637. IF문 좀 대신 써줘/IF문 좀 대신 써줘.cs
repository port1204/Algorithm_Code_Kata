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
            Dictionary<int, string> map = new Dictionary<int, string>();
            for (int i = 0; i < N; ++i)
            {
                string[] a = Console.ReadLine().Split();
                if (!map.ContainsKey(int.Parse(a[1])))
                {
                    map.Add(int.Parse(a[1]), a[0]);
                }
            }

            List<int> list = new List<int>(map.Keys);
            list.Sort();

            for (int i = 0; i < M; ++i)
            {
                int s = int.Parse(Console.ReadLine());

                int low = 0;
                int high = list.Count - 1;
                int answer = 0;
                while (low <= high)
                {
                    int mid = (low + high) / 2;

                    if (s <= list[mid])
                    {
                        answer = mid;
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }

                sb.AppendLine(map[list[answer]]);
            }

            Console.WriteLine(sb);

        }// main
    }
}
using System.Text;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                StringBuilder sb = new StringBuilder();
                int N = int.Parse(sr.ReadLine());
                int[] nums = new int[N];
                int sum = 0;
                for (int i = 0; i < N; ++i)
                {
                    int input = int.Parse(sr.ReadLine());
                    sum += input;
                    nums[i] = input;
                }
                Array.Sort(nums);
                double average = (double)sum / N;
                int roundedAverage = (int)Math.Round(average, MidpointRounding.AwayFromZero);
                sb.AppendLine($"{roundedAverage}");
                sb.AppendLine($"{nums[N / 2]}");
                Dictionary<int, int> frequency = new Dictionary<int, int>();
                foreach (int num in nums)
                {
                    if (frequency.ContainsKey(num))
                    {
                        frequency[num]++;
                    }
                    else
                    {
                        frequency[num] = 1;
                    }
                }
                int maxFrequency = frequency.Values.Max();
                var modeCandidates = frequency.Where(x => x.Value == maxFrequency).Select(x => x.Key).ToList();
                modeCandidates.Sort();
                int mode = (modeCandidates.Count > 1) ? modeCandidates[1] : modeCandidates[0];
                sb.AppendLine($"{mode}");
                sb.AppendLine($"{nums[N - 1] - (nums[0])}");
                sw.WriteLine(sb);
            }
        }
    }
}
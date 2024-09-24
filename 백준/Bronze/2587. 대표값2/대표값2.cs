namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            { 
                int[] nums = new int[5];
                int answer = 0;
                for (int i = 0; i < 5; ++i)
                {
                    nums[i] = int.Parse(sr.ReadLine());
                    answer += nums[i];
                }
                Array.Sort(nums);
                sw.WriteLine(answer / 5);
                sw.WriteLine(nums[2]);
            }
        }


    }
}
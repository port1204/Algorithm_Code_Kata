namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int A = int.Parse(sr.ReadLine());
                int B = int.Parse(sr.ReadLine());
                int C = int.Parse(sr.ReadLine());

                int D = A * B * C;

                int[] nums = new int[10];

                foreach (char c in D.ToString())
                {
                    ++nums[c - '0'];
                }

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(nums[i]);
                }
            }
        }

    }
}

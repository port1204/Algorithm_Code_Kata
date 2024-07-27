namespace testcoding
{
    internal class Program
    {
         static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int N = int.Parse(sr.ReadLine());
                int[] nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int count = 0;
                for (int i = 0; i < N; ++i)
                {
                    if (IsPrime(nums[i]))
                    {
                        ++count;
                    }
                }

                sw.WriteLine(count);

            }
        }

    }
}

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                long K = long.Parse(sr.ReadLine());
                sw.WriteLine(FindKthCharacter(K));
            }
        }

        static int FindKthCharacter(long k)
        {
            k--;

            int flipCount = 0;
            while (k > 0)
            {
                if ((k & 1) == 1)
                    flipCount++;
                k >>= 1;
            }

            return flipCount % 2;
        }

    }
}
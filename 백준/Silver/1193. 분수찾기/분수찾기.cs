namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int X = int.Parse(sr.ReadLine());
                int k = 1;
                while (X > (k * (k + 1)) / 2)
                {
                    ++k;
                }
                int a = (k - 1) * k / 2;
                int b = X - a;
                int aa, bb;
                if (k % 2 == 1)
                {
                    aa = b;
                    bb = k + 1 - b;
                }
                else
                {
                    aa = k + 1 - b;
                    bb = b;
                }
                sw.WriteLine($"{bb}/{aa}");
            }
        }

    }
}
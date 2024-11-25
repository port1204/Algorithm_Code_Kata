namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                long size = long.Parse(sr.ReadLine());
                long count = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] <= 0)
                    {
                        continue;
                    }

                    if (input[i] <= size)
                    {
                        ++count;
                    }
                    else
                    {
                        if (input[i] % size == 0)
                        {
                            count += input[i] / size;
                        }
                        else
                        {
                            count += (input[i] / size) + 1;
                        }
                    }
                }
                sw.WriteLine(count * size);
            } // using
        } // Main
    } // class
} // namespace

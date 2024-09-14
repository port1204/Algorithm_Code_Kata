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
                int[] ints = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int v = int.Parse(sr.ReadLine());
                int count = 0;
                foreach (int i in ints)
                {
                    if (i == v)
                    {
                        ++count;
                    }
                }
                sw.WriteLine(count);

            }
        }


    }
}
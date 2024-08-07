namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int N = int.Parse(sr.ReadLine());
                string[] input1 = sr.ReadLine().Split();
                HashSet<string> hash = new HashSet<string>(input1);
                int M = int.Parse(sr.ReadLine());
                string[] input2 = sr.ReadLine().Split();

                foreach (string input in input2)
                {
                    if (hash.Contains(input))
                    {
                        sw.WriteLine(1);
                    }
                    else
                    {
                        sw.WriteLine(0);
                    }
                }

            }
        }
    }
}
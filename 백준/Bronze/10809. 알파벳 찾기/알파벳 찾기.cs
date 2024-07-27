namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                string S = sr.ReadLine();

                int[] a = new int[26];
                for (int i = 0; i < 26; i++)
                {
                    a[i] = -1;
                }

                int count = 0;
                foreach (char c in S)
                {
                    int i = c - 'a';

                    if (a[i] == -1)
                    {
                        a[i] = count;
                    }

                    ++count;
                }

                sw.WriteLine(string.Join(" ", a));
            }
        }

    }
}

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string input = sr.ReadLine();
                char[] c = input.ToCharArray();
                int sum = 0;
                for (int i = 0; i < c.Length; ++i)
                {
                    int num = int.Parse(c[i].ToString());
                    if (num == 1 && (i + 1) < c.Length && int.Parse(c[i + 1].ToString()) == 0)
                    {
                        sum += 9;
                    }
                    sum += num;
                }
                sw.WriteLine(sum);

            } // using
        } // Main
    } // class
} // ns

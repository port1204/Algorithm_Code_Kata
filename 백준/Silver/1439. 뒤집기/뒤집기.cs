namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string S = sr.ReadLine();
                char[] C = S.ToCharArray();
                int a = 0, b = 0;

                if (C[0] == '0')
                {
                    ++a;
                }
                else
                {
                    ++b;
                }

                for (int i = 1; i < C.Length; ++i)
                {
                    if (C[i] != C[i - 1])
                    {
                        if (C[i] == '0')
                        {
                            ++a;
                        }
                        else
                        {
                            ++b;
                        }
                    }
                }

                 sw.WriteLine(Math.Min(a, b));
                
            }
        }
    }
}
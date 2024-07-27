namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int[] T = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                string answer = "";

                if (T[0] == 1)
                {
                    for (int i = 0; i < 8; ++i)
                    {
                        if (T[i] == i + 1)
                        {
                            answer = "ascending";
                        }
                        else
                        {
                            answer = "mixed";
                            break;
                        }
                    }
                }
                else if (T[0] == 8)
                {
                    for (int i = 0; i < 8; ++i)
                    {
                        if (T[i] == 8 - i)
                        {
                            answer = "descending";
                        }
                        else
                        {
                            answer = "mixed";
                            break;
                        }
                    }
                }
                else
                {
                    answer = "mixed";
                }

                sw.WriteLine(answer);
            }
        }

    }
}

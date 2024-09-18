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
                bool isCheck = false;
                int count = 0;
                for (int i = 0; i < N; ++i)
                {
                    string input = sr.ReadLine();
                    HashSet<char> hs = new HashSet<char>();
                    hs.Add(input[0]);
                    isCheck = false;
                    for (int j = 1; j < input.Length; ++j)
                    {
                        if (input[j - 1] != input[j])
                        {
                            if (hs.Contains(input[j]))
                            {
                                isCheck = true;
                                break;
                            }
                            else
                            {
                                hs.Add(input[j]);
                            }
                        }
                    }

                    if (!isCheck)
                    {
                        ++count;
                    }
                }
                sw.WriteLine(count);
            }
        }


    }
}
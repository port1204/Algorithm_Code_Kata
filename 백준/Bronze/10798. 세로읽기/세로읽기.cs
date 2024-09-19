namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string answer = "";
                char[,] ch = new char[5, 15];
                for (int i = 0; i < 5; ++i)
                {
                    string input = sr.ReadLine();
                    for (int j = 0; j < input.Length; ++j)
                    {
                        ch[i, j] = input[j];
                    }

                    if (i == 4)
                    {
                        for (int j = 0; j < 15; ++j)
                        {
                            for (int k = 0; k < 5; ++k)
                            {
                                if (ch[k, j] == '\0')
                                    continue;
                                answer += ch[k, j];
                            }
                        }
                    }
                }
                sw.WriteLine(answer);   

            }
        }


    }
}
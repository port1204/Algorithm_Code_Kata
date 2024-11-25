namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int T = int.Parse(sr.ReadLine());
                for (int i = 0; i < T; i++)
                {
                    string input = sr.ReadLine();
                    int a = int.Parse(input);
                    char[] chars = input.ToCharArray();
                    Array.Reverse(chars);
                    input = new string(chars);
                    int b = int.Parse(input);
                    int sum = a + b;
                    input = sum.ToString();
                    bool isSame = true;
                    for (int  j = 0; j < input.Length / 2; j++)
                    {
                        if (input[j] != input[input.Length - (j + 1)])
                        {
                            isSame = false;
                            break;
                        }
                    }

                    if (isSame)
                    {
                        sw.WriteLine("YES");
                    }
                    else
                    {
                        sw.WriteLine("NO");
                    }
                }
            } // using
        } // Main
    } // class
} // namespace

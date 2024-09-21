namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string[] input = sr.ReadLine().Split();
                string N = input[0];
                int B = int.Parse(input[1]);
                long answer = 0;
                long position = 1;
                for (int i = N.Length - 1; i >= 0; i--)
                {
                    char c = N[i];
                    int num = 0;
                    if (c <= '9')
                    {
                        num = c - '0';
                    }
                    else
                    {
                        num = c - 'A' + 10;
                    }
                    answer += num * position;
                    position *= B; 
                }
                sw.WriteLine(answer);
            }
        }


    }
}
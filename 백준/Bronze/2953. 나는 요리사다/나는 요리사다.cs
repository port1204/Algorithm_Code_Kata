namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int curret = 0;
                int max = 0;
                for (int i = 0; i < 5; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    int sum = 0;
                    for (int j = 0; j < input.Length; ++j)
                    {
                        sum += int.Parse(input[j]);    
                    }

                    if (max < sum)
                    {
                        max = sum;
                        curret = i;
                    }
                }
                sw.WriteLine($"{curret + 1} {max}");


            }
        }


    }
}
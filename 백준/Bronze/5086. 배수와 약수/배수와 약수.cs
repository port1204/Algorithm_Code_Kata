namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                while (true)
                {
                    string[] input = sr.ReadLine().Split();
                    int A = int.Parse(input[0]);
                    int B = int.Parse(input[1]);
                    if (A == 0 && B == 0)
                        break;

                    if (B % A == 0)
                    {
                        sw.WriteLine("factor");
                    }
                    else if (A % B == 0)
                    {
                        sw.WriteLine("multiple");
                    }
                    else
                    {
                        sw.WriteLine("neither");
                    }
                }
            }
        }


    }
}
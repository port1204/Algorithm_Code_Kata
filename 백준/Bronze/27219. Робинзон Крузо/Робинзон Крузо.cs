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
                int a = N / 5;
                int b = N % 5;
                string answer = "";

                for (int i = 0; i < a; i++)
                {
                    answer += "V";
                }

                for (int i = 0;i < b; i++)
                {
                    answer += "I";
                }

                sw.WriteLine(answer);
            } // using
        } // Main
    } // class
} // namespace
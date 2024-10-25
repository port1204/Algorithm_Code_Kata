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
                int cute = 0;
                int Ncute = 0;
                for (int i = 0; i < N; ++i)
                {
                    string input = sr.ReadLine();
                    if (input == "1")
                    {
                        ++cute;
                    }
                    else
                    {
                        ++Ncute;
                    }
                }

                if (cute > Ncute)
                {
                    sw.WriteLine("Junhee is cute!");
                }
                else
                {
                    sw.WriteLine("Junhee is not cute!");
                }
            }
        }


    }
}
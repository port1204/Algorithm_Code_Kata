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
                int money = 0;
                for (int i = 0; i < N; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    int r = int.Parse(input[0]);
                    int e = int.Parse(input[1]);
                    int c = int.Parse(input[2]);

                    if (r < e - c)
                    {
                        sw.WriteLine("advertise");
                    }
                    else if (r > e - c)
                    {
                        sw.WriteLine("do not advertise");
                    }
                    else if (r == e - c)
                    {
                        sw.WriteLine("does not matter");
                    }



                }

            } // using
        } // Main


    }
}
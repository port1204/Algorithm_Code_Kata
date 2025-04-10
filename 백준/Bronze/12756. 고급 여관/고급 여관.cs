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
                int Aatk = int.Parse(input[0]);
                int AHP = int.Parse(input[1]);
                input = sr.ReadLine().Split();
                int Batk = int.Parse(input[0]);
                int BHP = int.Parse(input[1]);

                while(AHP > 0 && BHP > 0)
                {
                    AHP -= Batk;
                    BHP -= Aatk;

                    if (AHP <= 0 && BHP <= 0)
                    {
                        sw.WriteLine("DRAW");
                    }
                    else if (AHP <= 0)
                    {
                        sw.WriteLine("PLAYER B");
                    }
                    else if (BHP <= 0)
                    {
                        sw.WriteLine("PLAYER A");
                    }
                }

            } // using
        } // Main
    } // class
} // namespace
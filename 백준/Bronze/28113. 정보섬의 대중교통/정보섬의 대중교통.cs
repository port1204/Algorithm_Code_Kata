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
                int N = int.Parse(input[0]);
                int A = int.Parse(input[1]);
                int B = int.Parse(input[2]);

                if (A == B)
                {
                    sw.WriteLine("Anything");
                }
                else if (A > B)
                {
                    sw.WriteLine("Subway");
                }
                else
                {
                    sw.WriteLine("Bus");
                }


            } // using
        } // Main
    } // class
} // namespace
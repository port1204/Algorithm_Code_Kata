namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int a = int.Parse(sr.ReadLine());
                int b = int.Parse(sr.ReadLine());

                if (a > b)
                {
                    sw.WriteLine(24 + b - a);
                }
                else
                {
                    sw.WriteLine(b - a);
                }


            } // using
        } // Main
    } // class
} // namespace
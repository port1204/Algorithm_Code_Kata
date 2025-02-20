namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string input = sr.ReadLine();

                char[] c = input.ToCharArray();
                if (c[0] == c[1])
                {
                    sw.WriteLine("1");
                }
                else
                {
                    sw.WriteLine("0");
                }


            } // using
        } // Main
    } // class
} // namespace
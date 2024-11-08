namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string[] A = sr.ReadLine().Split();
                long A1 = long.Parse(A[0]);
                long A2 = long.Parse(A[1]);
                long chicken = long.Parse(sr.ReadLine());

                if (A1 + A2 >= chicken * 2)
                {
                    sw.WriteLine(A1 + A2 - (chicken * 2));
                }
                else
                {
                    sw.WriteLine(A1 + A2);
                }



            } // using
        } // Main
    } // class
} // ns

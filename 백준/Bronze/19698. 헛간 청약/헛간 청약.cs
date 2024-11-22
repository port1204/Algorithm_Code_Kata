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
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);
                int C = int.Parse(input[2]);
                int D = int.Parse(input[3]);

                int place = (B / D)  * (C / D);
                if (A <= place)
                {
                    place = A;
                }
                sw.WriteLine(place);
            }
        }
    }
}

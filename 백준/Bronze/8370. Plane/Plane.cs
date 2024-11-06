namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int[] place = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                sw.WriteLine((place[0] * place[1]) + (place[2] * place[3]));

            } // using
        } // Main


    }
}
namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int T = int.Parse(sr.ReadLine());
                for (int i = 0; i < T; ++i)
                {
                    string[] input= sr.ReadLine().Split();
                    float A = float.Parse(input[0]);
                    for (int j = 1; j < input.Length; ++j)
                    {
                        if (input[j] == "@")
                        {
                            A *= 3;
                        }
                        else if (input[j] == "%")
                        {
                            A += 5;
                        }
                        else if (input[j] == "#") 
                        {
                            A -= 7;
                        }
                    }
                    sw.WriteLine(string.Format(A.ToString("0.00")));
                }
                
            } // using
        } // Main


    }
}
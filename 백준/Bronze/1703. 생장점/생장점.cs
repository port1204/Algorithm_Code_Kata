namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                while (true)
                {
                    string line = sr.ReadLine();
                    if (line == "0")
                    {
                        break;
                    }

                    int[] input = Array.ConvertAll(line.Split(), int.Parse);
                    int a = input[0];
                    int index = 1;
                    int leaves = 1;

                    for (int i = 0; i < a; i++)
                    {
                        int s = input[index++];
                        int p = input[index++]; 
                        leaves = (leaves * s) - p; 
                    }

                    sw.WriteLine(leaves);
                }
            } // using
        } // Main
    } // class
} // namespace
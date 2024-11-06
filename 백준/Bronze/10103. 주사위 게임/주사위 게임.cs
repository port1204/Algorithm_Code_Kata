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
                int A = 100;
                int B = 100;
                for (int i = 0; i < N; ++i)
                {
                    int[] Dice = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                    if (Dice[0] < Dice[1])
                    {
                        A -= Dice[1];
                    }
                    else if (Dice[0] > Dice[1])
                    {
                        B -= Dice[0];
                    }
                }
                sw.WriteLine(A);
                sw.WriteLine(B);

            } // using
        } // Main


    }
}
namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int answer = 0;
                string[] input = sr.ReadLine().Split();
                int A = int.Parse(input[0]); 
                int B = int.Parse(input[1]); 
                int C = int.Parse(input[2]); 
                int X = int.Parse(input[3]); 
                int Y = int.Parse(input[4]); 
                if (X < Y)
                {
                    int temp = X;
                    X = Y;
                    Y = temp;

                    temp = A;
                    A = B;
                    B = temp;
                }

                if (C * (Y * 2) <  (A * Y) + (B * Y))
                {
                    answer += C * (Y * 2);
                }
                else
                {
                    answer += (A * Y) + (B * Y);
                }

                X -= Y;

                if (X != 0)
                {
                    if (A < C * 2)
                    {
                        answer += A * X;
                    }
                    else
                    {
                        answer += (C * 2) * X;
                    }
                }

                sw.WriteLine(answer);
            } // using
        } // Main
    } // class
} // namespace
namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                string[] input = sr.ReadLine().Split();
                int N = int.Parse(input[0]);
                int X = int.Parse(input[1]);

                int[] A = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                List<string> answer = new List<string>();
                for (int i = 0; i < N; ++i)
                {
                    if ( X > A[i])
                        answer.Add(A[i].ToString());
                }

                sw.WriteLine(string.Join(" ", answer));
            }
        }//main
    }
}
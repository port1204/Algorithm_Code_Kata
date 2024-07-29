namespace testcoding
{
    internal class Program
    {

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int N = int.Parse(sr.ReadLine());

                int count = 0;
                int check = 7;

                if (N == 1)
                {
                    count = 1;
                }
                else
                {
                    count = 2;
                }

                while (N > check)
                {
                    ++count;
                    check += (6*(count-1));
                }

                Console.WriteLine(count);

            }
        }

    }
}

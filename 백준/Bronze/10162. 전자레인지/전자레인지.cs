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
                int[] count = new int[3];
                if (T % 10 != 0)
                {
                    sw.WriteLine("-1");
                }
                else
                {
                    while (T > 0)
                    {
                        if (T >= 300)
                        {
                            T -= 300;
                            ++count[0];
                        }
                        else if (T >= 60)
                        {
                            T -= 60;
                            ++count[1];
                        }
                        else if (T >= 10)
                        {
                            T -= 10;
                            ++count[2];
                        }
                    }
                    sw.WriteLine(string.Join(" ", count));
                }
            }
        }
    }
}
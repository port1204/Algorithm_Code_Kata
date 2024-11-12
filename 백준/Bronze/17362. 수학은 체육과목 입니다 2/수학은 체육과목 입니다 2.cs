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
                int count = 0;
                if (N < 6)
                {
                    sw.WriteLine(N);
                }
                else
                {
                    while(N >= 6)
                    {
                        N -= 4;
                        ++count;
                    }

                    if (count % 2 != 0)
                    {
                        if (N == 1)
                        {
                            sw.WriteLine(5);
                        }
                        else if (N == 2)
                        {
                            sw.WriteLine(4);
                        }
                        else if (N == 3)
                        {
                            sw.WriteLine(3);
                        }
                        else if(N == 4)
                        {
                            sw.WriteLine(2);
                        }
                        else if(N == 5)
                        {
                            sw.WriteLine(1);
                        }
                    }
                    else 
                    {
                        sw.WriteLine(N);
                    }
                }

            } // using
        } // Main
    } // class
} // ns

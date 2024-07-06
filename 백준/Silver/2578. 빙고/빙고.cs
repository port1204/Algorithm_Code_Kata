namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] map = new int[5, 5];
            int count = 0;
            for (int i = 0; i < 5; ++i)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 
                for (int j = 0; j < 5;  ++j)
                {
                    map[i, j] = input[j];
                }
            }

            while (!BingGo())
            {
                int[] q = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int k = 0; k < q.Length; ++k)
                {
                    ++count;
                    for (int i = 0; i < 5; ++i)
                    {
                        for (int j = 0; j < 5; ++j)
                        {
                            if (map[i, j] == q[k])
                            {
                                map[i, j] = 0;
                                break;
                            }
                        }
                    }
                    if (BingGo()) break;
                }
            }

            bool BingGo() 
            {
                int line = 0;
                for (int i = 0; i < 5; ++i)
                {
                    if (map[i, 0] == 0 && map[i, 1] == 0 && map[i, 2] == 0 && map[i, 3] == 0 && map[i, 4] == 0)
                        ++line;
                }

                for (int i = 0; i < 5; ++i)
                {
                    if (map[0, i] == 0 && map[1, i] == 0 && map[2, i] == 0 && map[3, i] == 0 && map[4, i] == 0)
                        ++line;
                }

                if (map[0,0] == 0 && map[1, 1] == 0 && map[2, 2] == 0 && map[3, 3] == 0 && map[4, 4] == 0 )
                    ++line;

                if (map[0, 4] == 0 && map[1, 3] == 0 && map[2, 2] == 0 && map[3, 1] == 0 && map[4, 0] == 0)
                    ++line;


                return line >= 3;
            }

            Console.WriteLine(count);
        }
    }
}
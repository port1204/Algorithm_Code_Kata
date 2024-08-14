namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string[] input = sr.ReadLine().Split();
                int N = int.Parse(input[0]);
                int X = int.Parse(input[1]);

                int[] arrayA = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                Dictionary<int, int> dic = new Dictionary<int, int>();
                List<int> list = new List<int>();
                int count = 0;
                int max = 0;

                for (int i = 0; i < N; ++i)
                {
                    int num = arrayA[i];

                    if (dic.ContainsKey(num))
                    {
                        ++dic[num];
                    }
                    else
                    {
                        dic[num] = 1;
                    }

                    while (dic[num] > X) // 앞에서 부터 한칸씩 지우면서 중복이하 만들기
                    {
                        int leftNum = arrayA[count];
                        --dic[leftNum];

                        if (dic[leftNum] == 0)
                        {
                            dic.Remove(leftNum);
                        }
                        ++count;
                    }

                    max = Math.Max(max, i - count + 1);

                }

                sw.WriteLine(max);

            }
        }

    }
}
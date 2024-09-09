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
                Dictionary<string, string> dic = new Dictionary<string, string>();
                for (int i = 0; i < N; i++)
                {
                    string[] input = sr.ReadLine().Split();
                    dic[input[0]] = input[1];
                }

                List<string> answer = new List<string>();
                foreach (string s in dic.Keys)
                {
                    if (dic[s] == "enter")
                    {
                        answer.Add(s);
                    }
                }

                answer.Sort();
                answer.Reverse();

                foreach (string s in answer)
                {
                    sw.WriteLine(s);
                }

            }
        }


    }
}
namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                List<int> list1 = new List<int>();
                List<int> list2 = new List<int>();
                int score = 0;
                for (int i = 0; i < 4; i++)
                {
                    score = int.Parse(sr.ReadLine());
                    list1.Add(score);
                }
                list1.Sort();

                for (int i = 0; i < 2; i++)
                {
                    score = int.Parse(sr.ReadLine());
                    list2.Add(score);
                }
                list2.Sort();

                int sum = list1[1] + list1[2] + list1[3] + list2[1];
                sw.WriteLine(sum);


            } // using
        } // Main
    } // class
} // ns

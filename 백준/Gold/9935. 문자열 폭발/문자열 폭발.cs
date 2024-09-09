namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string input = sr.ReadLine();
                string word = sr.ReadLine();

                List<char> result = new List<char>();

                foreach (char c in input)
                {
                    result.Add(c);  
                    
                    if (result.Count >= word.Length)
                    {
                        bool isBoom = true;
                        for (int i = 0; i < word.Length; ++i)
                        {
                            if (result[result.Count - word.Length + i] != word[i])
                            {
                                isBoom = false; 
                                break;
                            }
                        }

                        if (isBoom)
                        {
                            result.RemoveRange(result.Count - word.Length, word.Length);
                        }
                    }
                }

                if (result.Count == 0)
                {
                    sw.WriteLine("FRULA");
                }
                else
                {
                    sw.WriteLine(new string(result.ToArray()));
                }


            }
        }

    }
}
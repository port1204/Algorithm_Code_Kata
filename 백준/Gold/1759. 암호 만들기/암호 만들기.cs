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
                int M = int.Parse(input[1]);
                char[] chars = sr.ReadLine().Split().Select(char.Parse).ToArray();
                Array.Sort(chars);
                com(chars, "", 0, N, sw);
            }
        }

        static void com(char[] chars, string co, int start, int length, StreamWriter sw)
        {
            if (co.Length == length)
            {
                int vow = co.Count(c => "aeiou".Contains(c));
                int con = co.Length - vow;

                if (vow >= 1 && con >= 2)
                {
                    sw.WriteLine(co);
                }

                return;
            }

            for (int i = start; i < chars.Length; ++i)
            {
                com(chars, co + chars[i], i + 1, length, sw);
            }
        }
    }
}
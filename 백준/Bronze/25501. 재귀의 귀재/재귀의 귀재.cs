using System.Linq;

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

                int Recursion(string s, int left, int right)
                {
                    ++count;
                    if (left >= right)
                        return 1;
                    else if (s[left] != s[right])
                        return 0;
                    else
                        return Recursion(s, left + 1, right - 1);
                }

                int IsPalindrome(string s)
                {
                    count = 0;
                    return Recursion(s, 0, s.Length - 1);
                }

                for (int i = 0; i < N; ++i)
                {
                    string S = sr.ReadLine();
                    int result = IsPalindrome(S);
                    sw.WriteLine($"{result} {count}");
                }

            }
        }

    }
}
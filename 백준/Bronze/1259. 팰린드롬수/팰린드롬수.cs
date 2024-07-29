using System.ComponentModel;
using System.Text;

namespace testcoding
{
    internal class Program
    {

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                string answer = "";

                while (true)
                {
                    string input = sr.ReadLine();
                    if (input == "0") break;

                    char[] ma = input.ToCharArray();
                    char[] copy = new char[ma.Length];

                    for (int i = 0; i < ma.Length; i++)
                    {
                        copy[i] = ma[i];
                    }

                    Array.Reverse(copy);

                    for (int i = 0; i < ma.Length; i++)
                    {
                        if (copy[i] != ma[i])
                        {
                            answer = "no";
                            break;
                        }
                        else
                        {
                            answer = "yes";
                        }
                    }

                    sw.WriteLine(answer);
                }

            }
        }

    }
}

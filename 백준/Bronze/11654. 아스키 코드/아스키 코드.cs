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
                string code = sr.ReadLine();

                foreach (char c in code)
                {
                    int ascii = (int)c;
                    sw.WriteLine(ascii);
                }
            }
        }

    }
}

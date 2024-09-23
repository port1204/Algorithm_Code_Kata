using System.Text;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            { 
                List<string> Xlist = new List<string>();
                List<string> Ylist = new List<string>();
                for (int i = 0; i < 3; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    if (!Xlist.Contains(input[0]))
                    {
                        Xlist.Add(input[0]);
                    }
                    else
                    {
                        Xlist.Remove(input[0]);
                    }

                    if (!Ylist.Contains(input[1]))
                    {
                        Ylist.Add(input[1]);
                    }
                    else
                    {
                        Ylist.Remove(input[1]);
                    }
                }
                Xlist.Add(Ylist[0]);
                sw.WriteLine(string.Join(" ", Xlist));
            }
        }


    }
}
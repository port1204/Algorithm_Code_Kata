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
                string[] input = sr.ReadLine().Split(); 
                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);
                int w = int.Parse(input[2]);
                int h = int.Parse(input[3]);

                int Xdistance = Math.Min(x, w - x);
                int Ydistance = Math.Min(y, h - y);
                sw.WriteLine(Math.Min(Xdistance, Ydistance));
            }
        }


    }
}
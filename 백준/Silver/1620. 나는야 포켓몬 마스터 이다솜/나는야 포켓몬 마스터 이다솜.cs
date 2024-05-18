using System.Text;
using System.Xml.Linq;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); 
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            Dictionary<string, string> Dict = new Dictionary<string, string>();
            Dictionary<string, string> RDict = new Dictionary<string, string>();
            for (int i = 1; i <= N; ++i)
            {
                string name = Console.ReadLine();
                Dict.Add(i.ToString(), name);
                RDict.Add(name, i.ToString());
            }

            for (int i = 0;i < M; ++i)
            {
                string Q = Console.ReadLine();
                if (Dict.ContainsKey(Q))
                {
                    sb.AppendLine(Dict[Q]);
                }
                else if (RDict.ContainsKey(Q))
                {
                    sb.AppendLine(RDict[Q]);
                }
            }

            Console.Clear();
            Console.WriteLine(sb.ToString());

        }//main
    }
}
using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());
            if (N % 2 == 0)
                sb.AppendLine("CY");
            else
                sb.AppendLine("SK");
            Console.Clear();
            Console.WriteLine(sb);

        }//main
    }
}
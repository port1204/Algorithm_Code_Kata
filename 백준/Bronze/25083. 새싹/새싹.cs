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
                sw.WriteLine("         ,r'\"7");
                sw.WriteLine("r`-_   ,'  ,/");
                sw.WriteLine(" \\. \". L_r'");
                sw.WriteLine("   `~\\/");
                sw.WriteLine("      |");
                sw.WriteLine("      |");
            }
        }

    }
}

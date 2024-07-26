namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                sw.WriteLine("|\\_/|");
                sw.WriteLine("|q p|   /}");
                sw.WriteLine("( 0 )\"\"\"\\");
                sw.WriteLine("|\"^\"`    |");
                sw.WriteLine("||_/=\\\\__|");
            }
        }//main
    }
}
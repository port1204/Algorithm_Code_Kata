namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                sw.WriteLine("\\    /\\");
                sw.WriteLine(" )  ( ')");
                sw.WriteLine("(  /  )");
                sw.WriteLine(" \\(__)|");
            }
        }//main
    }
}
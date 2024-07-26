namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            //using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                string line;
                while ((line = Console.ReadLine()) != null)
                {
                    string[] input = line.Split();
                    if (input == null)
                        break;

                    int A = int.Parse(input[0]);
                    int B = int.Parse(input[1]);

                    Console.WriteLine(A + B);
                }
            }
        }
    }
}

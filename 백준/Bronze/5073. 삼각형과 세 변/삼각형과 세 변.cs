namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            { 
                while (true)
                {
                    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                    Array.Sort(input);

                    if (input[0] == 0 && input[1] == 0 && input[2] == 0)
                    {
                        break;
                    }


                    if (input[0] + input[1] <= input[2])
                    {
                        sw.WriteLine("Invalid");
                    }
                    else if (input[0] == input[1] && input[1] == input[2] && input[2] == input[0])
                    {
                        sw.WriteLine("Equilateral");
                    }
                    else if (input[0] == input[1] || input[0] == input[2] || input[1] == input[2])
                    {
                        sw.WriteLine("Isosceles");
                    }
                    else
                    {
                        sw.WriteLine("Scalene");
                    }
                }

            }
        }


    }
}
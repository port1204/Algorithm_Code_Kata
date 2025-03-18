namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string input = "";
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    input += line;
                }

                int sum = 0;
                string[] nums = input.Split(',');

                foreach (string num in nums)
                {
                    sum += int.Parse(num);
                }

                sw.WriteLine(sum);

            } // using
        } // Main
    } // class
} // namespace
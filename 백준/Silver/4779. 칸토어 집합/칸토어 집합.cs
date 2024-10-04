namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string input;
                while ((input = sr.ReadLine()) != null)
                {
                    int N = int.Parse(input);
                    int l = (int)Math.Pow(3, N);
                    char[] answer = new char[l];

                    for (int i = 0; i < l; ++i)
                    {
                        answer[i] = '-';
                    }

                    Cantor(answer, 0, l);
                    sw.WriteLine(new string(answer));
                }
            }
        }

        static void Cantor(char[] arr, int start, int length)
        {
            if (length == 1)
            {
                return;
            }

            int segmentLength = length / 3;

            for (int i = start + segmentLength; i < start + 2 * segmentLength; ++i)
            {
                arr[i] = ' ';
            }

            Cantor(arr, start, segmentLength);
            Cantor(arr, start + 2 * segmentLength, segmentLength);
        }
    }
}
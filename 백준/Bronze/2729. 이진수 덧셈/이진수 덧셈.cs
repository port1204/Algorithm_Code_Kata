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
                int T = int.Parse(sr.ReadLine());
                for (int i = 0; i < T; i++)
                {
                    string[] input = sr.ReadLine().Split();
                    string a = input[0];
                    string b = input[1];

                    sw.WriteLine(AddBinary(a, b));
                }
            } // using
        } // Main

        static string AddBinary(string a, string b)
        {
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            StringBuilder sb = new StringBuilder();

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int sum = carry;
                if (i >= 0) sum += a[i--] - '0';
                if (j >= 0) sum += b[j--] - '0';

                sb.Append((sum % 2).ToString());
                carry = sum / 2;
            }

            char[] resultArray = sb.ToString().ToCharArray();
            Array.Reverse(resultArray);
            string result = new string(resultArray).TrimStart('0');

            return result == "" ? "0" : result;
        }

    } // class
} // namespace
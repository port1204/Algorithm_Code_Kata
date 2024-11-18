namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string[] input = sr.ReadLine().Split();
                string binary1 = input[0];
                string binary2 = input[1];

                if (binary1.Length < binary2.Length)
                {
                    string temp = binary1;
                    binary1 = binary2;
                    binary2 = temp;
                }

                int maxLength = binary1.Length;
                char[] A = binary1.ToCharArray();
                char[] B = binary2.PadLeft(maxLength, '0').ToCharArray();

                Array.Reverse(A);
                Array.Reverse(B);

                bool carry = false;
                for (int i = 0; i < maxLength; i++)
                {
                    int sum = (A[i] - '0') + (B[i] - '0') + (carry ? 1 : 0);
                    A[i] = (char)((sum % 2) + '0');
                    carry = sum >= 2;
                }

                if (carry)
                {
                    Array.Resize(ref A, A.Length + 1);
                    A[A.Length - 1] = '1';
                }

                Array.Reverse(A);
                string result = new string(A).TrimStart('0');
                sw.WriteLine(result == "" ? "0" : result);
            }
        }
    }
}

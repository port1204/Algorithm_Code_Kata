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
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);

                int[] arrayA = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int[] arrayB = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                int[] result = new int[A + B];
                int i = 0, j = 0, k = 0;

                // 병합 과정
                while (i < A && j < B)
                {
                    if (arrayA[i] <= arrayB[j])
                    {
                        result[k++] = arrayA[i++];
                    }
                    else
                    {
                        result[k++] = arrayB[j++];
                    }
                }

                // A 배열의 남은 원소 추가
                while (i < A)
                {
                    result[k++] = arrayA[i++];
                }

                // B 배열의 남은 원소 추가
                while (j < B)
                {
                    result[k++] = arrayB[j++];
                }

                sw.WriteLine(string.Join(" ", result));
            }
        }

    }
}
namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]); // 증가
            int B = int.Parse(input[1]); // 일하는 양
            int C = int.Parse(input[2]); // 감소
            int M = int.Parse(input[3]); // 최대치 

            int fatigue = 0; // 피로ㅓ도
            int work = 0; // 업무량
            int hour = 0;

            while ( hour < 24 )
            {
                ++hour;

                if (fatigue + A <= M)
                {
                    fatigue += A;
                    work += B;
                }
                else
                {
                    fatigue -= C;
                    if (fatigue < 0) { fatigue = 0; }
                }
            }

            Console.WriteLine(work);

        }
    }
}

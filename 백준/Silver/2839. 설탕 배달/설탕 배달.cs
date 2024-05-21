using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());
            int[] kg = {  5, 3 };
            int answer = 0;
            int Ex = N;
            bool isTrue = false;
            
            if(N % kg[0] == 0)
            {
                answer += Ex / kg[0];
                N = 0;
                isTrue = true;
            }
            
            if (!isTrue)
            {
                for (int i = 1; i < N / 3; ++i)
                {
                    if ((Ex % kg[0]) % kg[1] == 0)
                    {
                        answer += (Ex / kg[0]) + i;
                        N = 0;
                        isTrue = true;
                        break;
                    }
                    Ex -= kg[1];
                }
            }
            
            if (N % kg[1] == 0 && !isTrue)
            {
                answer += N / kg[1];
                N = 0;
            }

            sb.Append(N == 0 ? answer : -1 );
            Console.Clear();
            Console.WriteLine(sb.ToString());
        }//main
    }
}
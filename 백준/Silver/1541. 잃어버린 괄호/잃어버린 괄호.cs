using System.Data;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Q = Console.ReadLine();
            char[] q = Q.ToCharArray();

            string result = "(";
            for (int i = 0; i < q.Length; ++i)
            {
                if (q[i] == '-')
                {
                    result += ")-(";
                }
                else if (q[i] == '+')
                {
                    result += "+";
                }
                else
                {
                    result += q[i];
                }
            }
            result += ")";

            var answer = new DataTable().Compute(result, null);
            Console.WriteLine(answer);
        }
    }
}

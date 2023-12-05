using System;

public class Solution
{
        public int[] solution(int[] arr, int divisor)
        {
            int[] answer = new int[] { };
            
            answer = Array.FindAll(arr, length => length % divisor == 0);

            if (answer.Length == 0)
            {
                answer = new int[] {-1};
            }
            else
            {
                Array.Sort(answer);
            }
            
            return answer;
        }
}
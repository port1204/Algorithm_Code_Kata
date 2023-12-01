public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        long sum = 0;
        if (a < b)
        {
            for(int i = a; i < b; i++)
            {
                sum += i;
            }
            answer = sum + (long)b;
        }
        else if(a == b)
        {
            answer = (long)a;
        }
        else if(b < a)
        {
            for(int i = b; i < a; i++)
            {
                sum += i;
            }
            answer = sum + (long)a;
        }
        return answer;
    }
}
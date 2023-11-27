using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        double s = Math.Sqrt(n);
        if(s % 1 == 0)
        {
            answer = (long)Math.Pow((s + 1), 2);
        }
        else
        {
            answer = -1;
        }
        return answer;
    }
}
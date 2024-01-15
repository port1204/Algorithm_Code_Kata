using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        long a = 0;
        for(int i = 0; i <= t.Length - p.Length; i++)
        {
            string b = t.Substring(i, p.Length);
            a = long.Parse(b);
            if(a <= long.Parse(p))
            {
                answer++;
            }
        }
        return answer;
    }
}
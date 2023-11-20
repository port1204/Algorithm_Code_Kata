using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int rem = 0;
        while(n > 0)
        {
            rem = n % 10; 
            answer += rem;
            n = n / 10;
        }
        
        return answer;
    }
}
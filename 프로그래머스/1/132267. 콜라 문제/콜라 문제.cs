using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        int c = 0;
        int d = 0;
        while(n >= a)
        {
            d = (n / a) * b;
            answer += d;
            c = n % a;
            n = d + c;
        }
        return answer;
    }
}
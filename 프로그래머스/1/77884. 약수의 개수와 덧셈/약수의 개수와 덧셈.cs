using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        int sumCount = 0;
        int sum = 0;
        
        for (int i = 1;i <= left; i++)
        {
            if(right < left) break;
            
            if(left % i == 0)
            {
                sumCount++;
                if(left == i)
                {
                    i = 0;
                    if(sumCount % 2 == 0)
                    {
                        answer += left;
                        sumCount = 0;
                        left++;
                    }
                    else
                    {
                        answer -= left;
                        sumCount = 0;
                        left++;
                    }
                }
            }
        }

        return answer;
    }
}
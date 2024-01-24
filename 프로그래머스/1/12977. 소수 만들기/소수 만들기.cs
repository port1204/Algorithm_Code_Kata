using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        int a = 0;
        int b = 0;
        for(int i = 0; i < nums.Length - 2; i++)
        {
            for(int j = i + 1; j < nums.Length - 1; j++)
            {
                for(int k = j + 1; k < nums.Length; k++)
                {
                    a = nums[i] + nums[j] + nums[k];
                    for(int t = 2; t <= a; t++)
                    {
                        if(a % t == 0)
                        {
                            b++;   
                        }
                    }
                    if(b == 1)
                    {
                        answer++;
                    }
                    a = 0;
                    b = 0;
                }
            }
        }
        return answer;
    }
}
public class Solution {
    public int solution(long num) {
        int answer = 0;
       
        for (int i = 0; i < 500; i++)
        {
            if (i == 0 && num == 1)
            {
                answer = 0;
                break;
            }
            else if (i == 499)
            {
                answer = -1;
                break;
            }
            else if (num == 1)
            {
                answer = i;
                break;
            }
            else if(num % 2 == 0)
            {
                num /= 2;
            }
            else if(num % 2 != 0)
            {
                num = (num*3) + 1;
            }
            else 
            {
                answer = -1;
            }
        }
        return answer;
    }
}
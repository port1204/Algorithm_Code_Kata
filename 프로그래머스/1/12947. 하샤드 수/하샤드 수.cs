public class Solution
{
    public bool solution(int x)
    {
        bool answer = true;
        int sum = 0;
        int test = x;
        while(x > 0)
        {
            if ( test < 10){
                sum += test;
                break;
            }
            else
            {
                sum += test % 10;
                test = test / 10;   
            }
        }
        if (x % sum != 0)
        {
            answer = false;
        }
        return answer;
    }
}
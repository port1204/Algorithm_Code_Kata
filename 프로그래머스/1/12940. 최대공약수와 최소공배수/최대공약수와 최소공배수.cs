public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int min = 0;
        int max = 0;
        int gcd = 0;
        
        if (n < m)
        {
            max = m;
            min = n;
        }
        else
        {
            max = n;
            min = m;
        }
        
        gcd = min;
        
        while(true)
        {
            gcd = max % min;
            max = min;
            if (gcd == 0) break;
            min = gcd;
        }
        
        answer = new int[] {min, n * m / min};
        return answer;
    }
}
public class Solution {
    public string solution(string s) {
        string answer = "";
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                count = 0;
                answer += " ";
            }
            else if(count % 2 == 0)
            {
                answer += s[i].ToString().ToUpper(); 
                count++;
            }
            else
            {
                answer += s[i].ToString().ToLower(); 
                count++;
            }
        }
        
        return answer;
    }
}
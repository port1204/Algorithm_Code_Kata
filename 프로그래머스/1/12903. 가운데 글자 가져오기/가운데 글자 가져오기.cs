public class Solution {
    public string solution(string s) {
        string answer = "";
        int i = s.Length / 2;
        if(s.Length % 2 == 0)
        {
            answer += s[i - 1];
            answer += s[i];
        }
        else
        {
            answer += s[i];
        }
        return answer;
    }
}
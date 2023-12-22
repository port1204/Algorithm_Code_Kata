public class Solution {
    public bool solution(string s) {
        int a;
        bool answer = true;
        if (s.Length == 4 || s.Length == 6)
        {
            answer = int.TryParse(s, out a);
        }
        else
        {
            answer = false;
        }
        return answer;
    }
}
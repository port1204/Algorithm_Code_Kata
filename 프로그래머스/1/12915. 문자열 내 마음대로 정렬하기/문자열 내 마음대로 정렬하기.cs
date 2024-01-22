using System;

public class Solution {
    public string[] solution(string[] strings, int n) {
        int a = strings.Length;
        string[] answer = new string[a];
        
        for(int i=0; i<a; i++)
        {
            answer[i] = (strings[i][n]) + strings[i];
        }
        
        Array.Sort(answer);
        
        for(int j=0; j<a; j++)
        {
            answer[j] = answer[j].Substring(1);
        }
        
        return answer;
    }
}
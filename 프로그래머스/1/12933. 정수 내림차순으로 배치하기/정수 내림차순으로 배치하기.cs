using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        //long n을 char[]로 형변환
        char[] s = n.ToString().ToCharArray();
        //배열 오름차순 정렬
        Array.Sort(s);
        //배열 역순 정렬
        Array.Reverse(s);
        //long으로 다시 변환
        answer = long.Parse(s);
        return answer;
    }
}
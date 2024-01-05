using System;
public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        //해당 날짜 구하기
        DateTime date = new DateTime(2016, a, b);
        //날짜의 요일 구하기
        string day = date.DayOfWeek.ToString();
        //해당 요일 3글자만 출력
        answer = day.Substring(0, 3);
        //문자를 대문자로 변환
        return answer.ToUpper();
    }
}
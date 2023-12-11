using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        //List의 함수 쓰려고 Array to List 해줌
        List<int> arrList = new List<int>(arr);
        List<int> answer = new List<int>(arr);
        //작은순으로 정렬
        arrList.Sort();
        //리스트 answer에서 arrList에 제일 작은수를 제거
        answer.Remove(arrList[0]);
        //리스트 answer의 크기가 0 이면 -1 추가
        if (answer.Count == 0)
        {
            answer.Add(-1);
        }
        //return이 int[] 이니까 List to Array 해줌
        return answer.ToArray();
    }
}
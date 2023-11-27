using System;

public class Solution {
    public long[] solution(long n) {
        int size = n.ToString().Length;
        //long n을 ToString().Length를 통해 int size에 숫자의 길이를 입력한다.
        //예) long n = 12123 라고 한다면 int size = 5 가 된다. 
        long[] answer = new long[size];
		//long[] answer 에 배열의 크기를 new long[size]로 만들어주고 진행 
        for(int i = 0; i < size; i++){
            answer[i] = n % 10;
            n /= 10;
        }
        //반복문을 n 의 길이인 size 만큼 돌려서
        //1의자리 숫자인 값을 answer[i]에 하나씩 넣어준다.
        return answer;
        //예)long n = 12123, int size = 5, answer = [3, 2, 1, 2, 1]
    }
}
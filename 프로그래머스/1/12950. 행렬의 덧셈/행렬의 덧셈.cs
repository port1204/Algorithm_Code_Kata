public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int[,] answer = new int[arr1.GetLength(0),arr1.GetLength(1)];
        //0번쨰 인덱스 
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            //1번째 인덱스
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                //...N번째 인덱스까지 더해줘야 한다면 어디까지 반복문을 돌려도될까
                answer[i,j] = arr1[i,j] + arr2[i,j];
            }
        }
        return answer;
    }
}
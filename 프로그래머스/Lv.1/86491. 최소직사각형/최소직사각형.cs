using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int mv = 0;
        int mh = 0;
        for(int i = 0; i < sizes.GetLength(0); i++)
        {
            int v = sizes[i, 0];
            int h = sizes[i, 1];
            
            if(v > h)
            {
                v = sizes[i,1];
                h = sizes[i,0];
            }
            if(v > mv)
            {
                mv = v;
            }
            if(h > mh)
            {
                mh = h;
            }
        }
        answer = mv * mh;
        return answer;
    }
}
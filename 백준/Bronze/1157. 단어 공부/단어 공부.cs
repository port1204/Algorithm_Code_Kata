using System;
using System.Threading.Channels;

namespace CodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 필드변수

            string A = Console.ReadLine().ToUpper(); // 대문자로 바꾸기

            Dictionary<char, int> dictB = new Dictionary<char, int>(); // 알파벳 + 최대 갯수 구할때 쓸 딕셔너리

            int maxD = 0; // 최대 갯수인 값 찾아서 저장할 때 쓸거

            Dictionary<int, int> dictE = new Dictionary<int, int>(); // 중복 최대값이 나올 경우를 대비한 딕셔너리
            #endregion

            #region 딕셔너리에 값 넣기
            foreach (char C in A) // 문자열을 순회 돌면서 문자 C에 한글자씩 담기
            {
                if (dictB.ContainsKey(C)) // 이미 담겨져 있는 경우
                {
                    ++dictB[C]; // 값 +
                }
                else // 처음 보는 문자일 경우
                {
                    dictB.Add(C, 1); //초기 값 설정
                }
            }
            #endregion

            #region 딕셔너리 값 이용해 최대 수 찾기 + 중복체크
            foreach (var F in dictB.Keys)
            {
                int curG = dictB[F]; // 최대 갯수랑 비교할 현재 갯수(값)

                if (curG >= maxD) // 현재 값보다 최대 값이 작을 때 (초기 최대 값은 0)
                {
                    maxD = curG; // 현재 값을 최대 값으로 설정하기
                    if (dictE.ContainsKey(maxD)) //최대값으로 받은적 있는지 체크
                    {
                        ++dictE[maxD]; // 값증가
                    }
                    else
                    {
                        dictE.Add(maxD, 1); //값 설정
                    }
                }
            }
            #endregion

            char key = dictB.FirstOrDefault(x => x.Value == maxD).Key;

            Console.WriteLine(dictE[maxD] != 1 ? "?" : key);
        }
    }
}

namespace AlogrithmsPractice;

public class T2_2
{
    Solution solution = new();
    
    int[] a = { 2, -2, -3, 3 };
    int[] b = { 0, 0, 4, -4 };
    
    class Solution
    {
        public int solution(int[] A, int[] B)
        {
            int fairs = 0;
    
            Dictionary<int, int> elementToFromStartSumA = new Dictionary<int, int>();
            Dictionary<int, int> elementToFromStartSumB = new Dictionary<int, int>();
    
            Dictionary<int, int> elementToFromEndSumA = new Dictionary<int, int>();
            Dictionary<int, int> elementToFromEndSumB = new Dictionary<int, int>();
    
            int sumAStart = 0;
            int sumBStart = 0;
    
            int sumAEnd = 0;
            int sumBEnd = 0;
    
            int l = 0;
    
            while (l < A.Length)
            {
                sumAStart += A[l];
                sumBStart += B[l];
    
                sumAEnd += A[A.Length - l - 1];
                sumBEnd += B[A.Length - l - 1];
    
                elementToFromStartSumA.Add(l + 1, sumAStart);
                elementToFromStartSumB.Add(l + 1, sumBStart);
    
                elementToFromEndSumA.Add(l + 1, sumAEnd);
                elementToFromEndSumB.Add(l + 1, sumBEnd);
    
                l++;
            }
    
            for (int i = 1; i < A.Length; i++)
            {
                int sumAPrevK = elementToFromStartSumA[i];
                int sumBPrevK = elementToFromStartSumB[i];
    
                int sumAAfterK = elementToFromEndSumA[A.Length - i];
                int sumBAfterK = elementToFromEndSumB[A.Length - i];
    
                bool prevEqual = sumAPrevK == sumBPrevK;
    
                bool afterEqual = sumAAfterK == sumBAfterK;
    
                bool allEqual = sumAPrevK == sumAAfterK && sumBPrevK == sumBAfterK;
    
                if (prevEqual && afterEqual && allEqual)
                {
                    fairs++;
                }
            }
    
            return fairs;
        }
    }
}
int K = 2;
int M = 3;
List<int> vulnerability = new List<int>
{
    1,
    3,
    2,
    1
};

List<int> result = Result.findKthMinimumVulnerability(K, M, vulnerability);

Console.WriteLine(string.Join(", ", result));

class Result
{

    /*
     * Complete the 'findKthMinimumVulnerability' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER m
     *  3. INTEGER_ARRAY vulnerability
     */

    public static List<int> findKthMinimumVulnerability(int k, int m, List<int> vulnerability)
    {
        List<int> result = new List<int>();

        if (vulnerability.Count < m)
        {
            return result;
        }

        List<int> subList = new List<int>();
    
        for (int i = 0; i < vulnerability.Count - m + 1; i++)
        {
            for (int j = i; j < i + m; j++)
            {
                subList.Add(vulnerability[j]);

                if (subList.Count == m)
                {
                    subList.Sort();
                    result.Add(subList[k - 1]);
                    subList.Clear();
                }
            }
        }

        return result;
    }
}
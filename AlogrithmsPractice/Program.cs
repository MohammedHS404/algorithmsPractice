string s = "**|";
List<int> startIndices = new()
{
    1
};
List<int> endIndices = new()
{
    3
};

Result.numberOfItems(s, startIndices, endIndices).ForEach(Console.WriteLine);

class Result
{

    /*
     * Complete the 'numberOfItems' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER_ARRAY startIndices
     *  3. INTEGER_ARRAY endIndices
     */

    public static List<int> numberOfItems(string s, List<int> startIndices, List<int> endIndices)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < endIndices.Count; i++)
        {
            int start = startIndices[i] - 1;

            int end = endIndices[i] - 1;

            int totalItems = 0;

            int itemsCount = 0;

            bool shouldCount = false;

            for (int j = start; j <= end; j++)
            {
                if (s[j] == '|')
                {
                    shouldCount = true;

                    totalItems += itemsCount;
                    itemsCount = 0;
                }

                if (shouldCount && s[j] == '*')
                {
                    itemsCount++;
                }
            }

            result.Add(totalItems);
        }

        return result;
    }

}
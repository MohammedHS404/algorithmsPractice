namespace AlogrithmsPractice;

public class BoxWeights
{
    public static void Run()
    {
        List<int> arr = new List<int>
        {
            1,
            2
        };

        Result.minimalHeaviestSetA(arr).ForEach(Console.WriteLine);
    }

    class Result
    {

        /*
         * Complete the 'minimalHeaviestSetA' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static List<int> minimalHeaviestSetA(List<int> arr)
        {
            arr = arr.OrderBy(x => x).ToList();

            long sum = 0;

            foreach (var item in arr)
            {
                sum += item;
            }

            long target = sum / 2;

            Stack<int> result = new Stack<int>();

            for (int i = arr.Count - 1; i >= 0; i--)
            {
                if (target <= 0)
                {
                    break;
                }

                result.Push(arr[i]);
                target -= arr[i];
            }

            return result.ToList();
        }
    }
}
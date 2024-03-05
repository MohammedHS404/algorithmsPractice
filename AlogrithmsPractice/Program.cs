using System.Text;

Solution solution = new Solution();

List<string> input = new List<string> { "#l#in#t#", "#cod#e", "#lo#ve#", "you" };

string encoded = solution.encode(input);

Console.WriteLine(encoded);

List<string> decoded = solution.decode(encoded);

foreach (var str in decoded)
{
    Console.WriteLine(str);
}

public class Solution
{
    private const char separator = '#';

    /*
     * @param strs: a list of strings
     * @return: encodes a list of strings to a single string.
     */
    public String encode(List<String> strs)
    {
        StringBuilder result = new();

        foreach (var str in strs)
        {
            int countOfCharacters = str.Length;

            result.Append(countOfCharacters);

            result.Append(separator);

            result.Append(str);
        }

        return result.ToString();
    }

    /*
     * @param str: A string
     * @return: decodes a single string to a list of strings
     */
    public List<String> decode(String str)
    {
        // write your code here

        List<string> result = new List<string>();

        StringBuilder numberOfCharactersInNextWordString = new StringBuilder();


        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == separator)
            {
                i++;

                StringBuilder word = new StringBuilder();

                int numberOfCharactersInNextWord = int.Parse(numberOfCharactersInNextWordString.ToString());

                for (int j = 0; j < numberOfCharactersInNextWord; j++)
                {
                    word.Append(str[i + j]);
                }

                result.Add(word.ToString());

                i += numberOfCharactersInNextWord;

                numberOfCharactersInNextWordString.Clear();
            }

            if (i < str.Length)
            {
                numberOfCharactersInNextWordString.Append(str[i]);
            }
        }

        return result;
    }
}
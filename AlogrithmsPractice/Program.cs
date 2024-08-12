using System.Text;

string str = "aabcccccaaa";
string compressedStr = StringCompression(str);

Console.WriteLine(compressedStr);

str = "abc";

compressedStr = StringCompression(str);

Console.WriteLine(compressedStr);

string StringCompression(string str)
{
    if (string.IsNullOrEmpty(str))
    {
        return str;
    }

    StringBuilder compressedString = new StringBuilder();
    int count = 1;
    char currentChar = str[0];

    for (int i = 1; i < str.Length; i++)
    {
        if (str[i] == currentChar)
        {
            count++;
        }
        else
        {
            compressedString.Append(currentChar);
            compressedString.Append(count);
            currentChar = str[i];
            count = 1;
        }
    }

    compressedString.Append(currentChar);
    compressedString.Append(count);

    return compressedString.Length < str.Length ? compressedString.ToString() : str;
}
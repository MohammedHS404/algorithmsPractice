Console.WriteLine(URLify("Mr John Smith    ".ToCharArray(), 13)); // True

string? URLify(char[] str, int trueLength)
{
    int index = str.Length-1;
    for (int i = trueLength - 1; i >= 0; i--)
    {
        if (str[i] != ' ')
        {
            str[index] = str[i];
            index--;
        }
        else
        {
            str[index] = '0';
            str[index - 1] = '2';
            str[index - 2] = '%';
            index -= 3;
        }
    }

    return new string(str);
}
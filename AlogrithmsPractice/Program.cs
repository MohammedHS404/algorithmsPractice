Console.WriteLine(OneEditAway("pale", "ple")); // True

Console.WriteLine(OneEditAway("pales", "pale")); // True

Console.WriteLine(OneEditAway("pale", "bale")); // True

Console.WriteLine(OneEditAway("pale", "bake")); // False

bool OneEditAway(string s1, string s2)
{
    int count = 0;

    if (Math.Abs(s1.Length - s2.Length) > 1)
    {
        return false;
    }

    Dictionary<char, int> s1CharCount = new Dictionary<char, int>();

    for (int i = 0; i < s1.Length; i++)
    {
        if (s1CharCount.ContainsKey(s1[i]))
        {
            s1CharCount[s1[i]]++;
        }
        else
        {
            s1CharCount.Add(s1[i], 1);
        }
    }

    for (int i = 0; i < s2.Length; i++)
    {
        if (s1CharCount.ContainsKey(s2[i]))
        {
            s1CharCount[s2[i]]--;
        }
    }
    
    foreach (var item in s1CharCount)
    {
        if (item.Value != 0)
        {
            count++;
            
            if (count > 1)
            {
                return false;
            }
        }
    }

    return true;
}
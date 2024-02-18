
public class Solution {
    public bool IsAnagram(string s, string t) {
        return s.Order().SequenceEqual(t.Order());
    }
}
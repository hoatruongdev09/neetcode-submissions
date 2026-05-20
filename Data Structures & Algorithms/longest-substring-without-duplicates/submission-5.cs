public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length < 2)
        {
            return s.Length;
        }
        HashSet<char> setChars = new();
        int start = 0;
        int end = 0;
        int longest = 0;
        while(end < s.Length)
        {
            longest = Math.Max(longest, setChars.Count);
            while(setChars.Contains(s[end]))
            {
                setChars.Remove(s[start]);
                start++;
            }
            setChars.Add(s[end]);
            end++;
        }
        return Math.Max (longest, setChars.Count);
    }
}

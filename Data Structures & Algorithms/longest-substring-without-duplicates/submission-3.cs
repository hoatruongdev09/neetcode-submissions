public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length < 2) {
            return s.Length;
        }
        int longest = 0;
        for(int i = 0 ; i < s.Length; i++)
        {
            HashSet<char> setChars = new();
            setChars.Add(s[i]);
            for(int j = i + 1; j < s.Length; j++)
            {
                if(setChars.Contains(s[j]))
                {
                    break;
                }
                setChars.Add(s[j]);
            }
            longest = Math.Max(longest, setChars.Count);
        }

        return longest;
    }
}

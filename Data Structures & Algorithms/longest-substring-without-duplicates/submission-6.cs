public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrEmpty(s)) {
            return 0;
        }

        if(s.Length < 2) {
            return s.Length;
        }

        int l = 0;
        int r = l + 1;
        int maxLength = 1;
        HashSet<char> hs = new();
        hs.Add(s[l]);

        while(l < s.Length)
        {
            while(hs.Contains(s[r]))
            {
                hs.Remove(s[l]);
                l++;
            }
            hs.Add(s[r]);
            maxLength = Math.Max(maxLength, hs.Count);
            r++;
            if(r >= s.Length)
            {
                break;
            }
        }

        return maxLength;
    }
}

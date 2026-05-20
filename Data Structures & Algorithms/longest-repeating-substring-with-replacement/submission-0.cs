public class Solution {
    public int CharacterReplacement(string s, int k) {
        HashSet<char> setChars = new(s);
        int longest = 0;
        foreach(char c in setChars)
        {
            longest = Math.Max(longest, FindSubString(s, k, c));
        }
        return longest;
    }

    private int FindSubString(string s, int k, char c)
    {
        int left = 0;
        int right = 0;
        int longest = 0;
        int currentK = 0;
        while(right < s.Length)
        {
            if(s[right] != c)
            {
                currentK++;
            }
            right++;
            while(left < right && currentK > k)
            {
                if(s[left] != c)
                {
                    currentK--;
                }
                left++;
            }
            longest = Math.Max(longest, right - left);
        }
        return longest;
    }
}

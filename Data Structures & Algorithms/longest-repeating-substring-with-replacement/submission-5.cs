public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<int,int> count = new();
        int left = 0;
        int max = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(count.ContainsKey(s[i]))
            {
                count[s[i]]++;
            }
            else
            {
                count[s[i]] = 1;
            }
            while((i - left + 1) - count.Values.Max() > k)
            {
                count[s[left]]--;
                left++;
            }
            max = Math.Max(max, i - left + 1);
        }

        return max;
    }
}

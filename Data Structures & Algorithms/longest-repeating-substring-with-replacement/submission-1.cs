public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<int,int> count = new();
        int res = 0;
        int left = 0;

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
            res = Math.Max(res, i - left + 1);

        }
        return res;
    }
}

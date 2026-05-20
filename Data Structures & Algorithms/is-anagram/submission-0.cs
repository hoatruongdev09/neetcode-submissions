public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, int> ds = new Dictionary<char,int>();
        Dictionary<char, int> dt = new Dictionary<char,int>();

        for(int i = 0; i < s.Length; i++)
        {
            if(!ds.ContainsKey(s[i]))
            {
                ds[s[i]] = 1;
            }else
            {
                ds[s[i]] += 1;
            }
            if(!dt.ContainsKey(t[i]))
            {
                dt[t[i]] = 1;
            }else{
                dt[t[i]] += 1;
            }
        }

        foreach(var pair in ds)
        {
            if(!dt.ContainsKey(pair.Key)){
                return false;
            }
            if(ds[pair.Key] != dt[pair.Key])
            {
                return false;
            }
        }
        return true;
    }
}

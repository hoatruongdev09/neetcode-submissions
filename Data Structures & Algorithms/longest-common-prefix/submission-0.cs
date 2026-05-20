public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string ss = null;

        foreach(var s in strs)
        {
            if(ss == null || ss.Length >= s.Length)
            {
                ss = s;
            }
        }
        var sb = new StringBuilder();
        for(int i = 0; i < ss.Length; i++)
        {
            var hs = new HashSet<char>();
            foreach(var s in strs)
            {
                hs.Add(s[i]);
            }
            if(hs.Count > 1)
            {
                break;
            }
            sb.Append(ss[i]);
        }
        return sb.ToString();
    }
}
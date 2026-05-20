public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

        foreach(string str in strs)
        {
            string hash = this.CreateHash(str);
            if(dic.ContainsKey(hash))
            {
                dic[hash].Add(str);
            }else{
                dic[hash] = new List<string>() {str};
            }
        }

        List<List<string>> result = new List<List<string>>();

        foreach(var pair in dic)
        {
            result.Add(pair.Value);
        }

        return result;
    }

    public string CreateHash(string str)
    {
        int[] c = new int[27];
        foreach(char ch in str)
        {
            c[ch-'a'] += 1;
        }
        StringBuilder sb = new StringBuilder();

        for(int i = 0; i < c.Length; i++)
        {
            if(c[i] == 0)
            {
                continue;
            }
            sb.Append((char)(i + 'a'));
            sb.Append(c[i]);
        }

        return sb.ToString();
    }
}

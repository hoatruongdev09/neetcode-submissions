public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new ();
        foreach(string str in strs)
        {
            int count = str.Length;
            sb.Append($"_{count}:{str}");
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> list = new();
        int nextAmount = 0;
        StringBuilder currentSb = new();

        int i = 0;
        while(i < s.Length)
        {
            if(nextAmount > 0)
            {
                currentSb.Append(s[i]);
                nextAmount--;
            }
            else{
                if(currentSb.Length > 0)
                {
                    list.Add(currentSb.ToString());
                    currentSb.Clear();
                }
                
                if(s[i] == '_')
                {
                    int number = 0;
                    i++;
                    while(s[i] != ':')
                    {
                        number = number * 10 + ConvertToNumber(s[i]);
                        i++;
                    }
                    nextAmount = number;

                    if(nextAmount == 0)
                    {
                        list.Add("");
                    }
                }
            
            }
            i++;
        }
        if(currentSb.Length > 0 ){
            list.Add(currentSb.ToString());
        }
        return list;
   }

   private int ConvertToNumber(char c) {
        return c - '0';
   }
}

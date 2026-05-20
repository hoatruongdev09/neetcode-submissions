public class Solution {
    public bool IsValid(string s) {
        if(s.Length < 2)
        {
            return false;
        }
        Stack<char> st = new();

        foreach(char c in s)
        {
            switch(c)
            {
                case ')':
                    if(st.Count == 0 || st.Pop() != '('){
                        return false;
                    }
                break;
                case ']':
                    if(st.Count == 0 || st.Pop() != '['){
                        return false;
                    }
                break;
                case '}':
                    if(st.Count == 0 || st.Pop() != '{'){
                        return false;
                    }
                break;
                default:
                    st.Push(c);
                break;
            }
        }

        return st.Count == 0;
    }
}

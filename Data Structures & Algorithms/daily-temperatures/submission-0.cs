public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> tmp = new();
        for(int i = temperatures.Length - 1; i >= 0; i--)
        {
            tmp.Push(temperatures[i]);
        }
        int[] r = new int[temperatures.Length];

        for(int i = 0; i < r.Length; i++)
        {
            int currentDayTemp = tmp.Pop();
            r[i] = 0;
            Stack<int> temp = new();
            while(tmp.Count > 0)
            {
                if(tmp.Peek() > currentDayTemp)
                {
                    r[i] = temp.Count + 1;
                    break;
                }
                temp.Push(tmp.Pop());
            }
            while(temp.Count > 0)
            {
                tmp.Push(temp.Pop());
            }
        }

        return r;
    }
}

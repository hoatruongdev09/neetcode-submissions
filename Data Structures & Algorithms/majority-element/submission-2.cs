public class Solution {
    public int MajorityElement(int[] nums) {
        var dic = new Dictionary<double,int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(dic.ContainsKey(nums[i]))
            {
                dic[nums[i]]++;
            }
            else
            {
                dic.Add(nums[i],1);
            }
        }

        (double val, double c) =(int.MinValue, 0);
        
        foreach((var key, var count ) in dic)
        {
            if(c < count)
            {
                val = key;
                c = count;
            }
        }
        return (int)val;
    }
}
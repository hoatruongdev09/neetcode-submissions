public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> d = new Dictionary<int, int>();
        for(int i = 0;i < nums.Length; i++)
        {
            if(d.ContainsKey(target - nums[i]))
            {
                return new int[] {d[target - nums[i]], i};
            }
            d[nums[i]] = i;
        }
        return null;
    }
}

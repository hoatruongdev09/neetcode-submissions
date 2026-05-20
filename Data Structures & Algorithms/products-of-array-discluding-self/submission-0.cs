public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        int prefix = 1;
        for(int i = 0; i < nums.Length;i++)
        {
            result[i] = prefix;
            prefix *= nums[i];
        }
        int postFix = 1;
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= postFix;
            postFix *= nums[i];
        }
        return result;
    }
}
// 1 2 4 6
// 1 1 2 8
// 1 1 12 8
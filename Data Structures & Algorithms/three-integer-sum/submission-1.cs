public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> res = new();
        Array.Sort(nums);

        int index = 0;
        while(index <= nums.Length - 3)
        {
            int left = index + 1;
            int right = nums.Length - 1;
            while(left < right)
            {
                int sum = nums[index] + nums[left] + nums[right];
                if(sum < 0)
                {
                    left++;
                }else if (sum > 0)
                {
                    right--;
                }else{
                    res.Add(new List<int>(){nums[index], nums[left], nums[right]});
                    int leftVal = nums[left];
                    while(nums[left] == leftVal && left < right)
                    {
                        left++;
                    }
                    int rightVal = nums[right];
                    while(nums[right] == rightVal && right > left)
                    {
                        right--;
                    }
                }
            }
            int indexVal = nums[index];
            while(index < nums.Length && nums[index] == indexVal )
            {
                index++;
            }
        }
        
        return res;
    }

    // -4 -1 -1 0 1 2
}

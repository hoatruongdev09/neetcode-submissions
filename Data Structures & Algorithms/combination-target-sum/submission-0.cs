public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        
        List<List<int>> result = new();

        for(int i = 0; i < nums.Length; i++)
        {
            BackTrack(i, nums, target - nums[i], new List<int>(), result);
        }


        return result;
    }

    private void BackTrack(int index, int[] nums, int target, List<int> current, List<List<int>> result)
    {
        if(target < 0)
        {
            return;
        }
        current.Add(nums[index]);
        if(target == 0)
        {
            result.Add(current);
            return;
        }

        for(int i = index; i < nums.Length; i++)
        {
            BackTrack(i, nums, target - nums[i], new List<int>(current), result);
        }

    }
}

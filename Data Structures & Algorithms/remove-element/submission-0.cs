public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int valCount = 0;

        for(int i = 0 ; i < nums.Length - valCount; i++)
        {
            if(nums[i] == val)
            {
                ShiftLeft(nums, i);
                nums[nums.Length - 1] = val;
                valCount++;
                i--;
            }
        }

        return nums.Length - valCount;
    }

    private void ShiftLeft(int[] nums, int index)
    {
        for(int i = index; i<nums.Length - 1;i++)
        {
            nums[i] = nums[i+1];
        }
    }
}


// val = 2
// 0,1,2,2,3,0,4,2 valCount = 0
// 0,1,2,3,0,4,2,2 valCount = 1
// 0,1,2,3,0,4,2









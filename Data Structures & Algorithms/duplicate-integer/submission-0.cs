public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums.Length < 2){
            return false;
        }
        HashSet<int> setNum = new HashSet<int>();
        foreach(int num in nums)
        {
            if(setNum.Contains(num))
            {
                return true;
            }
            setNum.Add(num);
        }
        return false;
    }
}

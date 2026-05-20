public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> setNums = new HashSet<int>(nums);
        int longest = 0;
        foreach(int num in nums)
        {
            if(setNums.Contains(num - 1))
            {
                continue;
            }
            int currentPosition = num + 1;
            while(setNums.Contains(currentPosition))
            {
                currentPosition++;
            }
            longest = Math.Max(currentPosition - num, longest);
        }
        return longest;
    }
}

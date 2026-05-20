// 3,4,5,6,1,2
// 0,1,2,3,4,5
// ______l_r__
public class Solution {
    public int FindMin(int[] nums) {
       int l = 0;
       int r = nums.Length - 1;

       while(l < r) // l: 3, r: 4
       {
            int m = (r + l) / 2; // m: 3
            
            int lVal = nums[l]; // 6
            int rVal = nums[r]; // 1
            int mVal = nums[m]; // 6

            if(lVal < rVal && mVal < rVal) // 6 < 1 && 6 < 1
            {
                r = m;
                continue;
            }
            
            if(lVal > rVal) // 6 > 1
            {
                if(mVal < rVal) // 6 < 1
                {
                    r = m; // r = 4
                }
                else
                {
                    l = m + 1; // l: 3
                }
            }
       }

       return nums[l];
    }
}

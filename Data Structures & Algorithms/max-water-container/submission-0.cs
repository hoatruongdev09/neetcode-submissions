public class Solution {
    public int MaxArea(int[] h) {
       int max = int.MinValue;

        int left = 0;
        int right = h.Length - 1;

        while(left < right)
        {
            if(h[left] < h[right])
            {
                max = Math.Max(max, h[left] * (right - left));
                left++;
            }else{
                max = Math.Max(max, h[right] * (right - left));
                right--;
            }
        }

       return max; 
    }
}

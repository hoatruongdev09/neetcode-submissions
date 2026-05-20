public class Solution {
    public int Trap(int[] h) {
        int water = 0;
        
        int l = 0;
        int r = h.Length - 1;

        int maxL = h[l];
        int maxR = h[r];
        
        while (l < r)
        {
            if(maxL < maxR)
            {
                l++;
                maxL = Math.Max(maxL, h[l]);
                water += maxL - h[l];
            }
            else
            {
                r--;
                maxR = Math.Max(maxR, h[r]);
                water += maxR - h[r];
            }
        }

        return water;
    }
}

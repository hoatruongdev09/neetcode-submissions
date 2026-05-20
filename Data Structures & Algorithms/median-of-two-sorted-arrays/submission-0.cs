public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] newNums = new int[nums1.Length + nums2.Length];
        if(newNums.Length == 0) { return 0; }
        int l = 0;
        int r = 0;

        while(l < nums1.Length && r < nums2.Length)
        {
            int n1 = nums1[l];
            int n2 = nums2[r];
            if(n1 <= n2)
            {
                newNums[l + r] = n1;
                l++;
            }
            else
            {
                newNums[l + r] = n2;
                r++;
            }
        }

        while(l < nums1.Length)
        {
            newNums[l + r] = nums1[l];
            l++;
        }
        while(r < nums2.Length)
        {
            newNums[l + r] = nums2[r];
            r++;
        }
        int midIndex = newNums.Length / 2;

        return (newNums.Length % 2 == 0) ? (newNums[midIndex] + newNums[midIndex - 1]) / 2f: newNums[midIndex];
    }
}

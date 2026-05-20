public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0;

        int profit = 0;
        
        while(l < prices.Length)
        {
            int r = l + 1;
            while(r < prices.Length)
            {
                profit = Math.Max(profit, prices[r] - prices[l]);
                if(prices[r] < prices[l])
                {
                    break;
                }
                r++;
            }
            l = r;
        }


        return profit;
    }
}

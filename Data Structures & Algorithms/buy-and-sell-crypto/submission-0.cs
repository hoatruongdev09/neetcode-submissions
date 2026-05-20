public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length < 2)
        {
            return 0;
        }
        int buyInIndex = 0;
        int maxValue = 0;
        for(int i = 1; i < prices.Length; i++)
        {
            while(buyInIndex < i && prices[i] - prices[buyInIndex] < 0)
            {
                buyInIndex++;
            }
            maxValue = Math.Max(maxValue, prices[i] - prices[buyInIndex]);
        }
        return maxValue;
    }
}

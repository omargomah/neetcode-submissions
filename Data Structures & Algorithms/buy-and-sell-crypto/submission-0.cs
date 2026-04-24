public class Solution {
    public int MaxProfit(int[] prices) 
    {
             int l = 0 , r = 1 , result = 0;
        while(r < prices.Length)
        {
            if(prices[r] > prices[l])
            {
                if(result < prices[r] - prices[l])
                    result = prices[r] - prices[l];
            }
            else
                l = r;
            r++;
        }
        return result;   
    }
}

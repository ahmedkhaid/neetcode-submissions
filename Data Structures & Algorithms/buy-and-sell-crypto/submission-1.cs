public class Solution {
    public int MaxProfit(int[] prices) {
     if(prices.Length<=1)
     return 0;
     int maxProfit =0;
     int minBuy=prices[0];
     for(int i = 1 ; i <prices.Length;i++)
     {
        if(prices[i] < minBuy)
        {
            minBuy = prices[i];
        }
        else{
           int currentProfit = prices[i] - minBuy;
            maxProfit = Math.Max(currentProfit,maxProfit);
        }
     }
     return maxProfit;
    }
}

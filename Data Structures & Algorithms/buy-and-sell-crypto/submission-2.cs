public class Solution {
    public int MaxProfit(int[] prices) {
    int l =0;
    int r = 1;
    int maxProfit = 0;
    while(r < prices.Length)
    {
      if(prices[l]  > prices[r])
      {
        //Update the l
        l = r;
      
      }
      else{
        int currentProfit = prices[r]-prices[l];
        maxProfit = Math.Max(currentProfit,maxProfit);
       
      }
       r++;
    }
    return maxProfit;
    }
}

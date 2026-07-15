public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0;
        int h =heights.Length-1;
       int max = int.MinValue;
        while(l<h)
        {
            int width = (h+1) - (l+1);
            int value = width* Math.Min(heights[l],heights[h]);
            max = Math.Max(value,max);
            if(heights[l]<heights[h])
                l++;
            else
                h--;
        }
        return max;
       
    }
}

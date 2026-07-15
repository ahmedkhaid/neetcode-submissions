public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new HashSet<char>();
        int n  = s.Length;
        int maxLength =0;
         int left = 0;
         for(int right = 0 ; right<n;right++)
         {
            while(set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[right]);
            maxLength = Math.Max(right-left+1,maxLength);
         }
        return maxLength;
    }
}

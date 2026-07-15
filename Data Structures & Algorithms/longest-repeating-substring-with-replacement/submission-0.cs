public class Solution {
    public int CharacterReplacement(string s, int k) {
       int longest =0;
       int []counts = new int [26];
       int l=0;
       for(int r =0; r<s.Length;r++)
       {
            int asci = (int)s[r];
            counts[asci -65]++;
            while(((r-l)+1) - counts.Max() > k )
            {
                counts[(int)s[l] - 65]--;
                l++;
            }
            longest = Math.Max(longest,r-l+1);
       }
       return longest; 
    }
}

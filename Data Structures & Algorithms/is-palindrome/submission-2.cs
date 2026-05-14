public class Solution {
     public bool IsPalindrome(string s)
 {
    int h = s.Length-1;
 int l = 0;
 while (l<=h)
 {
     if (!Char.IsLetterOrDigit(s[l]))
     {
         l++;
         continue;
         
     }
     if (!Char.IsLetterOrDigit(s[h])) {
         h--;
         continue;

     }
     else if (Char.ToLower(s[l])==Char.ToLower(s[h])|| s[l]==s[h])
     {
         l++;
         h--;
         
       
     }
     else
     {
         return false;
     }
     

 }
 return true;
 }
}

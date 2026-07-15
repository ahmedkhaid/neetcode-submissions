public class Solution {
    public string MinWindow(string s, string t) {
        int min = int.MaxValue;
        int l=0;
        int r;
        Dictionary<char,int> tDic = new Dictionary<char,int>();
        Dictionary<char,int> sDic = new Dictionary<char,int>();
        string output ="";
        
        int need = t.Length;
        int have = 0;
        for(int i =0; i <t.Length ;i++)
        {
            if(!tDic.ContainsKey(t[i]))
            {
                tDic[t[i]]=1;
            }
            else{
                tDic[t[i]]++;
            }
        }
        for(r = 0; r<s.Length ;r++)
        {
            if(!sDic.ContainsKey( s[r]))
            {
                sDic[s[r]]=1;
            }
            else{
                sDic[s[r]]++;
                
            }
            if (tDic.ContainsKey(s[r]) && sDic[s[r]] <= tDic[s[r]]) {
                 have++;
            }
            while(have == need)
            {
                if(((r-l)+1) < min)
                {
                    min =(r-l)+1;
                    output = s.Substring(l,min);
                }
                sDic[s[l]]--;
                if(tDic.ContainsKey(s[l]) && sDic[s[l]] < tDic[s[l]])
                {
                    have--;
                }
                l++;
                
            } // invalidating the Window
           
        }
        return output;
    }
}

public class Solution {
public string Encode(IList<string> strs)
{
    string res = "";
    for (int i = 0; i<strs.Count; i++) {
       int length = strs[i].Length;
        res += length.ToString() + "#"+strs[i];
    }
    return res;
}

public List<string> Decode(string s)
{
    IList<string> res = new List<string>();
    int i = 0;
    while (i<s.Length) {
        int j = i;
        while (s[j]!='#')
        {
            j++;
        }
        int length =int.Parse(s.Substring(i, j-i));
        i=j+1;
        res.Add(s.Substring(i, length));
        i+=length;
    }
    return res.ToList();
}
}

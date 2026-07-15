public class Solution {
    public bool IsValid(string s) {
        if(s.Length<=1)
            return false;
        Stack<char>sStack = new Stack<char>();
        Dictionary<char,char>validParanthesis = new Dictionary<char,char>{
            [')'] = '(',
            ['}'] = '{',
            [']'] = '['
        };
        for(int i =0; i <s.Length ;i++)
        {
            if(validParanthesis.ContainsKey(s[i])&& sStack.Count()!=0&& validParanthesis[s[i]] == sStack.Peek())
            {
                sStack.Pop();
            }
            else{
            sStack.Push(s[i]);
            }
        }
        if(sStack.Count()==0)
        {
            return true;
        }
        else{
        return false;
        }

    }
}

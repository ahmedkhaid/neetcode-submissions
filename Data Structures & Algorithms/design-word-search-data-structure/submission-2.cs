public class TrieNode{
    public Dictionary<char,TrieNode> children{get;set;}= new Dictionary<char , TrieNode>();
    public bool termination{get;set;}
   
}
public class WordDictionary {
    private TrieNode _root;
    private Stack<TrieNode>Parents;
    public WordDictionary() {
        _root = new TrieNode();
    }
    
    public void AddWord(string word) {
        if(string.IsNullOrEmpty(word))
            return ;
        TrieNode curr = _root;
        foreach(var ch in word)
        {
            if(!curr.children.ContainsKey(ch))
            {
                curr.children[ch] = new TrieNode();
            }
            curr = curr.children[ch];
        }
        curr.termination=true;
        
    }
    
    public bool Search(string word) {
     return DFS(0,_root,word) ;
    }
    public bool DFS(int index,TrieNode node,string word)
    {
        if(string.IsNullOrEmpty(word))
            return false;
        TrieNode curr = node;
        for(int i = index ; i<word.Length;i++)
        {
            if(word[i] == '.')
            {
                foreach(var child in curr.children.Values)
                {
                    if(DFS(i+1,child,word))
                    {
                        return true;
                    }
                }
                return false;
            }
            else{
            if(!curr.children.ContainsKey(word[i]))
            {
                return false;
            }
            curr = curr.children[word[i]];
            }
        }
        return curr.termination;
    }
}

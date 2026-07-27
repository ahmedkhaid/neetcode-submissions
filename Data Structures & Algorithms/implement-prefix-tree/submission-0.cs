public class TrieNode{
 public Dictionary <char,TrieNode> dic{get;set;}=new Dictionary<char,TrieNode>();
 public bool _tremination{get;set;}
 
}
public class PrefixTree {
   private TrieNode _root{get;set;}
  
    public PrefixTree() {
        _root = new TrieNode();    
    }
    
    public void Insert(string word) {
       
        if(string.IsNullOrEmpty(word))
        {
            return;
        }
        TrieNode current = _root;
        foreach(var ch in word)
        {
            if(!current.dic.ContainsKey(ch))
            {
                current.dic[ch] = new TrieNode();
                
            }
            current = current.dic[ch];
        }
        current._tremination=true;
    }
    
    public bool Search(string word) {
        TrieNode curr = _root;
        foreach(var ch in word)
        {
            if(!curr.dic.ContainsKey(ch))
            {
               return false;
            }
            curr = curr.dic[ch];
        }
       return curr._tremination;
    }
    
    public bool StartsWith(string prefix) {
        if(string.IsNullOrEmpty(prefix))
            return false;
         TrieNode curr = _root;
        foreach(var ch in prefix)
        {
            if(!curr.dic.ContainsKey(ch))
            {
               return false;
            }
         curr = curr.dic[ch];
        }
       return true;
    }
}

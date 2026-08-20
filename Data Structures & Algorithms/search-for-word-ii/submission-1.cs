public class Solution {
    public class TrieNode{
       public Dictionary<char,TrieNode> children{get;set;} = new Dictionary<char,TrieNode>();
        public bool termination {get;set;} = false;
    }
    public class Trie{
       public TrieNode _root;
        public Trie()
        {
            _root = new TrieNode();
        }
        public void Insert(string word)
        {

            if(String.IsNullOrEmpty(word))
                return;
            TrieNode curr = _root;
            foreach(var el in word)
            {
                if(!curr.children.ContainsKey(el))
                {
                    curr.children[el] = new TrieNode();
                    
                }
                curr = curr.children[el];
            }
            curr.termination = true;
        }
       
    }
    HashSet<string> result = new HashSet<string>();
    bool[,] visited;
    int row , col;
    char[][] board;
    public List<string> FindWords(char[][] board, string[] words) {
        Trie trie = new Trie();
        this.board = board;
        this.row = board.Length;
        this.col = board[0].Length;
        this.visited = new bool[row,col];
     foreach( var el in words)
     {
        trie.Insert(el);
     }
     
     for(int r = 0 ; r < row ; r++)
     {
        for(int c = 0 ;c  < col ;c++)
        {
            DFS(r,c,trie._root,"");
        }
     }
     return new List<string>(result);
   
    }
    public void DFS(int r , int c , TrieNode node,string word)

    {
        
        if(r < 0 || c < 0 || r >= row || c >=col || visited[r,c]==true)
            return;
        char letter = board[r][c];
        if(!node.children.ContainsKey(letter)) 
            return ;
        visited[r,c] = true;
        word+=letter;
        node = node.children[letter];
        if(node.termination==true)
        {
            result.Add(word);
        }
        DFS(r , c-1 ,node,word);
        DFS(r , c +1 , node,word);
        DFS(r+1,c,node,word);
        DFS(r-1,c,node,word);
        visited[r,c] = false;
    }

}

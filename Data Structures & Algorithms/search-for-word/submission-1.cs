public class Solution 
{
    bool [,]visited;
    int row,col;
    char [][] board;
    string result;
     public bool Exist(char[][] board, string word) {
    this.board = board;
    this.row = board.Length;
    this.col = board[0].Length;
    visited = new bool [row,col];
    result = "";
   
        for(int r = 0 ;r < row ;r++)
        {
            for(int c = 0 ; c < col ;c++)
            {
               if(Dfs(r,c,word,0))
               {
                    return true;
               }
            }
        }
    
       
        return false;
    }
    public bool Dfs(int r , int c ,string word, int index)
    {
        if(index == word.Length)
            return true;
        if(r<0 || c<0|| r>=row || c >= col|| visited[r,c]==true)
            return false;
        char letter = board[r][c];
        
        if(letter != word[index])
            return false;
        visited[r,c]=true;
        bool found= Dfs(r+1 , c ,word , index+1) || Dfs(r-1 , c,word , index+1) || Dfs(r , c+1,word , index+1)||Dfs(r,c-1 ,word, index+1);
        visited[r,c]=false;
        return found;
    }
}

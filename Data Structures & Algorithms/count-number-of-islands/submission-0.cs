public class Solution {
    char[][]grid;
    int numberOfIsland = 0;
    int row , col;
    public int NumIslands(char[][] grid) {
        this.grid = grid;
         row  = grid.Length;
         col = grid[0].Length;
        
            for(int i = 0 ; i < row ; i++)
            {
                for(int j = 0 ; j < col ; j++)
                {
                    if(grid[i][j] =='1' ){
                        numberOfIsland++;
                        Dfs(i,j);
                    }
                }
            }
        return numberOfIsland;
    }
    public void Dfs(int r , int c)
    {
        
        if( r < 0 || r >=row || c < 0 || c>=col  || grid[r][c] =='0')
            return;
        
        grid[r][c]='0';
        Dfs(r , c+1);
        Dfs(r,c-1);
        Dfs(r+1,c);
        Dfs(r-1,c);

    }
}

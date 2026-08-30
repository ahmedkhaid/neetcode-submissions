public class Solution {
    int [][] heights;
    int row , col;
    
    
    public List<List<int>> PacificAtlantic(int[][] heights) {
        List<List<int>> result = new List<List<int>>();
        this.heights = heights;
        row = heights.Length;
        col = heights[0].Length;
        
       
        bool[,] seenP = new bool[row, col];
        bool[,] seenA = new bool[row, col];
        Queue<(int,int)> pQ = new Queue<(int,int)>();
        Queue<(int,int)> aQ = new Queue<(int,int)>();
        
      
        for (int r = 0; r < row; r++) {
            pQ.Enqueue((r, 0));
            seenP[r, 0] = true;
        }
        for (int c = 1; c < col; c++) { 
            pQ.Enqueue((0, c));
            seenP[0, c] = true;
        }
        
      
        for (int c = 0; c < col; c++) {
            aQ.Enqueue((row - 1, c));
            seenA[row - 1, c] = true;
        }
        for (int r = 0; r < row - 1; r++) {
            aQ.Enqueue((r, col - 1));
            seenA[r, col - 1] = true;
        }
        
        GetCoords(pQ, seenP);
        GetCoords(aQ, seenA);
        
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                if (seenA[i, j] && seenP[i, j]) {
                    result.Add(new List<int> { i, j });
                }
            }
        }
        
        return result;
    }
    public void GetCoords(Queue<(int,int)>cells , bool[,]visited)
    {
      int[] dRow = { -1, 1, 0, 0 };
        int[] dCol = { 0, 0, -1, 1 };
        while(cells.Count > 0)
        {
            (int r , int c) = cells.Dequeue();
            for(int i =0; i < 4 ; i++)
            {
                int newRow =r+ dRow[i] ;
                int newCol =c + dCol[i];
              
                if(newRow >=0 && newRow < row && newCol >=0 && newCol < col && visited[newRow,newCol]==false && heights[newRow][newCol] >= heights[r][c])
                {
                    cells.Enqueue((newRow,newCol));
                    visited[newRow,newCol] = true;
                }
            }
        
         }
        
    }
}

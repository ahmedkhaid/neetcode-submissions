public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
     Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();
    // Initialize the list if the target isn't in the dictionary yet
    foreach(var edge in prerequisites){
        int target = edge[0];
        int pre = edge[1];
    if (!adj.ContainsKey(target)) 
    {
        adj[target] = new List<int>();
    }
     adj[target].Add(pre);
    }
    int []states = new int[numCourses];
    // Add the directed edge: target ➔ pre
   
    for(int i = 0 ; i < numCourses ;i++)
    {
        if(!dfs(i,states,adj))
            return false;
    } 
    return true;
    }
    bool dfs(int i,int [] states ,Dictionary<int,List<int>> adj)
    {
       if(states[i] == 1) return false;
       if(states[i]==2) return true;
       states[i]=1;
       if(adj.ContainsKey(i))
       { 
        foreach( var el in adj[i])
        {
            
            if(!dfs(el,states,adj)){
                return false;
            }
        }
       }
        states[i]=2;
        return true; 
    }
}
       


/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Dictionary<Node,Node> nodeToCopy = new Dictionary<Node,Node>();
    public Node Dfs(Node node)
    {
        if(nodeToCopy.ContainsKey(node))
            return nodeToCopy[node];
        Node copy = new Node(node.val);
        nodeToCopy[node] = copy;
        foreach(var ch in node.neighbors)
        {
            copy.neighbors.Add(Dfs(ch));
        }
        return copy;
    }
    public Node CloneGraph(Node node) {

       // loop over the Nei in the frist node Places in teh list 
       //tehn go to the node 4 and place the negit
        if(node !=null)
        {
            return Dfs(node);
        }
        return null;
       }
     
    }


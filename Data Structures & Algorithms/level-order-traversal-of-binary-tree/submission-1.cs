/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
 
public class Solution {
    public List<List<int>> LevelOrder(TreeNode root) {
        
       List<List<int>> lists = new List<List<int>>();
       if(root == null) return lists;
        // Initialize the FIFO Queue
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while (queue.Count > 0) 
        {
            int len = queue.Count;
           List<int>level=new List<int>();
            for(int i =0;i<len;i++)
            {
                
                TreeNode node = queue.Dequeue();
                if(node!=null)
                {
                    level.Add(node.val);
                   if (node.left != null) {
                    queue.Enqueue(node.left);
                }
                if (node.right != null) {
                    queue.Enqueue(node.right);
                }
                }
            }
            lists.Add(level);
           
           
        }
        return lists;
    
      
    }
}

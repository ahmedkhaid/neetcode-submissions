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
    public int KthSmallest(TreeNode root, int k) {
      SortedSet<int>set = new SortedSet<int>();
      Queue<TreeNode> q = new Queue<TreeNode>();
      q.Enqueue(root);
      while(q.Count>0)
      {
        TreeNode node = q.Dequeue();
        set.Add(node.val);
        if(node.left!=null)
        {
            q.Enqueue(node.left);
        }
        if(node.right!=null)
        {
            q.Enqueue(node.right);
        }
      }
      return set.ElementAt(k-1);
    }
}

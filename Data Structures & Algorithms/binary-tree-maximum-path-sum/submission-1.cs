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
    int maxSum;
    public int MaxPathSum(TreeNode root) {
        maxSum = root.val;
         Dfs(root);
        return maxSum;
        
    }
    public int Dfs(TreeNode node){
        
        if(node==null)
        {
            return 0;
        }
        int maxLeft = Dfs(node.left);
        int maxRight = Dfs(node.right);
        maxLeft = Math.Max(maxLeft,0);
        maxRight = Math.Max(maxRight,0);
       maxSum = Math.Max(maxSum,maxLeft+maxRight+node.val);
       return (Math.Max(maxLeft,maxRight) + node.val);
    }
}
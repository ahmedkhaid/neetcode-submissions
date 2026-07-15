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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
       TreeNode min = root;
       while(min!=null){
      if(p.val < min.val && q.val < min.val)
      {
       min = min.left;
        //search in the left subtree
      }
      else if(p.val  > min.val  && q.val  > min.val  )
      {
        //seach in the rightSubTree;
        min = min.right;
      }
      else{
        //Traversel in the  right subTree and leftSubtre
       return min;
      }
    }
    return min;
    }
}

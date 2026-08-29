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

public class Codec {
    Queue<TreeNode>tree = new Queue<TreeNode>();
    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        List<string>res = new List<string>();
       if(root == null)
       {
        return "";
       }
       Queue<TreeNode>q = new Queue<TreeNode>();
       q.Enqueue(root);
       while(q.Count > 0)
       {
        TreeNode curr = q.Dequeue();
        if(curr!=null)
        {
            q.Enqueue(curr.left);
            q.Enqueue(curr.right);
            res.Add(curr.val.ToString());
        
        }
        else{
            res.Add("n");
        }
       }
       return string.Join(",", res);
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        if(string.IsNullOrEmpty(data))
            return null;
     string[] val = data.Split(',');
     Queue<TreeNode>q = new Queue<TreeNode>();
     TreeNode root = new TreeNode(int.Parse(val[0]));
     q.Enqueue(root);
     int i =1 ;
     int length = data.Length;
     while(i <length && q.Count > 0)
     {
        TreeNode temp = q.Dequeue();
        if(val[i]!="n")
        {
            temp.left = new TreeNode(int.Parse(val[i]));
            q.Enqueue(temp.left);
        }
        i++;
        if(i < length &&val[i]!="n")
        {
            temp.right = new TreeNode(int.Parse(val[i]));
            q.Enqueue(temp.right);
        }
        i++;
     }
     return root;
    }
}

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

    public int MaxPathSum(TreeNode root) {
        int res = root.val;

        Dfs(root, ref res);

        return res;
    }

    private int Dfs(TreeNode root, ref int res)
    {
        if(root == null)
        {
            return 0;
        }

        int maxLeft = Math.Max(0, Dfs(root.left, ref res));
        int maxRight = Math.Max(0, Dfs(root.right, ref res));

        res = Math.Max(res, root.val + maxLeft + maxRight);
        return root.val + Math.Max(maxLeft, maxRight);
    }
}

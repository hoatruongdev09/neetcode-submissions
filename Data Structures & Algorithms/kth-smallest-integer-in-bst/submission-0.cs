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
    int currentK;
    int smallest = 0;
    public int KthSmallest(TreeNode root, int k) {
        currentK = k;
        DFS(root);
        return smallest;
    }

    private void DFS(TreeNode root)
    {
        if(root == null)
        {
            return;
        }
        DFS(root.left);
        currentK--;
        if(currentK == 0)
        {
            smallest = root.val;
            return;
        }
        DFS(root.right);
    }
}

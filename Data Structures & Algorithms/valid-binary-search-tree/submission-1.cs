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
    private int previousValue = int.MinValue;
    public bool IsValidBST(TreeNode root) {
        if(root == null)
        {
            return true;
        }
        bool leftCheck = IsValidBST(root.left);
        bool currentCheck = root.val > previousValue;
        previousValue = root.val;
        bool rightCheck = IsValidBST(root.right);
        return leftCheck && currentCheck && rightCheck;
    }
    
}

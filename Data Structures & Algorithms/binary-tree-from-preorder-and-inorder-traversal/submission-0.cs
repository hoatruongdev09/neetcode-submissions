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
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        if (preorder == null || preorder.Length == 0)
        {
            return null;
        }
        TreeNode root = new(preorder[0]);
        int mid = FindIndex(inorder, preorder[0]);
        root.left = BuildTree(Extract(preorder, 1, mid + 1), Extract(inorder, 0, mid));
        root.right = BuildTree(Extract(preorder, mid + 1, preorder.Length), Extract(inorder, mid + 1, inorder.Length));

        return root;
    }

    private int[] Extract(int[] arr, int start, int end)
    {
        if (arr == null)
        {
            return null;
        }
        if (end > arr.Length)
        {
            return null;
        }
        if (start < 0)
        {
            return null;
        }
        if (end - start == 0)
        {
            return null;
        }
        if ((end - start) > arr.Length)
        {
            return null;
        }
        int[] result = new int[(end - start)];
        for (int i = start; i < end; i++)
        {
            result[i - start] = arr[i];
        }
        return result;
    }

    private int FindIndex(int[] arr, int value)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == value)
            {
                return i;
            }
        }
        return -1;
    }
}

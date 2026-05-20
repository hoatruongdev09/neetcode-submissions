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
        List<TreeNode> pathToP = new();
        List<TreeNode> pathToQ = new();  
        BuildPath(root, p, new(), pathToP);
        BuildPath(root, q, new(), pathToQ);

        List<TreeNode> pathComparer = pathToP.Count < pathToQ.Count ? pathToP : pathToQ;
        List<TreeNode> pathComparee = pathToP.Count >= pathToQ.Count ? pathToP : pathToQ;

        TreeNode lca = null;
        for(int i = 0; i < pathComparer.Count; i++)
        {
            if(pathComparer[i] != pathComparee[i])
            {
                break;
            }
            lca = pathComparer[i];
        }
        return lca;
    }

    private void BuildPath(TreeNode root, TreeNode target, List<TreeNode> current, List<TreeNode> outPut)
    {
        if(root == null)
        {
            return;
        }
        current.Add(root);
        if(root.val == target.val)
        {
            outPut.AddRange(current);
        }
        BuildPath(root.left, target, new(current), outPut);
        BuildPath(root.right, target, new(current), outPut);
    }

}

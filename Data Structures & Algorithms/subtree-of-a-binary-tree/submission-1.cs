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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (root == null) {
            return false;
        }

        if (subRoot == null) {
            return true;
        }

        if (IsSameTree1(root, subRoot)) {
            return true;
        }

        return (IsSubtree(root.right, subRoot) || IsSubtree(root.left, subRoot));
    }

    public bool IsSameTree1(TreeNode p, TreeNode q) {
        if ((p == null && q == null)) {
            return true;
        }

        if (p == null || q == null || p.val != q.val) {
            return false;
        }

        return (IsSameTree1(p.left, q.left) && IsSameTree1(p.right, q.right));
    }
}

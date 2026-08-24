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

        if (IsSameTree(root, subRoot)) {
            return true;
        }

        return (IsSubtree(root.right, subRoot) || IsSubtree(root.left, subRoot));
    }

    public bool IsSameTree(TreeNode p, TreeNode q) {
        Queue<TreeNode> Qp = new Queue<TreeNode>();
        Queue<TreeNode> Qq = new Queue<TreeNode>();

        Qp.Enqueue(p);
        Qq.Enqueue(q);

        while (Qp.Count > 0 && Qq.Count > 0) {
            for (int i = Qp.Count; i > 0; i--) {
                TreeNode nodeP = Qp.Dequeue();
                TreeNode nodeQ = Qq.Dequeue();

                if (nodeP == null && nodeQ == null)
                    continue;

                if ((nodeP == null && nodeQ != null) || (nodeP != null && nodeQ == null) ||
                    (nodeP.val != nodeQ.val)) {
                    return false;
                }

                Qp.Enqueue(nodeP.right);
                Qp.Enqueue(nodeP.left);
                Qq.Enqueue(nodeQ.right);
                Qq.Enqueue(nodeQ.left);
            }
        }
        return true;
    }
}

namespace Codelet
{
    /// <summary>
    /// Tree node
    /// </summary>
    public class TreeNode
    {
        /// <summary>
        /// Left node
        /// </summary>
        public TreeNode Left { get; private set; }

        /// <summary>
        /// Right node
        /// </summary>
        public TreeNode Right { get; private set; }

        /// <summary>
        /// Node value
        /// </summary>
        public object Data { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="left">Left node</param>
        /// <param name="right">Right node</param>
        /// <param name="data">Node data</param>
        public TreeNode(TreeNode left, TreeNode right, object data)
        {
            this.Left = left;
            this.Right = right;
            this.Data = data;
        }
    }

    /// <summary>
    /// Binary Tree
    /// </summary>
    public class BinaryTree
    {
        /// <summary>
        /// Root node of a tree
        /// </summary>
        public TreeNode Root { get; private set; }

        /// <summary>
        /// Tree height
        /// </summary>
        public int Height
        {
            get
            {
                return BinaryTree.GetHeight(this.Root);
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="root">Root node of a tree</param>
        public BinaryTree(TreeNode root)
        {
            this.Root = root;
        }

        /// <summary>
        /// Get tree height
        /// </summary>
        /// <param name="root">Root node of a tree</param>
        /// <returns>Tree height</returns>
        private static int GetHeight(TreeNode root)
        {
            if (root == null)
                return 0;
            else
            {
                return Math.Max(BinaryTree.GetHeight(root.Left), BinaryTree.GetHeight(root.Right)) + 1;
            }
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codelet.Tests
{
    [TestClass()]
    public class BinaryTreeTests
    {
        /// <summary>
        ///Test case to get height of a tree with 4 levels
        /// </summary>
        [TestMethod()]
        public void BinaryTreeTest1()
        {
            // Construct a tree with 4 levels (A,B, C, D, E, null, F, G, H, I, null, null, null, J)

            // Depth level 4
            TreeNode leafG = new TreeNode(null, null, "G");
            TreeNode leafH = new TreeNode(null, null, "H");
            TreeNode leafI = new TreeNode(null, null, "I");
            TreeNode leafJ = new TreeNode(null, null, "J");

            // Depth level 3
            TreeNode leafD = new TreeNode(leafG, leafH, "D");
            TreeNode leafE = new TreeNode(leafI, null, "E");
            TreeNode leafF = new TreeNode(leafJ, null, "F");

            // Depth level 2
            TreeNode leafB = new TreeNode(leafD, leafE, "B");
            TreeNode leafC = new TreeNode(null, leafF, "C");

            // Depth level 1
            TreeNode leafA = new TreeNode(leafB, leafC, "A");

            BinaryTree tree = new BinaryTree(leafA);

            Assert.IsTrue(tree.Height == 4);
        }

        /// <summary>
        /// Test case to get height of a tree with only a root node
        /// </summary>
        [TestMethod()]
        public void BinaryTreeTest2()
        {
            // Construct a tree with only a root node
            TreeNode root = new TreeNode(null, null, "A");
            BinaryTree tree = new BinaryTree(root);

            Assert.IsTrue(tree.Height == 1);
        }

        /// <summary>
        /// Test case to get height of a tree with null root
        /// </summary>
        [TestMethod()]
        public void BinaryTreeTest3()
        {
            // Construct a tree with a null root
            TreeNode root = null;
            BinaryTree tree = new BinaryTree(root);

            Assert.IsTrue(tree.Height == 0);
        }
    }
}

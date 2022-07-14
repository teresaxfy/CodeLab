using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codelet.Tests
{
    [TestClass()]
    public class BinaryTreeTests
    {
        [TestMethod()]
        public void BinaryTreeTest()
        {
            // Construct a tree with only a root node
            TreeNode root = new TreeNode(null, null, String.Empty);
            BinaryTree tree1 = new BinaryTree(root);

            Assert.IsTrue(tree1.Height == 1);

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

            BinaryTree tree2 = new BinaryTree(leafA);

            Assert.IsTrue(tree2.Height == 4);
        }
    }
}

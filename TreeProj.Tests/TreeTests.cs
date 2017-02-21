using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeProj.Tests
{
    [TestClass]
    public class TreeTests
    {
        [TestMethod]
        public void CreateTree1()
        {
            var treeNodeA = new TreeNode("A");
            var treeNodeB = new TreeNode("B");
            var treeNodeC = new TreeNode("C");
            var treeNodeD = new TreeNode("D");
            treeNodeA.Children = new TreeNodeList(treeNodeB, treeNodeC);            
            treeNodeB.Children = new TreeNodeList(treeNodeD);

            var tree = new TreeNodeList(treeNodeA);

            foreach (var treeNode in tree.AsDepthFirstIterator())
            {
                Console.WriteLine(treeNode.Name);
            }

            Console.WriteLine("");
            foreach (var treeNode in tree.AsBreadthFirstIterator())
            {
                Console.WriteLine(treeNode.Name);
            }
        }

    }
}

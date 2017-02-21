using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProj
{
    public static class TreeNodeExtensions
    {
        /// <summary>
        /// Creates an iterator that traverses the tree breadth first.
        /// </summary>
        /// <param name="taxonTreeNodeList">The Taxon tree node list.</param>        
        public static IEnumerable<TreeNode> AsBreadthFirstIterator(this TreeNodeList taxonTreeNodeList)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            foreach (TreeNode taxonTreeNode in taxonTreeNodeList)
            {
                q.Enqueue(taxonTreeNode);
            }

            while (q.Any())
            {
                TreeNode current = q.Dequeue();
                if (current != null)
                {
                    if (current.Children != null)
                    {
                        foreach (TreeNode childNode in current.Children)
                        {
                            q.Enqueue(childNode);
                        }
                    }

                    yield return current;
                }
            }
        }

        /// <summary>
        /// Creates an iterator that traverses the tree depth first.
        /// </summary>
        /// <param name="taxonTreeNodeList">The Taxon tree node list.</param>        
        public static IEnumerable<TreeNode> AsDepthFirstIterator(this TreeNodeList taxonTreeNodeList)
        {
            Stack<TreeNode> q = new Stack<TreeNode>();
            foreach (TreeNode taxonTreeNode in taxonTreeNodeList)
            {
                q.Push(taxonTreeNode);
            }

            while (q.Any())
            {
                TreeNode current = q.Pop();
                if (current != null)
                {
                    if (current.Children != null)
                    {
                        for (int i = current.Children.Count - 1; i >= 0; i--)
                        {
                            q.Push(current.Children[i]);
                        }
                    }

                    yield return current;
                }
            }
        }
    }
}

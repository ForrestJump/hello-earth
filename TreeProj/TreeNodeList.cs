using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProj
{
    public class TreeNodeList : List<TreeNode>
    {
        public TreeNodeList()
        {
            
        }

        public TreeNodeList(TreeNode treeNode)
        {
            Add(treeNode);
        }

        public TreeNodeList(params TreeNode[] treeNodes)
        {
            AddRange(treeNodes);
        }
    }
}

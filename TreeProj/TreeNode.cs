using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProj
{
    public class TreeNode
    {
        public String Name { get; set; } 
        public TreeNodeList  Children { get; set; }

        public TreeNode(string name)
        {
            Name = name;
        }

        public TreeNode(string name, TreeNodeList children)
        {
            Name = name;
            Children = children;
        }
    }
}

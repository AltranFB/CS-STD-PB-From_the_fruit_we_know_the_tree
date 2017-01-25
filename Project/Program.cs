using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromTheFruitWeKnowTheTree
{
    public class Node
    {
        public Node Left, Right;
        public int Value;
        public Node(int val)
        {
            this.Value = val;
            this.Left = null;
            this.Right = null;
        }

        public Node Find(int value)
        {
            return null;
        }

        static void Main(string[] args)
        {
        }
    }
}
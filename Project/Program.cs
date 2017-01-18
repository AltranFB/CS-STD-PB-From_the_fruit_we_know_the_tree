using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
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
            Node current = this;
            while (current != null)
            {
                if (current.Value == value)
                {
                    return current;
                }
                else if (current.Value > value)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            return null;
        }

        static void Main(string[] args)
        {
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace Project
{
    [TestClass]
    public class Tests
    {
        private Node TreeRoot;
        
        [TestInitialize()]
        public void Init()
        {
            TreeRoot = new Node(9);
            TreeRoot.Left = new Node(7);
            TreeRoot.Left.Left = new Node(5);
            TreeRoot.Left.Right = new Node(8);
            TreeRoot.Left.Left.Left = new Node(2);
            TreeRoot.Left.Left.Right = new Node(6);
            TreeRoot.Right = new Node(13);
            TreeRoot.Right.Right = new Node(17);
            TreeRoot.Right.Left = new Node(16);
        }

        [TestMethod]
        public void SmallTree()
        {
            Node n = TreeRoot.Find(8);
            Check.That(n).IsNotNull();
            Check.That(n.Value).Equals(8);
        }

        [TestMethod]
        public void NodeDoesntExist()
        {
            Node n = TreeRoot.Find(4);
            Check.That(n).IsNull();
        }
    }
}
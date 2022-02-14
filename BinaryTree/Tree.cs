namespace BinaryTree
{
    public class Tree
    {
        private Node _root;
        public Tree()
        {
            _root = null;
        }

        public void Add(int value)
        {
            Node newNode = new(value);

            if (_root == null)
            {
                _root = newNode;
            }
            else
            {
                InsertNode(_root, newNode);
            }
        }
        private void InsertNode(Node root, Node newNode)
        {
            if (root == null)
                root = newNode; //if passed node has no root setup gives newnode as root

            if (root.Data > newNode.Data)
            {
                if (newNode.Data < root.Data)
                    if (root.Left == null)
                        root.Left = newNode;
                    else
                        InsertNode(root.Left, newNode);
            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertNode(root.Right, newNode);
            }
        }
        private void DisplayTree(Node root)
        {
            if (root == null)
                return;

            DisplayTree(root.Left);
            System.Console.Write(root.Data + " ");
            DisplayTree(root.Right);
        }
        public void DisplayTree()
        {
            DisplayTree(_root);
        }
    }
}

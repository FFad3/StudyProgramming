using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new();
            tree.Add(10);
            tree.Add(7);
            tree.Add(3);
            tree.Add(12);
            tree.Add(9);
            tree.Add(14);
            tree.Add(1);

            tree.DisplayTree();
        }
    }
}

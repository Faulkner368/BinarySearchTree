using System;

public class BinarySearchTree
{
    public static void Main(string[] args)
    {

        Node n1 = new Node(5, null, null);
        Node n2 = new Node(12, null, null);
        Node n3 = new Node(28, null, null);
        Node n4 = new Node(38, null, null);
        Node n5 = new Node(48, null, null);
        Node n6 = new Node(10, n1, n2);
        Node n7 = new Node(22, null, null);
        Node n8 = new Node(30, n3, null);
        Node n9 = new Node(40, n4, n5);
        Node n10 = new Node(20, n6, n7);
        Node n11 = new Node(36, n8, n9);
        Node n12 = new Node(25, n10, n11);

        Console.WriteLine(Contains(n12, 12));
    }
	
    public static bool Contains(Node root, int value)
    {
        Console.WriteLine(root.Value);

        var found = false;

        if (root.Value == value)
        {
            found = true;
            return found;
        }

        if (value <= root.Value && root.Left != null)
        {

            found = Contains(root.Left, value);
        }
        else if (value > root.Value && root.Right != null)
        {
            found = Contains(root.Right, value);
        }

        return found;
    }

    public class Node
    {
        public int Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node(int value, Node left, Node right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
}
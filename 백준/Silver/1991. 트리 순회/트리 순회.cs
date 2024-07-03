using System.Text;

namespace testcoding
{
    internal class Program
    {
        class Node
        {
            public char Value;
            public Node Left;
            public Node Right;
            public Node(char value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }

        static void PreorderTraversal(Node node, StringBuilder result)
        {
            if (node == null) return;
            result.Append(node.Value);
            PreorderTraversal(node.Left, result);
            PreorderTraversal(node.Right, result);
        }

        static void InorderTraversal(Node node, StringBuilder result)
        {
            if (node == null) return;
            InorderTraversal(node.Left, result);
            result.Append(node.Value);
            InorderTraversal(node.Right, result);
        }

        static void PostorderTraversal(Node node, StringBuilder result)
        {
            if (node == null) return;
            PostorderTraversal(node.Left, result);
            PostorderTraversal(node.Right, result);
            result.Append(node.Value);
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<Char, Node> nodes = new Dictionary<Char, Node>();

            Node root = null;

            for (int i = 0; i < N; ++i)
            {
                string[] input = Console.ReadLine().Split();
                char value = input[0][0];
                char left = input[1][0];
                char right = input[2][0];

                if (!nodes.ContainsKey(value))
                {
                    nodes[value] = new Node(value);
                }

                if (left != '.')
                {
                    if (!nodes.ContainsKey(left))
                    {
                        nodes[left] = new Node(left);
                    }
                    nodes[value].Left = nodes[left];
                }

                if (right != '.')
                {
                    if (!nodes.ContainsKey(right))
                    {
                        nodes[right] = new Node(right);
                    }
                    nodes[value].Right = nodes[right];
                }

                if (root == null)
                {
                    root = nodes[value];
                }

            }

            StringBuilder preorderResult = new StringBuilder();
            StringBuilder inorderResult = new StringBuilder();
            StringBuilder postorderResult = new StringBuilder();

            PreorderTraversal(root, preorderResult);
            InorderTraversal(root, inorderResult);
            PostorderTraversal(root, postorderResult);

            Console.WriteLine(preorderResult.ToString());
            Console.WriteLine(inorderResult.ToString());
            Console.WriteLine(postorderResult.ToString());
        }
    }
}
using System.Xml;

namespace CodeRunnerBinTree;

public class BinTreeNode<T> {
    public T Value { get; set; }
    public BinTreeNode<T> Left { get; set; }
    public BinTreeNode<T> Right { get; set; }

    public BinTreeNode(T value, BinTreeNode<T> left = null, BinTreeNode<T> right = null) {
        Value = value;
        Left = left;
        Right = right;
    }

    public static BinTreeNode<char> CreateTreeOfChars() {
        var startArray = new[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
        var nodes = new BinTreeNode<char>[startArray.Length];
        for (int i = 0; i < startArray.Length; i++) {
            nodes[i] = new BinTreeNode<char>(startArray[i]);
        }

        for (int i = 0; i < nodes.Length; i++) {
            var lefChildIndex = 2 * i + 1;
            var rightChildIndex = 2 * i + 2;
            if (lefChildIndex < nodes.Length) {
                nodes[i].Left = nodes[lefChildIndex];
            }

            if (rightChildIndex < nodes.Length) {
                nodes[i].Right = nodes[rightChildIndex];
            }
        }
        return nodes[0];
    }

    public static void Print<T>(BinTreeNode<T> p, int level = 0) {
        if (p == null) return;
        Print(p.Right, level + 1);
        Console.WriteLine("".PadLeft(level, '.') + p.Value);
        Print(p.Left, level + 1);
    }
}
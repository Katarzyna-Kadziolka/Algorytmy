namespace FriendCircle;

public class DisjointSet {
    private readonly Dictionary<string, string> _parent = new Dictionary<string, string>();
    private readonly Dictionary<string, int> _rank = new Dictionary<string, int>();
    private readonly Dictionary<string, int> _size = new Dictionary<string, int>();

    public void MakeSet(string x) {
        _parent[x] = x;
        _rank[x] = 0;
        _size[x] = 1;
    }

    public string FindSet(string x) {
        if (!_parent.ContainsKey(x))
        {
            return null;
        }

        if (_parent[x] != x)
        {
            _parent[x] = FindSet(_parent[x]);
        }

        return _parent[x];
    }

    public void Union(string x, string y) {
        string xRoot = FindSet(x);
        string yRoot = FindSet(y);

        if (xRoot == yRoot) {
            return;
        }

        if (_rank[xRoot] < _rank[yRoot]) {
            _parent[xRoot] = yRoot;
            _size[yRoot] += _size[xRoot];
        }
        else if (_rank[xRoot] > _rank[yRoot]) {
            _parent[yRoot] = xRoot;
            _size[xRoot] += _size[yRoot];
        }
        else {
            _parent[yRoot] = xRoot;
            _rank[xRoot] = _rank[xRoot] + 1;
            _size[xRoot] += _size[yRoot];
        }
    }

    public int GetSetSize(string x) {
        string root = FindSet(x);
        return _size[root];
    }
}
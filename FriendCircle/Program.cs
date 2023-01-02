using System.Text;
using Helpers;

ConsoleHelper.RedirectInputToFile();

var numberOfCases = Convert.ToInt32(Console.ReadLine());
for (int caseNumber = 1; caseNumber <= numberOfCases; caseNumber++) {
    var numberOfNewRelations = Convert.ToInt32(Console.ReadLine());
    var relations = new DisjointSet();
    var answer = new StringBuilder();
    var firstRelation = Console.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries) 
                      ?? Array.Empty<string>();
    relations.MakeSet(firstRelation[0]);
    relations.MakeSet(firstRelation[1]);
    relations.Union(firstRelation[0], firstRelation[1]);
    answer.AppendLine("2");
    for (int i = 1; i < numberOfNewRelations; i++) {
        var newRelation = Console.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries) 
                          ?? Array.Empty<string>();
        var firstSet = relations.FindSet(newRelation[0]);
        var secondSet = relations.FindSet(newRelation[1]);
        if (firstSet is not null && secondSet is not null) {
            relations.Union(firstSet, secondSet);
            answer.AppendLine(relations.GetSetSize(firstSet).ToString());
        }
        else if (firstSet is not null) {
            relations.MakeSet(newRelation[1]);
            relations.Union(firstSet, newRelation[1]);
            answer.AppendLine(relations.GetSetSize(firstSet).ToString());

        }
        else if (secondSet is not null){
            relations.MakeSet(newRelation[0]);
            relations.Union(secondSet, newRelation[0]);
            answer.AppendLine(relations.GetSetSize(secondSet).ToString());
        }
        else {
            relations.MakeSet(newRelation[0]);
            relations.MakeSet(newRelation[1]);
            relations.Union(newRelation[0], newRelation[1]);
            answer.AppendLine("2");
        }
        
    }
    Console.WriteLine(answer);
}

public class DisjointSet {
    private readonly Dictionary<string, string> _parent = new();
    private readonly Dictionary<string, int> _rank = new ();
    private readonly Dictionary<string, int> _size = new ();

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
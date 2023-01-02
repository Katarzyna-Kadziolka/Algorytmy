using System.Text;
using Helpers;

ConsoleHelper.RedirectInputToFile();

var numberOfCases = Convert.ToInt32(Console.ReadLine());
for (int caseNumber = 1; caseNumber <= numberOfCases; caseNumber++) {
    var numberOfNewRelations = Convert.ToInt32(Console.ReadLine());
    var numberOfConsideredRelations = 0;
    var relations = new List<HashSet<string>>();
    var answer = new StringBuilder();
    while (numberOfNewRelations != numberOfConsideredRelations) {
        var newRelation = Console.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries) 
                                           ?? Array.Empty<string>();
        var relationsIndexes = new []{-1, -1};
        for (int i = 0; i < relationsIndexes.Length; i++) {
            var index = relations.FindIndex(a => a.Contains(newRelation[i]));
            relationsIndexes[i] = index;
        }

        if (relationsIndexes.All(a => a != -1)) {
            var newSet = new HashSet<string>(relations[relationsIndexes[0]].Union(relations[relationsIndexes[1]]));
            relations[relationsIndexes[0]].UnionWith(relations[relationsIndexes[1]]);
            answer.AppendLine(newSet.Count.ToString());
        }
        else if (relationsIndexes.All(a => a == -1)) {
            relations.Add(new HashSet<string>{newRelation[0], newRelation[1]});
            answer.AppendLine("2");
        }
        else {
            foreach (var index in relationsIndexes) {
                if (index != -1) {
                    var newSet = new HashSet<string>(relations[index].Union(newRelation));
                    relations[index].UnionWith(newRelation);
                    answer.AppendLine(newSet.Count.ToString());
                }
            }
        }

        numberOfConsideredRelations++;
    }
    Console.WriteLine(answer);
}
    
using SQLike;

Console.WriteLine("Adam".SQLike("A%a"));
Console.WriteLine("Agnieszka".SQLike("A%a")); //true
Console.WriteLine("agnieszka".SQLike("A%a"));
Console.WriteLine("Agnieszka".SQLike("%_a")); //true
Console.WriteLine("a".SQLike("%_a"));
Console.WriteLine("alab".SQLike("%"));

Console.WriteLine();

Console.WriteLine("".SQLike(""));
Console.WriteLine("a".SQLike(""));
Console.WriteLine("".SQLike("a"));
Console.WriteLine("".SQLike("_"));
Console.WriteLine("".SQLike("%"));

Console.WriteLine();

Console.WriteLine("a".SQLike("_"));
Console.WriteLine("aa".SQLike("_"));
Console.WriteLine("a".SQLike("%"));
Console.WriteLine("aa".SQLike("%"));
Console.WriteLine("a".SQLike("_%"));
Console.WriteLine("aa".SQLike("_%"));
Console.WriteLine("aaa".SQLike("_%"));
Console.WriteLine("".SQLike("_%"));
Console.WriteLine("a".SQLike("%_"));
Console.WriteLine("aa".SQLike("%_"));
Console.WriteLine("aaa".SQLike("%_"));
Console.WriteLine("".SQLike("%_"));

Console.WriteLine();

Console.WriteLine("baaabab".SQLike("%%%ba%%ab"));
Console.WriteLine("baaabab".SQLike("_%%ba%%ab"));
Console.WriteLine("baaabab".SQLike("%_%ba%%ab"));
Console.WriteLine("baaabab".SQLike("baaabab"));
Console.WriteLine("baaabab".SQLike("baabab"));
Console.WriteLine("baabab".SQLike("baaabab"));
Console.WriteLine("baaabab".SQLike("%b%b"));

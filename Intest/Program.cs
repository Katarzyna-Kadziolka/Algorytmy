Helpers.ConsoleHelper.RedirectInputToFile();

var parameters = Console.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries);
var numberOfLines = Convert.ToInt64(parameters?[0]);
var divider = Convert.ToInt64(parameters?[1]);
long numberOfDivisibleNumbers = 0;
for (int i = 0; i < numberOfLines; i++) {
    var number = Convert.ToInt64(Console.ReadLine());
    if (number % divider == 0) {
        numberOfDivisibleNumbers += 1;
    }
}
Console.WriteLine(numberOfDivisibleNumbers);


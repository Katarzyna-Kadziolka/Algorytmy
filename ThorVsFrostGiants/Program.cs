Helpers.ConsoleHelper.RedirectInputToFile();

var quantum = Convert.ToInt32(Console.ReadLine());
var giants = Array.ConvertAll(Console.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                              ?? Array.Empty<string>(), int.Parse);
var shift = 0;
for (int k = 0; k < quantum; k++) {
    for (int i = 0; i < giants.Length; i++) {
        var powerMultiplier = 1;
        for (int j = i; j < shift + i + 1; j++) {
            if (j >= giants.Length) {
                break;
            }
            powerMultiplier *= giants[j];
        }

        if (powerMultiplier % quantum == 0) {
            Console.WriteLine($"{i} {i + shift}");
            return;
        }
    }

    shift++;
}
Console.WriteLine(-1);
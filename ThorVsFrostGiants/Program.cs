Helpers.ConsoleHelper.RedirectInputToFile();

var quantum = Convert.ToInt32(Console.ReadLine());
var giants = Array.ConvertAll(Console.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                              ?? Array.Empty<string>(), int.Parse);
var shift = 0;
for (int k = 0; k < quantum; k++) {
    var powerMultiplier = 1;
    for (int i = 0; i < giants.Length; i++) {
        if (i == 0 && shift == 0) {
            for (int j = 0; j < giants.Length; j++) {
                if (giants[j] % quantum == 0) {
                    Console.WriteLine($"{j} {j}");
                    return;
                }
            }
        }
        for (int j = i; j < shift + i; j++) {
            if (j >= giants.Length || j + shift >= giants.Length) {
                break;
            }

            if (j == 0) {
                for (int l = j; l < shift + 1; l++) {
                    powerMultiplier *= giants[l];
                }
            }
            else {
                powerMultiplier = (powerMultiplier / (giants[j - 1]) * giants[j + shift]);

            }
        }

        if (powerMultiplier % quantum == 0) {
            Console.WriteLine($"{i} {i + shift}");
            return;
        }
        
    }

    shift++;
}
Console.WriteLine(-1);
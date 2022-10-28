Helpers.ConsoleHelper.RedirectInputToFile();

var caseNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < caseNumber; i++) {
    var parameters = Array.ConvertAll(Console.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries) 
                                       ?? Array.Empty<string>(), int.Parse);
    var numberOfStations = parameters[0];
    var maximumAmountOfPeople = parameters[1];
    var peopleOnStations = Array.ConvertAll(Console.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries) 
                                      ?? Array.Empty<string>(), int.Parse);
    var numberOfSeenPeople = 0;
    var numberOfStation = 0;

    var maxNumberOfStation = 0;
    var amountOfPeopleForMaxNumberOfStation = 0;
    
    for (int j = 0; j < numberOfStations; j++) {
        for (int k = j+numberOfStation; k < peopleOnStations.Length; k++) {
            if (numberOfSeenPeople + peopleOnStations[k] > maximumAmountOfPeople) {
                break;
            }
            numberOfSeenPeople += peopleOnStations[k];
            numberOfStation++;
        }

        if (maxNumberOfStation < numberOfStation || (maxNumberOfStation == numberOfStation && numberOfSeenPeople < amountOfPeopleForMaxNumberOfStation)) {
            maxNumberOfStation = numberOfStation;
            amountOfPeopleForMaxNumberOfStation = numberOfSeenPeople;
        }

        numberOfSeenPeople -= peopleOnStations[j];
        numberOfStation --;
    }
    Console.WriteLine($"{amountOfPeopleForMaxNumberOfStation} {maxNumberOfStation}");
} 
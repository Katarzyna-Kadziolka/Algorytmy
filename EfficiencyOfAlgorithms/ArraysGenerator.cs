namespace EfficiencyOfAlgorithms; 

public static class ArraysGenerator {
    
    public static int[] GenerateRandom(int size) {
        var numbers = new int[size];
        for (int i = 0; i < size; i++) {
            numbers[i] = Random.Shared.Next();
        }

        return numbers;
    }
    public static int[] GenerateSorted(int size) {
        var numbers = new int[size];
        var startNumber = Random.Shared.Next(int.MinValue, int.MaxValue - size);
        for (int i = 0; i < size; i++) {
            numbers[i] = startNumber + i;
        }

        return numbers;
    }
    public static int[] GenerateReversed(int size) {
        var numbers = new int[size];
        var startNumber = Random.Shared.Next(int.MinValue + size, int.MaxValue);
        for (int i = 0; i < size; i++) {
            numbers[i] = startNumber - i;
        }

        return numbers;
    }
    public static int[] GenerateAlmostSorted(int size) {
        var numbers = new int[size];
        for (int i = 0; i < size; i++) {
            if (i % 20 == 0) {
              numbers[i] = Random.Shared.Next();  
            }
            else {
                numbers[1] = i;
            }
        }

        return numbers;
    }
    public static int[] GenerateFewUnique(int size) {
        var numberToChoose = GenerateRangeForFewUnique(size);
        
        var numbers = new int[size];
        for (int i = 0; i < size; i++) {
            var randomIndex = Random.Shared.Next(0, numberToChoose.Length - 1);
            numbers[i] = numberToChoose[randomIndex];
        }

        return numbers;
    }

    private static int[] GenerateRangeForFewUnique(int size) {
        var numberOfUniqueElements = Convert.ToInt32(Math.Ceiling((double) (size / 10)));
        var numberToChoose = new int[numberOfUniqueElements];
        for (int i = 0; i < numberOfUniqueElements; i++) {
            numberToChoose[i] = Random.Shared.Next();
        }

        return numberToChoose;
    }
}
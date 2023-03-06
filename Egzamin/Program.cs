// See https://aka.ms/new-console-template for more information

// int SubSequence(int[] sequence, int sum) {
//     var range = 1;
//     for (int i = range; i < sequence.Length; i++) {
//         var rangeSum = 0;
//         for (int j = 0; j < sequence.Length - 1; j++) {
//             if (j > i) break;
//             rangeSum += sequence[j];
//         }
//
//         if (rangeSum >= sum) return i;
//     }
//
//     return 0;
// }

static int SubSequence(int[] sequence, int sum) {
    int start = 0, currentSum = 0, length = sequence.Length;
    int currentLength = length + 1;
    for (int end = 0; end < length; end++) {
        currentSum += sequence[end];
        while (currentSum >= sum && start <= end) {
            currentLength = Math.Min(currentLength, end - start + 1);
            currentSum -= sequence[start];
            start++;
        }
    }
    return currentLength <= length ? currentLength : 0;
}

int[] myArray1 = {2,3,1,2,4,3};
Console.WriteLine(SubSequence(myArray1, 7));

int[] myArray2 = {1,4,4};
Console.WriteLine(SubSequence(myArray2, 4));

int[] myArray3 = {1,1,1,1,1,1,1,1};
Console.WriteLine(SubSequence(myArray3, 11));
using BenchmarkDotNet.Attributes;

namespace EfficiencyOfAlgorithms; 

public class Sorter {
    [Params(10, 1000, 100_000)]
    public int arraySize;
    [ParamsSource(nameof(Arrays))]
    public ArrayParam ArrayParam;

    public List<ArrayParam> Arrays() => new() {
        new ArrayParam("Random", ArraysGenerator.GenerateRandom(arraySize)),
        new ArrayParam("Reversed", ArraysGenerator.GenerateReversed(arraySize)),
        new ArrayParam("Sorted", ArraysGenerator.GenerateSorted(arraySize)),
        new ArrayParam("AlmostSorted", ArraysGenerator.GenerateAlmostSorted(arraySize)),
        new ArrayParam("FewUnique", ArraysGenerator.GenerateFewUnique(arraySize)),
    };
    
    [Benchmark]
    public void InsertionSort() {
        InsertionSort(ArrayParam.array);
    }
    public void InsertionSort(int[] array) {
        for (int i = 1; i < array.Length; i++) {
            int key = array[i];
            var predecessorIndex = i - 1;
            while (predecessorIndex >= 0 && array[predecessorIndex] > key) {
                array[predecessorIndex + 1] = array[predecessorIndex];
                predecessorIndex -= 1;
            }

            array[predecessorIndex + 1] = key;
        }
    }

    [Benchmark]
    public void MergeSort() {
        MergeSort(ArrayParam.array, 0, ArrayParam.array.Length - 1);
    }

    private void MergeSort(int[] array, int left, int right) {
        if (left < right) {
            int middle = left + (right - left) / 2;
            
            MergeSort(array, left, middle);
            MergeSort(array, middle + 1, right);
            
            Merge(array, left, middle, right);
        }
    }
    
    private void Merge(int[] arr, int left, int middle, int right) {
        // Find sizes of two
        // subarrays to be merged
        int n1 = middle - left + 1;
        int n2 = right - middle;
 
        // Create temp arrays
        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;
 
        // Copy data to temp arrays
        for (i = 0; i < n1; ++i)
            L[i] = arr[left + i];
        for (j = 0; j < n2; ++j)
            R[j] = arr[middle + 1 + j];
 
        // Merge the temp arrays
 
        // Initial indexes of first
        // and second subarrays
        i = 0;
        j = 0;
 
        // Initial index of merged
        // subarray array
        int k = left;
        while (i < n1 && j < n2) {
            if (L[i] <= R[j]) {
                arr[k] = L[i];
                i++;
            }
            else {
                arr[k] = R[j];
                j++;
            }
            k++;
        }
 
        // Copy remaining elements
        // of L[] if any
        while (i < n1) {
            arr[k] = L[i];
            i++;
            k++;
        }
 
        // Copy remaining elements
        // of R[] if any
        while (j < n2) {
            arr[k] = R[j];
            j++;
            k++;
        }
    }
    
    [Benchmark]
    public void QuickSortClassical() {
        QuickSortClassical(ArrayParam.array, 0, ArrayParam.array.Length - 1);
    }
    private void QuickSortClassical(int[] array, int low, int high) {
        if (low < high) {
  
            // pi is partitioning index, arr[p]
            // is now at right place
            int pi = Partition(array, low, high);
  
            // Separately sort elements before
            // partition and after partition
            QuickSortClassical(array, low, pi - 1);
            QuickSortClassical(array, pi + 1, high);
        }
    }

    private int Partition(int[] arr, int low, int high) {

        // pivot
        int pivot = arr[high];

        // Index of smaller element and
        // indicates the right position
        // of pivot found so far
        int i = (low - 1);

        for (int j = low; j <= high - 1; j++) {

            // If current element is smaller
            // than the pivot
            if (arr[j] < pivot) {

                // Increment index of
                // smaller element
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, high);
        return (i + 1);
    }
    private void Swap(int[] arr, int i, int j) {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    [Benchmark]
    public void QuickSort () {
        Array.Sort(ArrayParam.array);
    }
}
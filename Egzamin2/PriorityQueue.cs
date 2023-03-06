using System.Collections;

namespace Egzamin2;

public class PriorityQueue<T> : IEnumerable<T> where T : IComparable<T> {
    private List<T> list;

    public PriorityQueue(IEnumerable<T> collection) {
        list = new List<T>();
        foreach (var element in collection) {
            Enqueue(element);
        }
    }

    public int Count => list.Count;

    public void Enqueue(T x) {
        list.Add(x);
        var xIndex = list.Count - 1;
        var parentIndex = Convert.ToInt32(Math.Floor((double)(xIndex - 1) / 2));
        while (parentIndex >= 0 && list[parentIndex].CompareTo(x) == 1) {
            var rememberedValue = list[parentIndex];
            list[parentIndex] = x;
            list[xIndex] = rememberedValue;
            xIndex = parentIndex;
            parentIndex = Convert.ToInt32(Math.Floor((double)(xIndex - 1) / 2));
        }
    }

    public T Dequeue() {
        if (list.Count == 0) {
            throw new InvalidOperationException();
        }

        var firstElement = list[0];
        list[0] = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        HeapifyDown(0);
        return firstElement;
    }

    private void HeapifyDown(int index) {
        var leftChildIndex = 2 * index + 1;
        var rightChildIndex = 2 * index + 2;
        var smallestIndex = index;
        if (leftChildIndex < list.Count && list[leftChildIndex].CompareTo(list[index]) < 0) {
            smallestIndex = leftChildIndex;
        }

        if (rightChildIndex < list.Count && list[rightChildIndex].CompareTo(list[smallestIndex]) < 0) {
            smallestIndex = rightChildIndex;
        }

        if (smallestIndex != index) {
            var temp = list[index];
            list[index] = list[smallestIndex];
            list[smallestIndex] = temp;
            HeapifyDown(smallestIndex);
        }
    }


    public T Peek() {
        if (list.Count == 0) {
            throw new InvalidOperationException();
        }

        return list[0];
    }

    public void Clear() {
        list.Clear();
    }

    public T[] ToArray() {
        return list.ToArray();
    }

    public IEnumerator<T> GetEnumerator() {
        foreach (var element in list) {
            yield return element;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}

using System.Collections;

namespace Multiset; 

public class MultiSet<T>: IMultiSet<T> {
    private Dictionary<T, int> _dictionary;

    public MultiSet() {
        _dictionary = new Dictionary<T, int>();
    }
    
    
    public IEnumerator<T> GetEnumerator() {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }

    public void Add(T item) {
        throw new NotImplementedException();
    }

    public void Clear() {
        throw new NotImplementedException();
    }

    public bool Contains(T item) {
        throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex) {
        throw new NotImplementedException();
    }

    public bool Remove(T item) {
        throw new NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public IMultiSet<T> Add(T item, int numberOfItems = 1) {
        throw new NotImplementedException();
    }

    public IMultiSet<T> Remove(T item, int numberOfItems = 1) {
        throw new NotImplementedException();
    }

    public IMultiSet<T> RemoveAll(T item) {
        throw new NotImplementedException();
    }

    public IMultiSet<T> UnionWith(IEnumerable<T> other) {
        throw new NotImplementedException();
    }

    public IMultiSet<T> IntersectWith(IEnumerable<T> other) {
        throw new NotImplementedException();
    }

    public IMultiSet<T> ExceptWith(IEnumerable<T> other) {
        throw new NotImplementedException();
    }

    public IMultiSet<T> SymmetricExceptWith(IEnumerable<T> other) {
        throw new NotImplementedException();
    }

    public bool IsSubsetOf(IEnumerable<T> other) {
        throw new NotImplementedException();
    }

    public bool IsProperSubsetOf(IEnumerable<T> other) {
        throw new NotImplementedException();
    }

    public bool IsSupersetOf(IEnumerable<T> other) {
        throw new NotImplementedException();
    }

    public bool IsProperSupersetOf(IEnumerable<T> other) {
        throw new NotImplementedException();
    }

    public bool Overlaps(IEnumerable<T> other) {
        throw new NotImplementedException();
    }

    public bool MultiSetEquals(IEnumerable<T> other) {
        throw new NotImplementedException();
    }

    public bool IsEmpty { get; }
    public IEqualityComparer<T> Comparer { get; } = null!;

    public int this[T item] => throw new NotImplementedException();

    public IReadOnlyDictionary<T, int> AsDictionary() {
        throw new NotImplementedException();
    }

    public IReadOnlySet<T> AsSet() {
        throw new NotImplementedException();
    }
}
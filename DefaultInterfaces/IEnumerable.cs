namespace IteratorYield.DefaultInterfaces;

public interface IEnumerator<T>
{
    bool MoveNext();
    void Reset();
    T Current { get; }
}
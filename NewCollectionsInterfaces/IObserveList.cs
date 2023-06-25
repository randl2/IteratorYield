namespace IteratorYield.NewCollectionsInterfaces;

public interface IObserveList<T> : IList<T>
{
    event Action CollectionChanged;
}

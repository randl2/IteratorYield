﻿namespace IteratorYield.DefaultInterfaces;

public interface ICollection<T> : IEnumerable<T>
{
    void Clear();
    bool Contains(T item);
    void Remove(T item);
}

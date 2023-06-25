using IteratorYield.NewCollectionsInterfaces;

namespace IteratorYield;

public class PriorityQueue<T> : IPriorityQueue<T>
{
    private readonly Queue<T> queue;
    private readonly IComparer<T> comparer;

    public PriorityQueue()
    {
        queue = new Queue<T>();
        comparer = Comparer<T>.Default;
    }

    public PriorityQueue(IComparer<T> comparer)
    {
        queue = new Queue<T>();
        this.comparer = comparer;
    }

    public int Count => queue.Count;

    public void Enqueue(T item)
    {
        queue.Enqueue(item);
    }

    public T Dequeue()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("Ця черга пуста.");
            return default;
        }

        T[] array = queue.ToArray();
        Array.Sort(array, comparer);
        T min = array[0];

        queue.Clear();

        for (int i = 1; i < array.Length; i++)
        {
            queue.Enqueue(array[i]);
        }

        return min;
    }

    public T Peek()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("Ця черга пуста.");
            return default;
        }

        T[] array = queue.ToArray();
        Array.Sort(array, comparer);

        return array[0];
    }
}


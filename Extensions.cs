namespace IteratorYield;

public static class Extensions
{
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> list, Func<T, bool> predicate)
    {
        foreach (var element in list)
        {
            if (predicate(element))
            {
                yield return element;
            }
        }
    }

    public static IEnumerable<T> Skip<T>(this IEnumerable<T> list, int count)
    {
        foreach (var element in list)
        {
            if (count <= 0)
            {
                yield return element;
            }
            else
            {
                count--;
            }
        }
    }

    public static IEnumerable<T> SkipWhile<T>(this IEnumerable<T> list, Func<T, bool> predicate)
    {
        bool isWorking = false;
        foreach (var element in list)
        {
            if (!isWorking && !predicate(element))
            {
                isWorking = true;
            }

            if (isWorking)
            {
                yield return element;
            }
        }
    }

    public static IEnumerable<T> Take<T>(this IEnumerable<T> list, int count)
    {
        foreach (var element in list)
        {
            if (count > 0)
            {
                yield return element;
                count--;
            }
            else
            {
                yield break;
            }
        }
    }

    public static IEnumerable<T> TakeWhile<T>(this IEnumerable<T> list, Func<T, bool> predicate)
    {
        foreach (var element in list)
        {
            if (predicate(element))
            {
                yield return element;
            }
            else
            {
                yield break;
            }
        }
    }
    public static T First<T>(this IEnumerable<T> list, Func<T, bool> predicate)
    {
        if(list.Count() > 0)
        {
            foreach (var element in list)
            {
                if (predicate(element))
                {
                    return element;
                }
            }
        }
        else
        {
            return default(T);
        }
        return default(T);
    }

    public static T FirstOrDefault<T>(this IEnumerable<T> list, Func<T, bool> predicate)
    {
        foreach (var element in list)
        {
            if (predicate(element))
            {
                return element;
            }
        }

        return default(T);
    }
}

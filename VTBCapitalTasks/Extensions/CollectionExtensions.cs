using VTBCapitalTasks.Models.Enums;

namespace VTBCapitalTasks.Extensions;

public static class CollectionExtensions
{
    /// <summary>
    /// This extension method get collection and order type to sort this collection with declared order type
    /// Complexity O(nlog(n)
    /// </summary>
    /// <param name="collection"></param>
    /// <param name="orderType"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns>Sorted collection</returns>
    public static IEnumerable<T> QuickSort<T>(this IEnumerable<T> collection, OrderType orderType = OrderType.DESC) where T: IComparable<T>
    {
        var length = collection.Count();
        if (length < 2) return collection;
        List<T> left = new();
        List<T> middle = new();
        List<T> right = new();
        var baseIndex = new Random().Next(0, length);
        for (int i = 0; i < length; i++)
        {
            var comparedResult = collection.ElementAt(i).CompareTo(collection.ElementAt(baseIndex));
            var currentElement = collection.ElementAt(i);
            if (comparedResult == 0)
            {
                middle.Add(currentElement);
            }
            else if (comparedResult < 0)
            {
                if (orderType == OrderType.ASC) left.Add(currentElement);
                else right.Add(currentElement);
            }
            else
            {
                if (orderType == OrderType.ASC) right.Add(currentElement);
                else left.Add(currentElement);
            }
        }
        
        return left.QuickSort().Concat(middle).Concat(right.QuickSort());
    }
}
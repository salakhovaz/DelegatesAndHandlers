namespace DelegatesAndHandlers.Delegates
{
    public static class Extensions
    {
        public static T GetMax<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber)
            where T : class
        {
            if (collection == null || !collection.Any())
                throw new ArgumentException("Нельзя передавать пустую коллекцию");

            T maxElement = collection.First();
            float maxValue = float.MinValue;

            foreach (T item in collection.Skip(1))
            {
                float value = convertToNumber(item);
                if (value > maxValue)
                {
                    maxValue = value;
                    maxElement = item;
                }
            }

            return maxElement;
        }
    }
}

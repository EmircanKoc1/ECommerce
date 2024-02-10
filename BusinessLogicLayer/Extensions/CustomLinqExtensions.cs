namespace BusinessLogicLayer.Extensions
{
    public static class CustomLinqExtensions
    {

        public static bool EnumerableChecker<T>(this IEnumerable<T> values, params Func<T, bool>[] conditions)
        where T : class
        {
            bool state = false;

            foreach (var item in values)
                foreach (var condition in conditions)
                    if (condition(item))
                        state = true;

            return state;
        }

    }
}

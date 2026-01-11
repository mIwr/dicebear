namespace System
{
    internal static class EnumExt
    {
        private static readonly Random _rnd = new();

        internal static T[] GetValues<T>() where T: Enum
        {
            var items = Enum.GetValues(typeof(T));
            var res = new T[items.Length];
            var i = 0;
            foreach (var item in items)
            {
                if (item is T == false)
                {
                    continue;
                }
                res[i++] = (T)item;
            }
            return res;
        }

        internal static T RandomValue<T>() where T: struct, Enum
        {
            var enumValues = Enum.GetValues(typeof(T));
            if (enumValues == null || enumValues.Length == 0)
            {
                throw new ArgumentException(message: "Invalid enum " + typeof(T).Name + " - no elements");
            }            
            var randomVal = enumValues.GetValue(_rnd.Next(enumValues.Length));
            if (randomVal == null)
            {
                throw new NullReferenceException(message: "Invalid enum " + typeof(T).Name + " value - Null");
            }
            return (T)randomVal;
        }

        internal static string EnumValueName<T>(T item) where T : struct, Enum
        {
            var name = Enum.GetName(typeof(T), item);
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }
            return name;
        }
    }
}

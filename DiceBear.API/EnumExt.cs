namespace System
{
    internal static class EnumExt
    {
        private static readonly Random _rnd = new();

        internal static T RandomValue<T>() where T: struct, Enum
        {
            var enumValues = Enum.GetValues<T>();
            if (enumValues.Length == 0)
            {
                throw new ArgumentException(message: "Invalid enum " + typeof(T).Name + " - no elements");
            }
            return enumValues[_rnd.Next(enumValues.Length)];
        }

        internal static string EnumValueName<T>(T item) where T : struct, Enum
        {
            var name = Enum.GetName(item);
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }
            return name;
        }
    }
}

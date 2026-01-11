namespace System
{
    internal static class UInt32Ext
    {
        internal static bool TransparentColor(this uint value)
        {
            var cmp = value & 0xFF000000;
            return cmp == 0;
        }

        internal static string ColorHexValue(this uint value)
        {
            var hex = value.ToString("x2");
            while (hex.Length < 8)
            {
                hex = '0' + hex;
            }
            return hex;
        }

        internal static string AlphaStrippedColorHexValue(this uint value)
        {
            var validated = value & 0x00FFFFFF;
            var hex = validated.ToString("x2");
            while (hex.Length < 6)
            {
                hex = '0' + hex;
            }
            return hex;
        }       
    }
}

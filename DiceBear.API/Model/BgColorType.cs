namespace DiceBear.API.Model
{
    /// <summary>
    /// Ava background color type
    /// </summary>
    public enum BgColorType: byte
    {
        /// <summary>
        /// Solid background
        /// </summary>
        Solid,
        /// <summary>
        /// Gradient background
        /// </summary>
        GradientLinear
    }

    /// <summary>
    /// Ava background color type extension
    /// </summary>
    public static class BgColorTypeExt
    {
        /// <summary>
        /// Background color type API key
        /// </summary>
        /// <param name="bgColorType"></param>
        /// <returns></returns>
        public static string ApiKey(this BgColorType bgColorType)
        {
            switch (bgColorType)
            {
                case BgColorType.Solid: return "solid";
                case BgColorType.GradientLinear: return "gradientLinear";
            }
            return string.Empty;
        }
    }
}

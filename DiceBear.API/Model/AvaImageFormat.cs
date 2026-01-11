using System;

namespace DiceBear.API.Model
{
    /// <summary>
    /// Ava image format type
    /// </summary>
    public enum AvaImageFormat: byte
    {
        /// <summary>
        /// SVG vector image
        /// </summary>
        SVG,
        /// <summary>
        /// JPG raster image
        /// </summary>
        JPG,
        /// <summary>
        /// PNG raster image
        /// </summary>
        PNG,
        /// <summary>
        /// WebP image
        /// </summary>
        WebP,
        /// <summary>
        /// AVIF
        /// </summary>
        AVIF
    }

    /// <summary>
    /// Ava image format type extension
    /// </summary>
    public static class AvaImageFormatExt
    {
        /// <summary>
        /// Ava image format API key
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ApiKey(this AvaImageFormat format)
        {
            var enumName = Enum.GetName(typeof(AvaImageFormat), format);
            if (string.IsNullOrEmpty(enumName))
            {
                return format.ToString();
            }
            return enumName.ToLower();
        }
    }
}

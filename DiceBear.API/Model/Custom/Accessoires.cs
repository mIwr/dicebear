using System;

namespace DiceBear.API.Model.Custom
{
    /// <summary>
    /// Accessories API parameter extension
    /// </summary>
    public static class AccessoriesExt
    {
        /// <summary>
        /// API parameter name
        /// </summary>
        public const string ApiParamName = "accessories";

        /// <summary>
        /// Avataaars accessories API parameter key
        /// </summary>
        /// <param name="accessories"></param>
        /// <returns></returns>
        public static string ApiKey(this Accessoires accessories)
        {
            return EnumExt.EnumValueName(accessories).ToLower();
        }

        //Other style api keys will be here
    }

    /// <summary>
    ///  Avataaars accessories API parameter. See https://www.dicebear.com/styles/avataaars/#options-accessories for details
    /// </summary>
    public enum Accessoires: byte
    {
#pragma warning disable 1591
        Eyepatch,
        Kurt,
        Prescription01,
        Prescription02,
        Round,
        Sunglasses,
        Wayfarers
#pragma warning restore 1591
    }
}

using System;

namespace DiceBear.API.Model.Custom
{
    /// <summary>
    /// Clothing graphic API parameter extension
    /// </summary>
    public static class ClothingGraphicExt
    {
        /// <summary>
        /// API parameter name
        /// </summary>
        public const string ApiParamName = "clothingGraphic";

        /// <summary>
        /// Avataaars clothing graphic API parameter key
        /// </summary>
        /// <param name="clothingGraphic"></param>
        /// <returns></returns>
        public static string ApiKey(this ClothingGraphic clothingGraphic)
        {
            return EnumExt.EnumValueName(clothingGraphic);
        }

        //Other style api keys will be here
    }

    /// <summary>
    ///  Avataaars clothing graphic API parameter. See https://www.dicebear.com/styles/avataaars/#options-clothing-graphic for details
    /// </summary>
    public enum ClothingGraphic : byte
    {
#pragma warning disable 1591
        bat,
        bear,
        cumbia,
        deer,
        diamond,
        hola,
        pizza,
        resist,
        skull,
        skullOutline
#pragma warning restore 1591
    }
}

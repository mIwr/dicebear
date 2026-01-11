using System;

namespace DiceBear.API.Model.Custom
{
    /// <summary>
    /// Clothing API parameter extension
    /// </summary>
    public static class ClothingExt
    {
        /// <summary>
        /// API parameter name
        /// </summary>
        public const string ApiParamName = "clothing";

        /// <summary>
        /// Avataaars clothes API parameter key
        /// </summary>
        /// <param name="clothing"></param>
        /// <returns></returns>
        public static string ApiKey(this Clothing clothing)
        {
            return EnumExt.EnumValueName(clothing);
        }

        //Other style api keys will be here
    }

    /// <summary>
    ///  Avataaars clothing API parameter. See https://www.dicebear.com/styles/avataaars/#options-clothes for details
    /// </summary>
    public enum Clothing : byte
    {
#pragma warning disable 1591
        blazerAndShirt,
        blazerAndSweater,
        collarAndSweater,
        graphicShirt,
        hoodie,
        overall,
        shirtCrewNeck,
        shirtScoopNeck,
        shirtVNeck
#pragma warning restore 1591
    }
}

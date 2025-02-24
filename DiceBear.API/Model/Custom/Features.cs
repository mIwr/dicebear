using System;

namespace DiceBear.API.Model.Custom
{
    /// <summary>
    /// Features API parameter extension
    /// </summary>
    public static class FeaturesExt
    {
        /// <summary>
        /// API parameter name
        /// </summary>
        public const string ApiParamName = "features";

        /// <summary>
        /// Adventurer gesture API parameter key
        /// </summary>
        /// <param name="features"></param>
        /// <returns></returns>
        public static string ApiKey(this Features features)
        {
            return EnumExt.EnumValueName(features).ToLower();
        }

        //Other style api keys will be here
    }

    /// <summary>
    /// Adventurer features API parameter. See https://www.dicebear.com/styles/adventurer/#options-features for details
    /// </summary>
    public enum Features : byte
    {
#pragma warning disable 1591
        birthmark,
        Blush,
        Freckles,
        Mustache,        
#pragma warning restore 1591
    }

    //Other style enums with same parameter name will be here
}

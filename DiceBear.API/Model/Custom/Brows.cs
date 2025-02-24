using System;

namespace DiceBear.API.Model.Custom
{
    /// <summary>
    /// Brows API parameter extension
    /// </summary>
    public static class BrowsExt
    {
        /// <summary>
        /// API parameter name
        /// </summary>
        public const string ApiParamName = "brows";
        /// <summary>
        /// Adventurer API parameter name
        /// </summary>
        public const string AdventurerApiParamName = "eyebrows";

        /// <summary>
        /// Notionists brows API parameter key
        /// </summary>
        /// <param name="brows"></param>
        /// <returns></returns>
        public static string ApiKey(this Brows brows)
        {
            return EnumExt.EnumValueName(brows).ToLower();
        }

        /// <summary>
        /// Aventurer eye brows API parameter key
        /// </summary>
        /// <param name="brows"></param>
        /// <returns></returns>
        public static string ApiKey(this EyeBrows brows)
        {
            return EnumExt.EnumValueName(brows).ToLower();
        }

        //Other style api keys will be here
    }

    /// <summary>
    /// Notionists brows API parameter. See https://www.dicebear.com/styles/notionists/#options-brows for details
    /// </summary>
    public enum Brows : byte
    {
#pragma warning disable 1591
        Variant01,
        Variant02,
        Variant03,
        Variant04,
        Variant05,
        Variant06,
        Variant07,
        Variant08,
        Variant09,
        Variant10,
        Variant11,
        Variant12,
        Variant13,
#pragma warning restore 1591
    }

    /// <summary>
    /// Adventurer eye brows API parameter. See https://www.dicebear.com/styles/adventurer/#options-eyebrows for details
    /// </summary>
    public enum EyeBrows: byte
    {
#pragma warning disable 1591
        Variant01,
        Variant02,
        Variant03,
        Variant04,
        Variant05,
        Variant06,
        Variant07,
        Variant08,
        Variant09,
        Variant10,
        Variant11,
        Variant12,
        Variant13,
        Variant14,
        Variant15,
#pragma warning restore 1591
    }

    //Other style enums with same parameter name will be here
}

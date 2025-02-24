using System;

namespace DiceBear.API.Model.Custom
{
    /// <summary>
    /// Glasses API parameter extension
    /// </summary>
    public static class GlassesExt
    {
        /// <summary>
        /// API parameter name
        /// </summary>
        public const string ApiParamName = "glasses";

        /// <summary>
        /// Notionists glasses API parameter key
        /// </summary>
        /// <param name="glasses"></param>
        /// <returns></returns>
        public static string ApiKey(this GlassesNotionists glasses)
        {
            return EnumExt.EnumValueName(glasses).ToLower();
        }

        /// <summary>
        /// Adventure glasses API parameter key
        /// </summary>
        /// <param name="glasses"></param>
        /// <returns></returns>
        public static string ApiKey(this GlassesAdventurer glasses)
        {
            return EnumExt.EnumValueName(glasses).ToLower();
        }

        //Other style api keys will be here
    }

    /// <summary>
    /// Notionists glasses API parameter. See https://www.dicebear.com/styles/notionists/#options-glasses for details
    /// </summary>
    public enum GlassesNotionists : byte
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
#pragma warning restore 1591
    }

    /// <summary>
    /// Adventurer glasses API parameter. See https://www.dicebear.com/styles/adventurer/#options-glasses for details
    /// </summary>
    public enum GlassesAdventurer : byte
    {
#pragma warning disable 1591
        Variant01,
        Variant02,
        Variant03,
        Variant04,
        Variant05,
#pragma warning restore 1591
    }

    //Other style enums with same parameter name will be here
}

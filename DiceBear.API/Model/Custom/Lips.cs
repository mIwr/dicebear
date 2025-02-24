using System;

namespace DiceBear.API.Model.Custom
{
    /// <summary>
    /// Lips API parameter extension
    /// </summary>
    public static class LipsExt
    {
        /// <summary>
        /// API parameter name
        /// </summary>
        public const string ApiParamName = "lips";

        /// <summary>
        /// Notionists lips API parameter key
        /// </summary>
        /// <param name="lips"></param>
        /// <returns></returns>
        public static string ApiKey(this Lips lips)
        {
            return EnumExt.EnumValueName(lips).ToLower();
        }

        //Other style api keys will be here
    }

    /// <summary>
    /// Notionists lips API parameter. See https://www.dicebear.com/styles/notionists/#options-lips for details
    /// </summary>
    public enum Lips : byte
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
        Variant16,
        Variant17,
        Variant18,
        Variant19,
        Variant20,
        Variant21,
        Variant22,
        Variant23,
        Variant24,
        Variant25,
        Variant26,
        Variant27,
        Variant28,
        Variant29,
        Variant30,
#pragma warning restore 1591
    }

    //Other style enums with same parameter name will be here
}

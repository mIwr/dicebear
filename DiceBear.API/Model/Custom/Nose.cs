using System;

namespace DiceBear.API.Model.Custom
{
    /// <summary>
    /// Nose API parameter extension
    /// </summary>
    public static class NoseExt
    {
        /// <summary>
        /// API parameter name
        /// </summary>
        public const string ApiParamName = "nose";

        /// <summary>
        /// Notionists nose API parameter key
        /// </summary>
        /// <param name="nose"></param>
        /// <returns></returns>
        public static string ApiKey(this Nose nose)
        {
            return EnumExt.EnumValueName(nose).ToLower();
        }

        //Other style api keys will be here
    }

    /// <summary>
    /// Notionists nose API parameter. See https://www.dicebear.com/styles/notionists/#options-nose for details
    /// </summary>
    public enum Nose : byte
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
#pragma warning restore 1591
    }

    //Other style enums with same parameter name will be here
}

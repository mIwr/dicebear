using System;

namespace DiceBear.API.Model.Custom
{
    /// <summary>
    /// Body API parameter extension
    /// </summary>
    public static class BodyExt
    {
        /// <summary>
        /// API parameter name
        /// </summary>
        public const string ApiParamName = "body";

        /// <summary>
        /// Notionists body API parameter key
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public static string ApiKey(this Body body)
        {
            return EnumExt.EnumValueName(body).ToLower();
        }

        //Other style api keys will be here
    }

    /// <summary>
    /// Notionists body API parameter. See https://www.dicebear.com/styles/notionists/#options-body for details
    /// </summary>
    public enum Body : byte
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
#pragma warning restore 1591
    }

    //Other style enums with same parameter name will be here
}

using System;

namespace DiceBear.API.Model.Custom
{
    /// <summary>
    /// Beard API parameter extension
    /// </summary>
    public static class BeardExt
    {
        /// <summary>
        /// API parameter name
        /// </summary>
        public const string ApiParamName = "beard";

        /// <summary>
        /// Notionists beard API parameter key
        /// </summary>
        /// <param name="beard"></param>
        /// <returns></returns>
        public static string ApiKey(this BeardNotionists beard)
        {
            return EnumExt.EnumValueName(beard).ToLower();
        }

        /// <summary>
        /// Lorelei beard API parameter key
        /// </summary>
        /// <param name="beard"></param>
        /// <returns></returns>
        public static string ApiKey(this BeardLorelei beard)
        {
            return EnumExt.EnumValueName(beard).ToLower();
        }        

        //Other style api keys will be here
    }

    /// <summary>
    /// Notionists beard API parameter. See https://www.dicebear.com/styles/notionists/#options-beard for details
    /// </summary>
    public enum BeardNotionists : byte
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
    /// Lorelei beard API parameter. See https://www.dicebear.com/styles/lorelei/#options-beard for details
    /// </summary>
    public enum BeardLorelei : byte
    {
#pragma warning disable 1591
        Variant01,
        Variant02,
#pragma warning restore 1591
    }

    //Other style enums with same parameter name will be here
}

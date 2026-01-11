using System;

namespace DiceBear.API.Model.Custom
{
    /// <summary>
    /// Eyes API parameter extension
    /// </summary>
    public static class EyesExt
    {
        /// <summary>
        /// API parameter name
        /// </summary>
        public const string ApiParamName = "eyes";

        /// <summary>
        /// Notionists eyes API parameter key
        /// </summary>
        /// <param name="eyes"></param>
        /// <returns></returns>
        public static string ApiKey(this EyesNotionists eyes)
        {
            return EnumExt.EnumValueName(eyes).ToLower();
        }

        /// <summary>
        /// Adventurer eyes API parameter key
        /// </summary>
        /// <param name="eyes"></param>
        /// <returns></returns>
        public static string ApiKey(this EyesAdventurer eyes)
        {
            return EnumExt.EnumValueName(eyes).ToLower();
        }

        /// <summary>
        /// Avataaars eyes API parameter key
        /// </summary>
        /// <param name="eyes"></param>
        /// <returns></returns>
        public static string ApiKey(this EyesAvataaars eyes)
        {
            return EnumExt.EnumValueName(eyes);
        }

        //Other style api keys will be here
    }

    /// <summary>
    /// Notionists eyes API parameter. See https://www.dicebear.com/styles/notionists/#options-eyes for details
    /// </summary>
    public enum EyesNotionists : byte
    {
#pragma warning disable 1591
        Variant01,
        Variant02,
        Variant03,
        Variant04,
        Variant05,
#pragma warning restore 1591
    }

    /// <summary>
    /// Adventurer eyes API parameter. See https://www.dicebear.com/styles/adventurer/#options-eyes for details
    /// </summary>
    public enum EyesAdventurer : byte
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
        Variant26
#pragma warning restore 1591
    }

    /// <summary>
    /// Avataaars eyes API parameter. See https://www.dicebear.com/styles/avataaars/#options-eyes for details
    /// </summary>
    public enum EyesAvataaars : byte
    {
#pragma warning disable 1591
        closed,
        cry,
        @default,
        eyeRoll,
        happy,
        hearts,
        side,
        squint,
        surprised,
        wink,
        winkWacky,
        xDizzy
#pragma warning restore 1591
    }

    //Other style enums with same parameter name will be here
}

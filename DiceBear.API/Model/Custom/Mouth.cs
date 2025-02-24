using System;

namespace DiceBear.API.Model.Custom
{
    /// <summary>
    /// Mouth API parameter extension
    /// </summary>
    public static class MouthExt
    {
        /// <summary>
        /// API parameter name
        /// </summary>
        public const string ApiParamName = "mouth";

        /// <summary>
        /// Aventurer nose API parameter key
        /// </summary>
        /// <param name="mouth"></param>
        /// <returns></returns>
        public static string ApiKey(this Mouth mouth)
        {
            return EnumExt.EnumValueName(mouth).ToLower();
        }

        //Other style api keys will be here
    }

    /// <summary>
    /// Adventurer mouth API parameter. See https://www.dicebear.com/styles/adventurer/#options-mouth for details
    /// </summary>
    public enum Mouth : byte
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

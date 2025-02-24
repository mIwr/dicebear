using System;

namespace DiceBear.API.Model.Custom
{
    /// <summary>
    /// Ear rings API parameter extension
    /// </summary>
    public static class EarRingsExt
    {
        /// <summary>
        /// API parameter name
        /// </summary>
        public const string ApiParamName = "earrings";

        /// <summary>
        /// Adventurer ear rings API parameter key
        /// </summary>
        /// <param name="earRings"></param>
        /// <returns></returns>
        public static string ApiKey(this EarRings earRings)
        {
            return EnumExt.EnumValueName(earRings).ToLower();
        }

        //Other style api keys will be here
    }

    /// <summary>
    /// Adventurer ear rings API parameter. See https://www.dicebear.com/styles/adventurer/#options-earrings for details
    /// </summary>
    public enum EarRings: byte
    {
#pragma warning disable 1591
        Variant01,
        Variant02,
        Variant03,
        Variant04,
        Variant05,
        Variant06,
#pragma warning restore 1591
    }
}

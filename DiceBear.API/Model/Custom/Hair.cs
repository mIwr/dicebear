using System;

namespace DiceBear.API.Model.Custom
{
    /// <summary>
    /// Notionists hair API parameter extension
    /// </summary>
    public static class HairExt
    {
        /// <summary>
        /// API parameter name
        /// </summary>
        public const string ApiParamName = "hair";

        /// <summary>
        /// Notionists hair API parameter key
        /// </summary>
        /// <param name="hair"></param>
        /// <returns></returns>
        public static string ApiKey(this HairNotionists hair)
        {
            return EnumExt.EnumValueName(hair).ToLower();
        }

        /// <summary>
        /// Adventurer hair API parameter key
        /// </summary>
        /// <param name="hair"></param>
        /// <returns></returns>
        public static string ApiKey(this HairAdventurer hair)
        {
            return EnumExt.EnumValueName(hair).ToLower();
        }
        //Other style api keys will be here
    }

    /// <summary>
    /// Notionists hair API parameter. See https://www.dicebear.com/styles/notionists/#options-hair for details
    /// </summary>
    public enum HairNotionists : byte
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
        Variant31,
        Variant32,
        Variant33,
        Variant34,
        Variant35,
        Variant36,
        Variant37,
        Variant38,
        Variant39,
        Variant40,
        Variant41,
        Variant42,
        Variant43,
        Variant44,
        Variant45,
        Variant46,
        Variant47,
        Variant48,
        Variant49,
        Variant50,
        Variant51,
        Variant52,
        Variant53,
        Variant54,
        Variant55,
        Variant56,
        Variant57,
        Variant58,
        Variant59,
        Variant60,
        Variant61,
        Variant62,
        Variant63,
#pragma warning restore 1591
    }

    /// <summary>
    /// Adventurer hair API parameter. See https://www.dicebear.com/styles/adventurer/#options-hair for details
    /// </summary>
    public enum HairAdventurer : byte
    {
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long01,
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long02,
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long03,
        /// <summary>
        /// Universal long hair variant
        /// </summary>
        Long04,
        /// <summary>
        /// Universal long hair variant
        /// </summary>
        Long05,
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long06,
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long07,
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long08,
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long09,
        /// <summary>
        /// Universal long hair variant
        /// </summary>
        Long10,
        /// <summary>
        /// Universal long hair variant
        /// </summary>
        Long11,
        /// <summary>
        /// Universal long hair variant
        /// </summary>
        Long12,
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long13,
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long14,
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long15,
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long16,
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long17,
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long18,
        /// <summary>
        /// Universal long hair variant
        /// </summary>
        Long19,
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long20,
        /// <summary>
        /// Universal long hair variant
        /// </summary>
        Long21,
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long22,
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long23,
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long24,
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long25,
        /// <summary>
        /// Female long hair variant
        /// </summary>
        Long26,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short01,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short02,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short03,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short04,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short05,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short06,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short07,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short08,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short09,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short10,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short11,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short12,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short13,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short14,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short15,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short16,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short17,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short18,
        /// <summary>
        /// Male short hair variant
        /// </summary>
        Short19,
    }

    //Other style enums with same parameter name will be here
}

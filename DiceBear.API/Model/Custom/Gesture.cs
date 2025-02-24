using System;

namespace DiceBear.API.Model.Custom
{
    /// <summary>
    /// Gesture API parameter extension
    /// </summary>
    public static class GestureExt
    {
        /// <summary>
        /// API parameter name
        /// </summary>
        public const string ApiParamName = "gesture";

        /// <summary>
        /// Notionists gesture API parameter key
        /// </summary>
        /// <param name="gesture"></param>
        /// <returns></returns>
        public static string ApiKey(this Gesture gesture)
        {
            return EnumExt.EnumValueName(gesture);
        }

        //Other style api keys will be here
    }

    /// <summary>
    /// Notionists gesture API parameter. See https://www.dicebear.com/styles/notionists/#options-gesture for details
    /// </summary>
    public enum Gesture : byte
    {
#pragma warning disable 1591
        hand,
        handPhone,
        ok,
        okLongArm,
        point,
        pointLongArm,
        waveLongArm,
        waveLongArms,
        waveOkLongArms,
        wavePointLongArms
#pragma warning restore 1591
    }

    //Other style enums with same parameter name will be here
}

using System;

namespace DiceBear.API.Model.Custom
{
    /// <summary>
    /// Facial hair API parameter extension
    /// </summary>
    public static class FacialHairExt
    {
        /// <summary>
        /// API parameter name
        /// </summary>
        public const string ApiParamName = "facialHair";

        /// <summary>
        /// Avataaars facial hair API parameter key
        /// </summary>
        /// <param name="facialHair"></param>
        /// <returns></returns>
        public static string ApiKey(this FacialHair facialHair)
        {
            return EnumExt.EnumValueName(facialHair);
        }

        //Other style api keys will be here
    }

    /// <summary>
    ///  Avataaars facial hair API parameter. See https://www.dicebear.com/styles/avataaars/#options-facial-hair for details
    /// </summary>
    public enum FacialHair: byte
    {
#pragma warning disable 1591
        beardLight,
        beardMajestic,
        beardMedium,
        moustacheFancy,
        moustacheMagnum
#pragma warning restore 1591
    }
}

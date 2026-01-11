using DiceBear.API.Model.Custom;
using System;
using System.Collections.Generic;

namespace DiceBear.API
{
    public partial class DiceBearAPI
    {

        /// <summary>
        /// Generates randomized custom parameters dictionary for Adventurer style ava
        /// </summary>
        /// <returns>Returns Adventurer custom parameters dictionary</returns>
        public static Dictionary<string, string> GenerateRandomAvataaarsParamsDict()
        {
            var accessories = EnumExt.RandomValue<Accessoires>();
            var clothing = EnumExt.RandomValue<Clothing>();
            var clothingGraphic = EnumExt.RandomValue<ClothingGraphic>();
            var eyeBrows = EnumExt.RandomValue<EyeBrowsAvataaars>();
            var eyes = EnumExt.RandomValue<EyesAvataaars>();
            var facialHair = EnumExt.RandomValue<FacialHair>();
            var mouth = EnumExt.RandomValue<MouthAvataaars>();
            var top = EnumExt.RandomValue<TopAvataaars>();
            return GenerateAvataaarsCustomParamsDict(accessories, clothing: clothing, clothingGraphic: clothingGraphic, eyeBrows: eyeBrows, eyes: eyes, facialHair: facialHair, mouth: mouth, top: top);
        }

        /// <summary>
        /// Generates custom parameters dictionary for Avataaars style ava
        /// </summary>
        /// <param name="accessoires">Accessories variant</param>
        /// <param name="accessoriesColor">Accessories color</param>
        /// <param name="accessoriesProbability">Accessories probability (0..100). Default value is 100</param>
        /// <param name="clothing">Clothing variant</param>
        /// <param name="clothesColor">Clothes color</param>
        /// <param name="clothingGraphic">Clothing graphic variant</param>
        /// <param name="eyeBrows">Eye brows variant</param>
        /// <param name="eyes">Eyes variant</param>
        /// <param name="facialHair">Facial hair variant</param>
        /// <param name="facialHairColor">Facial hair color</param>
        /// <param name="facialHairProbability">Facial hair probability (0..100). Default value is 100</param>
        /// <param name="hairColor">Hair color</param>
        /// <param name="hatColor">Hat color</param>
        /// <param name="mouth">Mouth variant</param>
        /// <param name="skinColor">Skin color</param>
        /// <param name="top">Top (hair, hat) variant</param>
        /// <param name="topProbability">Top (hair, hat) probability (0..100). Default value is 100</param>
        /// <returns></returns>
        public static Dictionary<string, string> GenerateAvataaarsCustomParamsDict(Accessoires? accessoires = null, uint accessoriesColor = 0xff112211, byte accessoriesProbability = 100, Clothing? clothing = null, uint clothesColor = 0xff441144, ClothingGraphic? clothingGraphic = null, EyeBrowsAvataaars? eyeBrows = null, EyesAvataaars? eyes = null, FacialHair? facialHair = null, uint facialHairColor = 0xff112211, byte facialHairProbability = 100, uint hairColor = 0xff112211, uint hatColor = 0xff005599, MouthAvataaars? mouth = null, uint skinColor = 0xffedb98a, TopAvataaars? top = null, byte topProbability = 100)
        {
            var resDict = new Dictionary<string, string>();
            if (accessoires != null && accessoriesProbability != 0 && !accessoriesColor.TransparentColor())
            {
                var validatedProbability = accessoriesProbability >= 100 ? 100 : accessoriesProbability;
                resDict.Add(AccessoriesExt.ApiParamName, accessoires.Value.ApiKey());
                resDict.Add("accessoriesColor", accessoriesColor.AlphaStrippedColorHexValue());
                resDict.Add("accessoriesProbability", validatedProbability.ToString());
            }
            if (clothing != null && !clothesColor.TransparentColor())
            {
                resDict.Add(ClothingExt.ApiParamName, clothing.Value.ApiKey());
                resDict.Add("clothesColor", clothesColor.AlphaStrippedColorHexValue());
            }
            if (clothingGraphic != null)
            {
                resDict.Add(ClothingGraphicExt.ApiParamName, clothingGraphic.Value.ApiKey());
            }
            if (eyeBrows != null)
            {
                resDict.Add(BrowsExt.ApiParamNameVariant, eyeBrows.Value.ApiKey());
            }
            if (eyes != null)
            {
                resDict.Add(EyesExt.ApiParamName, eyes.Value.ApiKey());
            }
            if (facialHair != null && facialHairProbability != 0 && !facialHairColor.TransparentColor())
            {
                var validatedProbability = facialHairProbability >= 100 ? 100 : facialHairProbability;
                resDict.Add(FacialHairExt.ApiParamName, facialHair.Value.ApiKey());
                resDict.Add("facialHairColor", facialHairColor.AlphaStrippedColorHexValue());
                resDict.Add("facialHairProbability", validatedProbability.ToString());
            }
            if (mouth != null)
            {
                resDict.Add(MouthExt.ApiParamName, mouth.Value.ApiKey());
            }
            if (!skinColor.TransparentColor())
            {
                resDict.Add("skinColor", skinColor.AlphaStrippedColorHexValue());
            }
            if (top != null)
            {
                resDict.Add(HairExt.ApiParamNameVariant, top.Value.ApiKey());
                if (!hairColor.TransparentColor())
                {
                    resDict.Add("hairColor", hairColor.AlphaStrippedColorHexValue());
                }
                if (!hatColor.TransparentColor())
                {
                    resDict.Add("hatColor", hatColor.AlphaStrippedColorHexValue());
                }                
            }

            return resDict;
        }        
    }
}

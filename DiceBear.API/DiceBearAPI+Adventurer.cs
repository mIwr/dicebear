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
        public static Dictionary<string, string> GenerateRandomAdventurerParamsDict()
        {
            var hairColor = (uint)Random.Shared.Next();
            return GenerateAdventurerCustomParamsDict(earRings: EnumExt.RandomValue<EarRings>(), eyeBrows: EnumExt.RandomValue<EyeBrows>(), eyes: EnumExt.RandomValue<EyesAdventurer>(), features: EnumExt.RandomValue<Features>(), glasses: EnumExt.RandomValue<GlassesAdventurer>(), hair: EnumExt.RandomValue<HairAdventurer>(), hairColor: hairColor, mouth: EnumExt.RandomValue<Mouth>());
        }

        /// <summary>
        /// Generates randomized custom parameters dictionary for Adventurer Neutral style ava
        /// </summary>
        /// <returns>Returns Adventurer Neutral custom parameters dictionary</returns>
        public static Dictionary<string, string> GenerateRandomAdventurerNeutralParamsDict()
        {
            return GenerateAdventurerNeutralCustomParamsDict(eyeBrows: EnumExt.RandomValue<EyeBrows>(), eyes: EnumExt.RandomValue<EyesAdventurer>(), glasses: EnumExt.RandomValue<GlassesAdventurer>(), mouth: EnumExt.RandomValue<Mouth>());
        }

        /// <summary>
        /// Generates custom parameters dictionary for Adventurer style ava
        /// </summary>
        /// <param name="earRings">Ear rings varaint</param>
        /// <param name="earRingsProbability">>Ear rings show probability (0..100). Default value is 100</param>
        /// <param name="eyeBrows">Eye brows variant</param>
        /// <param name="eyes">Eyes variant</param>
        /// <param name="features">Face features variant</param>
        /// <param name="featuresProbability">Face features show probability (0..100). Default value is 100</param>
        /// <param name="glasses">Glasses variant</param>
        /// <param name="glassesProbability">Glasses show probability (0..100). Default value is 100</param>
        /// <param name="hair">Hair variant</param>
        /// <param name="hairColor">Hair color. Default value is 0xffafafaf </param>
        /// <param name="hairProbability">Hair show probability (0..100). Default value is 100</param>
        /// <param name="mouth">Mouth variant</param>
        /// <param name="skinColor">Face skin color</param>
        /// <returns>Returns Adventurer custom parameters dictionary</returns>
        public static Dictionary<string, string> GenerateAdventurerCustomParamsDict(EarRings? earRings = null, byte earRingsProbability = 100, EyeBrows? eyeBrows = null, EyesAdventurer? eyes = null, Features? features = null, byte featuresProbability = 100, GlassesAdventurer? glasses = null, byte glassesProbability = 100, HairAdventurer? hair = null, uint hairColor = 0xffafafaf, byte hairProbability = 100, Mouth? mouth = null, uint skinColor = 0xfff2d3b1)
        {
            var resDict = GenerateAdventurerNeutralCustomParamsDict(eyeBrows, eyes, glasses, glassesProbability, mouth);
            if (earRings != null && earRingsProbability > 0)
            {
                resDict.Add(EarRingsExt.ApiParamName, earRings.Value.ApiKey());
                resDict.Add("earringsProbability", earRingsProbability.ToString());
            }            
            if (features != null && featuresProbability > 0)
            {
                resDict.Add(FeaturesExt.ApiParamName, features.Value.ApiKey());
                resDict.Add("featuresProbability", featuresProbability.ToString());
            }
            var validatedColor = hairColor & 0x00FFFFFF;
            if (hair != null && validatedColor > 0 && hairProbability > 0)
            {
                resDict.Add(HairExt.ApiParamName, hair.Value.ApiKey());
                resDict.Add("hairColor", validatedColor.ToString("x2"));
                resDict.Add("hairProbability", hairProbability.ToString());
            }
            validatedColor = skinColor & 0x00FFFFFF;
            if (validatedColor > 0)
            {
                resDict.Add("skinColor", validatedColor.ToString("x2"));
            }
            return resDict;
        }

        /// <summary>
        /// Generates custom parameters dictionary for Adventurer Neutral style ava
        /// </summary>        
        /// <param name="eyeBrows">Eye brows variant</param>
        /// <param name="eyes">Eyes variant</param>        
        /// <param name="glasses">Glasses variant</param>
        /// <param name="glassesProbability">Glasses show probability (0..100). Default value is 100</param>       
        /// <param name="mouth">Mouth variant</param>        
        /// <returns>Returns Adventurer Neutral custom parameters dictionary</returns>
        public static Dictionary<string, string> GenerateAdventurerNeutralCustomParamsDict(EyeBrows? eyeBrows = null, EyesAdventurer? eyes = null, GlassesAdventurer? glasses = null, byte glassesProbability = 100, Mouth? mouth = null)
        {
            var resDict = new Dictionary<string, string>();            
            if (eyeBrows != null)
            {
                resDict.Add(BrowsExt.AdventurerApiParamName, eyeBrows.Value.ApiKey());
            }
            if (eyes != null)
            {
                resDict.Add(EyesExt.ApiParamName, eyes.Value.ApiKey());
            }
            if (glasses != null && glassesProbability > 0)
            {
                resDict.Add(GlassesExt.ApiParamName, glasses.Value.ApiKey());
            }            
            if (mouth != null)
            {
                resDict.Add(MouthExt.ApiParamName, mouth.Value.ApiKey());
            }
            return resDict;
        }
    }
}

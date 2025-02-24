using DiceBear.API.Model.Custom;
using System;
using System.Collections.Generic;

namespace DiceBear.API
{
    public partial class DiceBearAPI
    {
        /// <summary>
        /// Generates randomized custom parameters dictionary for Notionists style ava
        /// </summary>
        /// <returns>Returns Notionists custom parameters dictionary</returns>
        public static Dictionary<string, string> GenerateRandomNotionistsParamsDict()
        {
            return GenerateNotionistsCustomParamsDict(beard: EnumExt.RandomValue<BeardNotionists>(), body: EnumExt.RandomValue<Body>(), brows: EnumExt.RandomValue<Brows>(), eyes: EnumExt.RandomValue<EyesNotionists>(), glasses: EnumExt.RandomValue<GlassesNotionists>(), hair: EnumExt.RandomValue<HairNotionists>(), lips: EnumExt.RandomValue<Lips>(), nose: EnumExt.RandomValue<Nose>());
        }

        /// <summary>
        /// Generates custom parameters dictionary for Notionists style ava
        /// </summary>
        /// <param name="beard">Beard variant</param>
        /// <param name="beardProbability">Beard show probability (0..100). Default value is 100</param>
        /// <param name="body">Body variant</param>
        /// <param name="brows">Brows variant</param>
        /// <param name="eyes">Eyes variant</param>
        /// <param name="gesture">Gesture variant</param>
        /// <param name="gestureProbability">Gesture show probability (0..100). Default value is 100</param>
        /// <param name="glasses">Glasses variant</param>
        /// <param name="glassesProbability">Glasses show probability (0..100). Default value is 100</param>
        /// <param name="hair">Hair variant</param>
        /// <param name="lips">Lips variant</param>
        /// <param name="nose">Nose variant</param>
        /// <returns>Returns Notionists custom parameters dictionary</returns>
        public static Dictionary<string, string> GenerateNotionistsCustomParamsDict(BeardNotionists? beard = null, byte beardProbability = 100, Body? body = null, Brows? brows = null, EyesNotionists? eyes = null, Gesture? gesture = null, byte gestureProbability = 100, GlassesNotionists? glasses = null, byte glassesProbability = 100, HairNotionists? hair = null, Lips? lips = null, Nose? nose = null)
        {
            var resDict = new Dictionary<string, string>();
            if (beard != null && beardProbability > 0)
            {
                var validatedBeardProbability = beardProbability >= 100 ? 100 : beardProbability;
                resDict.Add(BeardExt.ApiParamName, beard.Value.ApiKey());
                resDict.Add("beardProbability", validatedBeardProbability.ToString());
            }
            if (body != null)
            {
                resDict.Add(BodyExt.ApiParamName, body.Value.ApiKey());
            }
            if (brows != null)
            {
                resDict.Add(BrowsExt.ApiParamName, brows.Value.ApiKey());
            }
            if (eyes != null)
            {
                resDict.Add(EyesExt.ApiParamName, eyes.Value.ApiKey());
            }
            if (gesture != null && gestureProbability > 0)
            {
                var validatedGestureProbability = gestureProbability >= 100 ? 100 : gestureProbability;
                resDict.Add(GestureExt.ApiParamName, gesture.Value.ApiKey());
                resDict.Add("gestureProbability", validatedGestureProbability.ToString());
            }
            if (glasses != null && glassesProbability > 0)
            {
                var validatedGlassesProbability = glassesProbability >= 100 ? 100 : glassesProbability;
                resDict.Add(GlassesExt.ApiParamName, glasses.Value.ApiKey());
                resDict.Add("glassesProbability", validatedGlassesProbability.ToString());
            }
            if (hair != null)
            {
                resDict.Add(HairExt.ApiParamName, hair.Value.ApiKey());
            }
            if (lips != null)
            {
                resDict.Add(LipsExt.ApiParamName, lips.Value.ApiKey());
            }
            if (nose != null)
            {
                resDict.Add(NoseExt.ApiParamName, nose.Value.ApiKey());
            }
            return resDict;
        }
    }
}

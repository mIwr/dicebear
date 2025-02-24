using DiceBear.API.Model;
using DiceBear.API.Model.Custom;
using FaceGenerator;
using FaceGenerator.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DiceBear.API
{
    /// <summary>
    /// DiceBear API
    /// </summary>
    public partial class DiceBearAPI
    {
        internal const string ApiHost = "api.dicebear.com";
        internal const string ApiVersionPathPrefix = "9.x/";

        private static readonly Client _downloader = new();

        /// <summary>
        /// Generates randomized DiceBear API link and downloads result ava
        /// </summary>
        /// <param name="imgFormat">Image format extension</param>
        /// <param name="seed">Avatar generation seed. If not stated will be generated random UUID</param>
        /// <param name="sizePx">Image size in pixels (1..). Default value is 128 px</param>
        /// <param name="bg">Image background color. Default value is 0x00000000 (transparent)</param>
        /// <returns>Returns ava image bytes</returns>
        public static Task<Result<byte[], ApiError>> GenerateRandomAndDownloadAva(AvaImageFormat imgFormat, string? seed = null, ushort sizePx = 128, uint bg = 0x00000000)
        {
            return _downloader.DownloadAvaImg(GenerateRandomAvaLink(imgFormat, seed, sizePx, bg));
        }

        /// <summary>
        /// Generates DiceBear API link and downloads result ava
        /// </summary>
        /// <param name="style">Avatar style</param>
        /// <param name="imgFormat">Image format extension</param>
        /// <param name="seed">Avatar generation seed</param>
        /// <param name="customStyleKey"> Custom avatar style key. Overrides the pre-defined style, if stated</param>
        /// <param name="flip">Flip result image flag. Default value is false</param>
        /// <param name="rotationAngle">Result image rotation angle (0..360). Default value is 0</param>
        /// <param name="scale">Image scale (0..200). Default value is 100</param>
        /// <param name="borderRadius">Image border radius (0..50). Default value is 0</param>
        /// <param name="sizePx">Image size in pixels (1..). Default value is 128 px</param>
        /// <param name="bg">Image background color. Default value is 0x00000000 (transparent)</param>
        /// <param name="bgColorType">Image background color type. Default value is solid</param>
        /// <param name="customColorTypeKey">Custom background color type key. Overrides the pre-defined color type, if stated</param>
        /// <param name="gradientBgColorRotationAngle">Gradient color rotation angle (0..360). Used only if stated the linear gradient background color type. Default value is 0</param>
        /// <param name="translateX">X-axis image translation (-100..100). Default value is 0</param>
        /// <param name="translateY">Y-axis image translation (-100..100). Default value is 0</param>
        /// <param name="clip">Image clip flag. Default value is false</param>
        /// <param name="svgRandomizeIDs">Randomize SVG/XML tags names. Used only if stated SVG format</param>
        /// <param name="customParams">Specific for the style custom parameters</param>
        /// <returns>Returns ava image bytes</returns>
        public static Task<Result<byte[], ApiError>> GenerateAndDownloadAva(AvaStyle style, AvaImageFormat imgFormat, string seed, string? customStyleKey = null, bool flip = false, ushort rotationAngle = 0, byte scale = 100, byte borderRadius = 0, ushort sizePx = 128, uint bg = 0x00000000, BgColorType bgColorType = BgColorType.Solid, string? customColorTypeKey = null, ushort gradientBgColorRotationAngle = 0, sbyte translateX = 0, sbyte translateY = 0, bool clip = false, bool svgRandomizeIDs = false, Dictionary<string, string>? customParams = null)
        {
            return _downloader.DownloadAvaImg(GenerateAvaLink(style, imgFormat, seed, customStyleKey, flip, rotationAngle, scale, borderRadius, sizePx, bg, bgColorType, customColorTypeKey, gradientBgColorRotationAngle, translateX, translateY, clip, svgRandomizeIDs, customParams));
        }

        /// <summary>
        /// Generates randomized DiceBear API link to retrieve ava
        /// </summary>
        /// <param name="imgFormat">Image format extension</param>
        /// <param name="seed">Avatar generation seed. If not stated will be generated random UUID</param>
        /// <param name="sizePx">Image size in pixels (1..). Default value is 128 px</param>
        /// <param name="bg">Image background color. Default value is 0x00000000 (transparent)</param>
        /// <returns>Returns ava image donwload link uri</returns>
        public static Uri GenerateRandomAvaLink(AvaImageFormat imgFormat, string? seed = null, ushort sizePx = 128, uint bg = 0x00000000)
        {
            var style = EnumExt.RandomValue<AvaStyle>();
            var customParams = new Dictionary<string, string>();
            switch(style)
            {
                case AvaStyle.Adventurer:
                    customParams = GenerateRandomAdventurerParamsDict();
                    break;
                /*case AvaStyle.AdventurerNeutral: return "adventurer-neutral";
                case AvaStyle.Avataaars: return "avataaars";
                case AvaStyle.AvataaarsNeutral: return "avataaars-neutral";
                case AvaStyle.BigEars: return "big-ears";
                case AvaStyle.BigEarsNeutral: return "big-ears-neutral";
                case AvaStyle.BigSmile: return "big-smile";
                case AvaStyle.Bottts: return "bottts";
                case AvaStyle.BotttsNeutral: return "bottts-neutral";
                case AvaStyle.Croodles: return "croodles";
                case AvaStyle.CroodlesNeutral: return "croodles-neutral";
                case AvaStyle.Dylan: return "dylan";
                case AvaStyle.FunEmoji: return "fun-emoji";
                case AvaStyle.Glass: return "glass";
                case AvaStyle.Icons: return "icons";
                case AvaStyle.Identicon: return "identicon";
                case AvaStyle.Initials: return "initials";
                case AvaStyle.Lorelei: return "lorelei";
                case AvaStyle.LoreleiNeutral: return "lorelei-neutral";
                case AvaStyle.Micah: return "micah";
                case AvaStyle.Miniavs: return "miniavs";*/
                case AvaStyle.Notionists:
                    customParams = GenerateRandomNotionistsParamsDict();
                    break;
                /*case AvaStyle.NotionistsNeutral: return "notionists-neutral";
                case AvaStyle.OpenPeeps: return "open-peeps";
                case AvaStyle.Personas: return "personas";
                case AvaStyle.PixelArt: return "pixel-art";
                case AvaStyle.PixelArtNeutral: return "pixel-art-neutral";
                case AvaStyle.Rings: return "rings";
                case AvaStyle.Shapes: return "shapes";
                case AvaStyle.Thumbs: return "thumbs";*/
            }
            var bgColor = bg != 0 ? bg : (uint)new Random().Next();
            return GenerateAvaLink(style, imgFormat, seed ?? Guid.NewGuid().ToString(), sizePx: sizePx, bg: bgColor, svgRandomizeIDs: true, customParams: customParams);
        }

        /// <summary>
        /// Generates DiceBear API link to retrieve ava
        /// </summary>
        /// <param name="style">Avatar style</param>
        /// <param name="imgFormat">Image format extension</param>
        /// <param name="seed">Avatar generation seed</param>
        /// <param name="customStyleKey"> Custom avatar style key. Overrides the pre-defined style, if stated</param>
        /// <param name="flip">Flip result image flag. Default value is false</param>
        /// <param name="rotationAngle">Result image rotation angle (0..360). Default value is 0</param>
        /// <param name="scale">Image scale (0..200). Default value is 100</param>
        /// <param name="borderRadius">Image border radius (0..50). Default value is 0</param>
        /// <param name="sizePx">Image size in pixels (1..). Default value is 128 px</param>
        /// <param name="bg">Image background color. Default value is 0x00000000 (transparent) </param>
        /// <param name="bgColorType">Image background color type. Default value is solid</param>
        /// <param name="customColorTypeKey">Custom background color type key. Overrides the pre-defined color type, if stated</param>
        /// <param name="gradientBgColorRotationAngle">Gradient color rotation angle (0..360). Used only if stated the linear gradient background color type. Default value is 0</param>
        /// <param name="translateX">X-axis image translation (-100..100). Default value is 0</param>
        /// <param name="translateY">Y-axis image translation (-100..100). Default value is 0</param>
        /// <param name="clip">Image clip flag. Default value is false</param>
        /// <param name="svgRandomizeIDs">Randomize SVG/XML tags names. Used only if stated SVG format</param>
        /// <param name="customParams">Specific for the style custom parameters</param>
        /// <returns>Returns ava image donwload link uri</returns>
        public static Uri GenerateAvaLink(AvaStyle style, AvaImageFormat imgFormat, string seed, string? customStyleKey = null, bool flip = false, ushort rotationAngle = 0, byte scale = 100, byte borderRadius = 0, ushort sizePx = 128, uint bg = 0x00000000, BgColorType bgColorType = BgColorType.Solid, string? customColorTypeKey = null, ushort gradientBgColorRotationAngle = 0, sbyte translateX = 0, sbyte translateY = 0, bool clip = false, bool svgRandomizeIDs = false, Dictionary<string, string>? customParams = null)
        {
            if (sizePx == 0)
            {
                throw new ArgumentException(message: "Size can't be 0 px", paramName: nameof(sizePx));
            }
            var pathSuffix = style.ApiStyleKey();
            if (!string.IsNullOrEmpty(customStyleKey))
            {
                pathSuffix = customStyleKey;
            }
            if (!pathSuffix.EndsWith('/'))
            {
                pathSuffix += '/';
            }
            pathSuffix += imgFormat.ApiKey();

            var validatedRotationAngle = (ushort)(rotationAngle % 360);
            var validatedScale = (byte)(scale % 200);
            var validatedBorderRadius = (byte)(borderRadius % 50);
            var validatedGradientBgColorRotationAngle = (ushort)(gradientBgColorRotationAngle % 360);
            var validatedTranslateX = (sbyte)(translateX % 100);
            var validatedTranslateY = (sbyte)(translateY % 100);
            var queryParams = new Dictionary<string, string>
            {
                ["size"] = sizePx.ToString()
            };
            if (!string.IsNullOrEmpty(seed))
            {
                queryParams.Add("seed", seed);
            }
            if (flip)
            {
                queryParams.Add("flip", flip.ToString().ToLower());
            }
            if (validatedRotationAngle > 0)
            {
                queryParams.Add("rotate", validatedRotationAngle.ToString());
            }
            if (validatedScale != 100)
            {
                queryParams.Add("scale", validatedScale.ToString());
            }
            if (validatedBorderRadius > 0)
            {
                queryParams.Add("radius", validatedBorderRadius.ToString());
            }
            var validatedColor = bg & 0x00FFFFFF;
            if (validatedColor > 0)
            {
                queryParams.Add("backgroundColor", validatedColor.ToString(format: "x2"));
            }
            queryParams.Add("backgroundType", bgColorType.ApiKey());
            if (!string.IsNullOrEmpty(customColorTypeKey))
            {
                queryParams["backgroundType"] = customColorTypeKey;
            }
            if (queryParams["backgroundType"] == BgColorType.GradientLinear.ApiKey() && validatedGradientBgColorRotationAngle > 0)
            {
                queryParams.Add("backgroundRotation", validatedGradientBgColorRotationAngle.ToString());
            }
            if (validatedTranslateX != 0)
            {
                queryParams.Add("translateX", validatedTranslateX.ToString());
            }
            if (validatedTranslateY != 0)
            {
                queryParams.Add("translateY", validatedTranslateY.ToString());
            }
            if (clip)
            {
                queryParams.Add("clip", clip.ToString().ToLower());
            }
            if (imgFormat == AvaImageFormat.SVG && svgRandomizeIDs)
            {
                queryParams.Add("randomizeIds", svgRandomizeIDs.ToString().ToLower());
            }
            if (customParams != null)
            {
                foreach (var entry in customParams)
                {
                    if (entry.Value == null)
                    {
                        continue;
                    }
                    if (!queryParams.ContainsKey(entry.Key))
                    {
                        queryParams.Add(entry.Key, entry.Value);
                        continue;
                    }
                    queryParams[entry.Key] = entry.Value;
                }
            }

            var uriBuilder = new UriBuilder();
            uriBuilder.Scheme = "https";
            uriBuilder.Host = ApiHost;
            uriBuilder.Path = ApiVersionPathPrefix + pathSuffix;
            uriBuilder.Query = string.Join("&", queryParams.Select(kvp => string.Format("{0}={1}", kvp.Key, HttpUtility.UrlEncode(kvp.Value))));
            return uriBuilder.Uri;
        }        
    }
}

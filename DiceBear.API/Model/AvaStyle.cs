using System;
using System.Collections.Generic;
using System.Linq;

namespace DiceBear.API.Model
{
    /// <summary>
    /// Pre-defined DiceBear avatar styles. <see href="https://www.dicebear.com/styles/">Details</see> 
    /// </summary>
    public enum AvaStyle: byte
    {
        /// <summary>
        /// Head with face ava style. <see href="https://www.dicebear.com/styles/adventurer/">Details</see> 
        /// </summary>
        Adventurer,
        /// <summary>
        /// Adventurer just face style. <see href="https://www.dicebear.com/styles/adventurer-neutral/">Details</see>
        /// </summary>
        AdventurerNeutral,
        /// <summary>
        /// Portrait ava style. <see href="https://www.dicebear.com/styles/avataaars/">Details</see>
        /// </summary>
        Avataaars,
        /// <summary>
        /// Avataaars just face style. <see href="https://www.dicebear.com/styles/avataaars-neutral/">Details</see>
        /// </summary>
        AvataaarsNeutral,
        /// <summary>
        /// Head with face ava style. <see href=" https://www.dicebear.com/styles/big-ears/">Details</see>
        /// </summary>
        BigEars,
        /// <summary>
        /// BigEars just face style. <see href=" https://www.dicebear.com/styles/big-ears-neutral/">Details</see>
        /// </summary>
        BigEarsNeutral,
        /// <summary>
        /// Head with face ava style. <see href="https://www.dicebear.com/styles/big-smile/">Details</see>  
        /// </summary>
        BigSmile,
        /// <summary>
        /// Head with face ava style. <see href="https://www.dicebear.com/styles/bottts/">Details</see>
        /// </summary>
        Bottts,
        /// <summary>
        /// Bottts just face style. <see href="https://www.dicebear.com/styles/bottts-neutral/">Details</see>
        /// </summary>
        BotttsNeutral,
        /// <summary>
        /// Head with face ava style. <see href="https://www.dicebear.com/styles/croodles/">Details</see>
        /// </summary>
        Croodles,
        /// <summary>
        /// Croodles just face style. <see href="https://www.dicebear.com/styles/croodles-neutral/">Details</see>
        /// </summary>
        CroodlesNeutral,
        /// <summary>
        /// Head with face ava style. <see href="https://www.dicebear.com/styles/dylan/">Details</see>
        /// </summary>
        Dylan,
        /// <summary>
        /// Just face emoji ava style. <see href="https://www.dicebear.com/styles/fun-emoji/">Details</see>
        /// </summary>
        FunEmoji,
        /// <summary>
        /// Just color, without face ava. <see href="https://www.dicebear.com/styles/glass/">Details</see>
        /// </summary>
        Glass,
        /// <summary>
        /// Bootstrap icons (no face). <see href="https://www.dicebear.com/styles/icons/">Details</see>
        /// </summary>
        Icons,
        /// <summary>
        /// Github default ava icon style. <see href="https://www.dicebear.com/styles/identicon/">Details</see>
        /// </summary>
        Identicon,
        /// <summary>
        /// Google initials ava style. <see href="https://www.dicebear.com/styles/initials/">Details</see>
        /// </summary>
        Initials,
        /// <summary>
        /// Head with face ava style. <see href="https://www.dicebear.com/styles/lorelei/">Details</see>
        /// </summary>
        Lorelei,
        /// <summary>
        /// Lorelei just face style. <see href="https://www.dicebear.com/styles/lorelei-neutral/">Details</see>
        /// </summary>
        LoreleiNeutral,
        /// <summary>
        /// Head with face ava style. <see href="https://www.dicebear.com/styles/micah/">Details</see>
        /// </summary>
        Micah,
        /// <summary>
        /// Head with face ava style. <see href="https://www.dicebear.com/styles/miniavs/">Details</see>
        /// </summary>
        Miniavs,
        /// <summary>
        /// Head with face ava style. <see href="https://www.dicebear.com/styles/notionists/">Details</see>
        /// </summary>
        Notionists,
        /// <summary>
        /// Notionists just face style. <see href="https://www.dicebear.com/styles/notionists-neutral/">Details</see>
        /// </summary>
        NotionistsNeutral,
        /// <summary>
        /// Head with face ava style. <see href="https://www.dicebear.com/styles/open-peeps/">Details</see>
        /// </summary>
        OpenPeeps,
        /// <summary>
        /// Head with face ava style. <see href="https://www.dicebear.com/styles/personas/">Details</see>
        /// </summary>
        Personas,
        /// <summary>
        /// Pixelized (8-bit) ava style. <see href="https://www.dicebear.com/styles/pixel-art/">Details</see>
        /// </summary>
        PixelArt,
        /// <summary>
        /// Pixel Art just face style. <see href="https://www.dicebear.com/styles/pixel-art-neutral/">Details</see>
        /// </summary>
        PixelArtNeutral,
        /// <summary>
        /// Rings style (no face). <see href="https://www.dicebear.com/styles/rings/">Details</see>
        /// </summary>
        Rings,
        /// <summary>
        /// Shapes style (no face). <see href="https://www.dicebear.com/styles/shapes/">Details</see>
        /// </summary>
        Shapes,
        /// <summary>
        /// Face style. <see href="https://www.dicebear.com/styles/thumbs/">Details</see>
        /// </summary>
        Thumbs,
    }

    /// <summary>
    /// Pre-defined DiceBear avatar styles extension
    /// </summary>
    public static class AvaStyleExt
    {
        /// <summary>
        /// Ava styles with face
        /// </summary>
        public static AvaStyle[] FaceStyles
        {
            get
            {
                var all = new HashSet<AvaStyle>(Enum.GetValues<AvaStyle>());
                all.Remove(AvaStyle.Glass);
                all.Remove(AvaStyle.Icons);
                all.Remove(AvaStyle.Identicon);
                all.Remove(AvaStyle.Initials);
                all.Remove(AvaStyle.Rings);
                all.Remove(AvaStyle.Shapes);
                return all.ToArray();
            }
        }

        /// <summary>
        /// Predefined ava style API key
        /// </summary>
        /// <param name="style"></param>
        /// <returns></returns>
        public static string ApiStyleKey(this AvaStyle style)
        {
            switch (style)
            {
                case AvaStyle.Adventurer: return "adventurer";
                case AvaStyle.AdventurerNeutral: return "adventurer-neutral";
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
                case AvaStyle.Miniavs: return "miniavs";
                case AvaStyle.Notionists: return "notionists";
                case AvaStyle.NotionistsNeutral: return "notionists-neutral";
                case AvaStyle.OpenPeeps: return "open-peeps";
                case AvaStyle.Personas: return "personas";
                case AvaStyle.PixelArt: return "pixel-art";
                case AvaStyle.PixelArtNeutral: return "pixel-art-neutral";
                case AvaStyle.Rings: return "rings";
                case AvaStyle.Shapes: return "shapes";
                case AvaStyle.Thumbs: return "thumbs";
            }
            return string.Empty;
        }
    }
}

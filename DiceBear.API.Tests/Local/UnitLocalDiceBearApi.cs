using DiceBear.API.Model;
using DiceBear.API.Model.Custom;

namespace DiceBear.API.Tests.Local
{
    internal class UnitLocalDiceBearApi
    {
        [Test]
        public void GenerateGenAvaLinkTest()
        {
            var link = DiceBearAPI.GenerateAvaLink(AvaStyle.LoreleiNeutral, AvaImageFormat.SVG, seed: "someSeed");
            Assert.That(link, Is.Not.Null);
        }

        [Test]
        public void GenerateAdvancedAvaLinkTest()
        {
            var link = DiceBearAPI.GenerateAvaLink(AvaStyle.LoreleiNeutral, AvaImageFormat.SVG, seed: "someSeed", flip: true, rotationAngle: 30, scale: 90, borderRadius: 12, sizePx: 256, bg: 0xff123456, bgColorType: BgColorType.GradientLinear, gradientBgColorRotationAngle: 45, translateX: 10, translateY: -10, clip: true, svgRandomizeIDs: true);
            Assert.That(link, Is.Not.Null);
        }

        [Test]
        public void GenerateRandomAvaLinkTest()
        {
            var link = DiceBearAPI.GenerateRandomAvaLink(AvaImageFormat.SVG);
            Assert.That(link, Is.Not.Null);
        }

        [Test]
        public void GenerateCustomParametersAdventurerLinkTest()
        {
            var customParams = DiceBearAPI.GenerateAdventurerCustomParamsDict(earRings: EarRings.Variant03, eyeBrows: EyeBrowsAdventurer.Variant10, eyes: EyesAdventurer.Variant15, features: Features.Mustache, glasses: GlassesAdventurer.Variant03, hair: HairAdventurer.Short10, mouth: MouthAdventurer.Variant10);
            var link = DiceBearAPI.GenerateAvaLink(AvaStyle.Adventurer, AvaImageFormat.SVG, seed: "someSeed", flip: false, rotationAngle: 30, scale: 120, borderRadius: 12, sizePx: 256, bg: 0xff123456, bgColorType: BgColorType.Solid, gradientBgColorRotationAngle: 0, translateX: 0, translateY: -10, clip: false, svgRandomizeIDs: true, customParams: customParams);
            Assert.That(link, Is.Not.Null);
        }

        [Test]
        public void GenerateCustomParametersAdventurerNeutralLinkTest()
        {
            var customParams = DiceBearAPI.GenerateAdventurerNeutralCustomParamsDict(eyeBrows: EyeBrowsAdventurer.Variant10, eyes: EyesAdventurer.Variant15, glasses: GlassesAdventurer.Variant03, mouth: MouthAdventurer.Variant10);
            var link = DiceBearAPI.GenerateAvaLink(AvaStyle.AdventurerNeutral, AvaImageFormat.SVG, seed: "someSeed", flip: false, rotationAngle: 30, scale: 120, borderRadius: 12, sizePx: 256, bg: 0xff123456, bgColorType: BgColorType.Solid, gradientBgColorRotationAngle: 0, translateX: 0, translateY: -10, clip: false, svgRandomizeIDs: true, customParams: customParams);
            Assert.That(link, Is.Not.Null);
        }

        [Test]
        public void GenerateCustomParametersAvataaarsLinkTest()
        {
            var customParams = DiceBearAPI.GenerateAvataaarsCustomParamsDict(Accessoires.Eyepatch, clothing: Clothing.hoodie, clothingGraphic: ClothingGraphic.hola, eyeBrows: EyeBrowsAvataaars.frownNatural, eyes: EyesAvataaars.surprised, mouth: MouthAvataaars.serious, top: TopAvataaars.hijab);
            var link = DiceBearAPI.GenerateAvaLink(AvaStyle.Avataaars, AvaImageFormat.SVG, seed: "someSeed", flip: false, rotationAngle: 30, scale: 120, borderRadius: 12, sizePx: 256, bg: 0xff123456, bgColorType: BgColorType.Solid, gradientBgColorRotationAngle: 0, translateX: 0, translateY: -10, clip: false, svgRandomizeIDs: true, customParams: customParams);
            Assert.That(link, Is.Not.Null);
        }

        [Test]
        public void GenerateCustomParametersNotionistsAvaLinkTest()
        {
            var customParams = DiceBearAPI.GenerateNotionistsCustomParamsDict(beard: BeardNotionists.Variant04, body: Body.Variant07, brows: Brows.Variant11, eyes: EyesNotionists.Variant01, gesture: Gesture.waveLongArms, glasses: GlassesNotionists.Variant04, hair: HairNotionists.Variant28, lips: Lips.Variant17, nose: Nose.Variant09);
            var link = DiceBearAPI.GenerateAvaLink(AvaStyle.Notionists, AvaImageFormat.SVG, seed: "someSeed", flip: false, rotationAngle: 30, scale: 120, borderRadius: 12, sizePx: 256, bg: 0xff123456, bgColorType: BgColorType.Solid, gradientBgColorRotationAngle: 0, translateX: 0, translateY: -10, clip: false, svgRandomizeIDs: true, customParams: customParams);
            Assert.That(link, Is.Not.Null);
        }
    }
}

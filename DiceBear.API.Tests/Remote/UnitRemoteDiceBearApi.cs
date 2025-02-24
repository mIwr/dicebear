using DiceBear.API.Model;
using DiceBear.API.Model.Custom;

namespace DiceBear.API.Tests.Remote
{
    internal class UnitRemoteDiceBearApi
    {
        [Test]
        public void DownloadGenAvaLinkTest()
        {
            var bytesTask = DiceBearAPI.GenerateAndDownloadAva(AvaStyle.LoreleiNeutral, AvaImageFormat.SVG, seed: "someSeed");
            bytesTask.Wait();
            var bytes = bytesTask.Result.Data;
            Assert.That(bytes, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void DownloadAdvancedAvaLinkTest()
        {
            var bytesTask = DiceBearAPI.GenerateAndDownloadAva(AvaStyle.LoreleiNeutral, AvaImageFormat.SVG, seed: "someSeed", flip: true, rotationAngle: 30, scale: 90, borderRadius: 12, sizePx: 256, bg: 0xff123456, bgColorType: BgColorType.GradientLinear, gradientBgColorRotationAngle: 45, translateX: 10, translateY: -10, clip: true, svgRandomizeIDs: true);
            bytesTask.Wait();
            var bytes = bytesTask.Result.Data;
            Assert.That(bytes, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void DownloadRandomAvaLinkTest()
        {
            var bytesTask = DiceBearAPI.GenerateRandomAndDownloadAva(AvaImageFormat.SVG);
            bytesTask.Wait();
            var bytes = bytesTask.Result.Data;
            Assert.That(bytes, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void DownloadCustomParametersAdventurerAvaLinkTest()
        {
            var customParams = DiceBearAPI.GenerateAdventurerCustomParamsDict(eyeBrows: EyeBrows.Variant10, eyes: EyesAdventurer.Variant13, features: Features.Mustache, glasses: GlassesAdventurer.Variant03, hair: HairAdventurer.Long19, mouth: Mouth.Variant04);
            var bytesTask = DiceBearAPI.GenerateAndDownloadAva(AvaStyle.Adventurer, AvaImageFormat.SVG, seed: "someSeed", flip: false, rotationAngle: 30, scale: 120, borderRadius: 12, sizePx: 256, bg: 0xff123456, bgColorType: BgColorType.Solid, gradientBgColorRotationAngle: 0, translateX: 0, translateY: -10, clip: false, svgRandomizeIDs: true, customParams: customParams);
            bytesTask.Wait();
            var bytes = bytesTask.Result.Data;
            Assert.That(bytes, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void GenerateCustomParametersAdventurerNeutralLinkTest()
        {
            var customParams = DiceBearAPI.GenerateAdventurerNeutralCustomParamsDict(eyeBrows: EyeBrows.Variant10, eyes: EyesAdventurer.Variant15, glasses: GlassesAdventurer.Variant03, mouth: Mouth.Variant10);
            var bytesTask = DiceBearAPI.GenerateAndDownloadAva(AvaStyle.AdventurerNeutral, AvaImageFormat.SVG, seed: "someSeed", flip: false, rotationAngle: 30, scale: 120, borderRadius: 12, sizePx: 256, bg: 0xff123456, bgColorType: BgColorType.Solid, gradientBgColorRotationAngle: 0, translateX: 0, translateY: -10, clip: false, svgRandomizeIDs: true, customParams: customParams);
            bytesTask.Wait();
            var bytes = bytesTask.Result.Data;
            Assert.That(bytes, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void DownloadCustomParametersNotionistsAvaLinkTest()
        {
            var customParams = DiceBearAPI.GenerateNotionistsCustomParamsDict(beard: BeardNotionists.Variant04, body: Body.Variant07, brows: Brows.Variant11, eyes: EyesNotionists.Variant01, gesture: Gesture.waveLongArms, glasses: GlassesNotionists.Variant04, hair: HairNotionists.Variant28, lips: Lips.Variant17, nose: Nose.Variant09);
            var bytesTask = DiceBearAPI.GenerateAndDownloadAva(AvaStyle.Notionists, AvaImageFormat.SVG, seed: "someSeed", flip: false, rotationAngle: 30, scale: 120, borderRadius: 12, sizePx: 256, bg: 0xff123456, bgColorType: BgColorType.Solid, gradientBgColorRotationAngle: 0, translateX: 0, translateY: -10, clip: false, svgRandomizeIDs: true, customParams: customParams);
            bytesTask.Wait();
            var bytes = bytesTask.Result.Data;
            Assert.That(bytes, Is.Not.Null.And.Not.Empty);
        }
    }
}

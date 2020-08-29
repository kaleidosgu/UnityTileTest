using JetBrains.Annotations;
using UnityEngine;

namespace CustomYamlClass
{
    public class Rootobject
    {
        public int fileFormatVersion { get; set; }
        public string guid { get; set; }
        public Textureimporter TextureImporter { get; set; }
    }

    public class Textureimporter
    {
        public Internalidtonametable[] internalIDToNameTable { get; set; }
        public Externalobjects externalObjects { get; set; }
        public int serializedVersion { get; set; }
        public Mipmaps mipmaps { get; set; }
        public Bumpmap bumpmap { get; set; }
        public int isReadable { get; set; }
        public int streamingMipmaps { get; set; }
        public int streamingMipmapsPriority { get; set; }
        public int grayScaleToAlpha { get; set; }
        public int generateCubemap { get; set; }
        public int cubemapConvolution { get; set; }
        public int seamlessCubemap { get; set; }
        public int textureFormat { get; set; }
        public int maxTextureSize { get; set; }
        public Texturesettings textureSettings { get; set; }
        public int nPOTScale { get; set; }
        public int lightmap { get; set; }
        public int compressionQuality { get; set; }
        public int spriteMode { get; set; }
        public int spriteExtrude { get; set; }
        public int spriteMeshType { get; set; }
        public int alignment { get; set; }
        public Spritepivot spritePivot { get; set; }
        public int spritePixelsToUnits { get; set; }
        public Spriteborder spriteBorder { get; set; }
        public int spriteGenerateFallbackPhysicsShape { get; set; }
        public int alphaUsage { get; set; }
        public int alphaIsTransparency { get; set; }
        public int spriteTessellationDetail { get; set; }
        public int textureType { get; set; }
        public int textureShape { get; set; }
        public int singleChannelComponent { get; set; }
        public int maxTextureSizeSet { get; set; }
        public int compressionQualitySet { get; set; }
        public int textureFormatSet { get; set; }
        public int applyGammaDecoding { get; set; }
        public Platformsetting[] platformSettings { get; set; }
        public Spritesheet spriteSheet { get; set; }
        public object spritePackingTag { get; set; }
        public int pSDRemoveMatte { get; set; }
        public int pSDShowRemoveMatteOption { get; set; }
        public object userData { get; set; }
        public object assetBundleName { get; set; }
        public object assetBundleVariant { get; set; }
    }

    public class Externalobjects
    {
    }

    public class Mipmaps
    {
        public int mipMapMode { get; set; }
        public int enableMipMap { get; set; }
        public int sRGBTexture { get; set; }
        public int linearTexture { get; set; }
        public int fadeOut { get; set; }
        public int borderMipMap { get; set; }
        public int mipMapsPreserveCoverage { get; set; }
        public float alphaTestReferenceValue { get; set; }
        public int mipMapFadeDistanceStart { get; set; }
        public int mipMapFadeDistanceEnd { get; set; }
    }

    public class Bumpmap
    {
        public int convertToNormalMap { get; set; }
        public int externalNormalMap { get; set; }
        public float heightScale { get; set; }
        public int normalMapFilter { get; set; }
    }

    public class Texturesettings
    {
        public int serializedVersion { get; set; }
        public int filterMode { get; set; }
        public int aniso { get; set; }
        public int mipBias { get; set; }
        public int wrapU { get; set; }
        public int wrapV { get; set; }
        public int wrapW { get; set; }
    }

    public class Spritepivot
    {
        public float x { get; set; }
        public float y { get; set; }
    }

    public class Spriteborder
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public int w { get; set; }
    }

    public class Spritesheet
    {
        public int serializedVersion { get; set; }
        public Sprite[] sprites { get; set; }
        public object[] outline { get; set; }
        public object[] physicsShape { get; set; }
        public object[] bones { get; set; }
        public string spriteID { get; set; }
        public int internalID { get; set; }
        public object[] vertices { get; set; }
        public object indices { get; set; }
        public object[] edges { get; set; }
        public object[] weights { get; set; }
        public object[] secondaryTextures { get; set; }
    }

    public class Sprite
    {
        public int serializedVersion { get; set; }
        public string name { get; set; }
        public Rect rect { get; set; }
        public int alignment { get; set; }
        public Pivot pivot { get; set; }
        public Border border { get; set; }
        public object[] outline { get; set; }
        public object[] physicsShape { get; set; }
        public int tessellationDetail { get; set; }
        public object[] bones { get; set; }
        public string spriteID { get; set; }
        public long internalID { get; set; }
        public object[] vertices { get; set; }
        public object indices { get; set; }
        public object[] edges { get; set; }
        public object[] weights { get; set; }
    }

    public class Rect
    {
        public int serializedVersion { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Pivot
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class Border
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public int w { get; set; }
    }

    public class Internalidtonametable
    {
        public First first { get; set; }
        public string second { get; set; }
    }

    public class First
    {
        public long V213 { get; set; }
    }

    public class Platformsetting
    {
        public int serializedVersion { get; set; }
        public string buildTarget { get; set; }
        public int maxTextureSize { get; set; }
        public int resizeAlgorithm { get; set; }
        public int textureFormat { get; set; }
        public int textureCompression { get; set; }
        public int compressionQuality { get; set; }
        public int crunchedCompression { get; set; }
        public int allowsAlphaSplitting { get; set; }
        public int overridden { get; set; }
        public int androidETC2FallbackOverride { get; set; }
        public int forceMaximumCompressionQuality_BC6H_BC7 { get; set; }
    }

}
[System.Serializable]
    public class Rootobject
    {
        public int compressionlevel { get; set; }
        public int height { get; set; }
        public bool infinite { get; set; }
        public Layer[] layers { get; set; }
        public int nextlayerid { get; set; }
        public int nextobjectid { get; set; }
        public string orientation { get; set; }
        public string renderorder { get; set; }
        public string tiledversion { get; set; }
        public int tileheight { get; set; }
        public Tileset[] tilesets { get; set; }
        public int tilewidth { get; set; }
        public string type { get; set; }
        public float version { get; set; }
        public int width { get; set; }
    }

    public class Layer
    {
        public int[] data { get; set; }
        public int height { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int opacity { get; set; }
        public string type { get; set; }
        public bool visible { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class Tileset
    {
        public int columns { get; set; }
        public int firstgid { get; set; }
        public string image { get; set; }
        public int imageheight { get; set; }
        public int imagewidth { get; set; }
        public int margin { get; set; }
        public string name { get; set; }
        public int spacing { get; set; }
        public int tilecount { get; set; }
        public int tileheight { get; set; }
        public int tilewidth { get; set; }
    }
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStripeComponent : CDrawableComponent
	{
		[Ordinal(0)] [RED("diffuseTexture")] 		public CHandle<CBitmapTexture> DiffuseTexture { get; set;}

		[Ordinal(0)] [RED("diffuseTexture2")] 		public CHandle<CBitmapTexture> DiffuseTexture2 { get; set;}

		[Ordinal(0)] [RED("normalTexture")] 		public CHandle<CBitmapTexture> NormalTexture { get; set;}

		[Ordinal(0)] [RED("normalTexture2")] 		public CHandle<CBitmapTexture> NormalTexture2 { get; set;}

		[Ordinal(0)] [RED("blendTexture")] 		public CHandle<CBitmapTexture> BlendTexture { get; set;}

		[Ordinal(0)] [RED("depthTexture")] 		public CHandle<CBitmapTexture> DepthTexture { get; set;}

		[Ordinal(0)] [RED("rotateTexture")] 		public CBool RotateTexture { get; set;}

		[Ordinal(0)] [RED("autoHideDistance")] 		public CFloat AutoHideDistance { get; set;}

		[Ordinal(0)] [RED("textureLength")] 		public CFloat TextureLength { get; set;}

		[Ordinal(0)] [RED("blendTextureLength")] 		public CFloat BlendTextureLength { get; set;}

		[Ordinal(0)] [RED("points", 2,0)] 		public CArray<SStripeControlPoint> Points { get; set;}

		[Ordinal(0)] [RED("width")] 		public CFloat Width { get; set;}

		[Ordinal(0)] [RED("alphaScale")] 		public CFloat AlphaScale { get; set;}

		[Ordinal(0)] [RED("endpointAlpha")] 		public CFloat EndpointAlpha { get; set;}

		[Ordinal(0)] [RED("stripeColor")] 		public CColor StripeColor { get; set;}

		[Ordinal(0)] [RED("density")] 		public CFloat Density { get; set;}

		[Ordinal(0)] [RED("projectToTerrain")] 		public CBool ProjectToTerrain { get; set;}

		[Ordinal(0)] [RED("exposedToNavigation")] 		public CBool ExposedToNavigation { get; set;}

		[Ordinal(0)] [RED("cookedVertices")] 		public DataBuffer CookedVertices { get; set;}

		[Ordinal(0)] [RED("cookedIndices")] 		public DataBuffer CookedIndices { get; set;}

		[Ordinal(0)] [RED("cookedVertexCount")] 		public CUInt32 CookedVertexCount { get; set;}

		[Ordinal(0)] [RED("cookedIndexCount")] 		public CUInt32 CookedIndexCount { get; set;}

		[Ordinal(0)] [RED("cookedBoundingBox")] 		public Box CookedBoundingBox { get; set;}

		public CStripeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStripeComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimationBufferBitwiseCompressed : IAnimationBuffer
	{
		[Ordinal(0)] [RED("compressionPreset")] 		public CEnum<SAnimationBufferBitwiseCompressionPreset> CompressionPreset { get; set;}

		[Ordinal(0)] [RED("compressionSettings")] 		public SAnimationBufferBitwiseCompressionSettings CompressionSettings { get; set;}

		[Ordinal(0)] [RED("sourceDataSize")] 		public CUInt32 SourceDataSize { get; set;}

		[Ordinal(0)] [RED("version")] 		public CUInt32 Version { get; set;}

		[Ordinal(0)] [RED("bones", 129,0)] 		public CArray<SAnimationBufferBitwiseCompressedBoneTrack> Bones { get; set;}

		[Ordinal(0)] [RED("tracks", 129,0)] 		public CArray<SAnimationBufferBitwiseCompressedData> Tracks { get; set;}

		[Ordinal(0)] [RED("data", 129,0)] 		public CByteArray Data { get; set;}

		[Ordinal(0)] [RED("fallbackData", 129,0)] 		public CByteArray FallbackData { get; set;}

		[Ordinal(0)] [RED("deferredData")] 		public DeferredDataBuffer DeferredData { get; set;}

		[Ordinal(0)] [RED("orientationCompressionMethod")] 		public CEnum<SAnimationBufferOrientationCompressionMethod> OrientationCompressionMethod { get; set;}

		[Ordinal(0)] [RED("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(0)] [RED("numFrames")] 		public CUInt32 NumFrames { get; set;}

		[Ordinal(0)] [RED("dt")] 		public CFloat Dt { get; set;}

		[Ordinal(0)] [RED("streamingOption")] 		public CEnum<SAnimationBufferStreamingOption> StreamingOption { get; set;}

		[Ordinal(0)] [RED("nonStreamableBones")] 		public CUInt32 NonStreamableBones { get; set;}

		[Ordinal(0)] [RED("hasRefIKBones")] 		public CBool HasRefIKBones { get; set;}

		public CAnimationBufferBitwiseCompressed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimationBufferBitwiseCompressed(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CWaveletAnimationCompression : IAnimationCompression
	{
		[Ordinal(0)] [RED("quantizationBits")] 		public CUInt8 QuantizationBits { get; set;}

		[Ordinal(0)] [RED("positionTolerance")] 		public CFloat PositionTolerance { get; set;}

		[Ordinal(0)] [RED("rotationTolerance")] 		public CFloat RotationTolerance { get; set;}

		[Ordinal(0)] [RED("scaleTolerance")] 		public CFloat ScaleTolerance { get; set;}

		public CWaveletAnimationCompression(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CWaveletAnimationCompression(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
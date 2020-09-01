using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskUnderwaterSwimAroundTarget : CBTTaskVolumetricMove
	{
		[Ordinal(0)] [RED("distance")] 		public CFloat Distance { get; set;}

		[Ordinal(0)] [RED("frontalHeadingOffset")] 		public CInt32 FrontalHeadingOffset { get; set;}

		[Ordinal(0)] [RED("randomFactor")] 		public CInt32 RandomFactor { get; set;}

		[Ordinal(0)] [RED("randomHeightAmplitude")] 		public CFloat RandomHeightAmplitude { get; set;}

		[Ordinal(0)] [RED("minimumWaterDepth")] 		public CFloat MinimumWaterDepth { get; set;}

		[Ordinal(0)] [RED("useActionTarget")] 		public CBool UseActionTarget { get; set;}

		[Ordinal(0)] [RED("maxProximityToSurface")] 		public CFloat MaxProximityToSurface { get; set;}

		public CBTTaskUnderwaterSwimAroundTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskUnderwaterSwimAroundTarget(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
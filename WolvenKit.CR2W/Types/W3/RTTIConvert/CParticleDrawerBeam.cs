using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleDrawerBeam : IParticleDrawer
	{
		[Ordinal(0)] [RED("texturesPerUnit")] 		public CFloat TexturesPerUnit { get; set;}

		[Ordinal(0)] [RED("spread")] 		public CPtr<IEvaluatorVector> Spread { get; set;}

		[Ordinal(0)] [RED("numSegments")] 		public CUInt32 NumSegments { get; set;}

		public CParticleDrawerBeam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CParticleDrawerBeam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
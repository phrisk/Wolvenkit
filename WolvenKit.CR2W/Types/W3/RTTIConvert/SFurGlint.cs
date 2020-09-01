using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurGlint : CVariable
	{
		[Ordinal(0)] [RED("("glintStrength")] 		public CFloat GlintStrength { get; set;}

		[Ordinal(0)] [RED("("glintCount")] 		public CFloat GlintCount { get; set;}

		[Ordinal(0)] [RED("("glintExponent")] 		public CFloat GlintExponent { get; set;}

		public SFurGlint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurGlint(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
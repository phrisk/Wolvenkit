using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskAnimalSetIsScaredDef : IBehTreeHorseTaskDefinition
	{
		[Ordinal(0)] [RED("("value")] 		public CBool Value { get; set;}

		[Ordinal(0)] [RED("("setOnDeactivate")] 		public CBool SetOnDeactivate { get; set;}

		public CBTTaskAnimalSetIsScaredDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskAnimalSetIsScaredDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
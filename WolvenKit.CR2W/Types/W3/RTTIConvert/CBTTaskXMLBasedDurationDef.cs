using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskXMLBasedDurationDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("("xmlStatName")] 		public CName XmlStatName { get; set;}

		[Ordinal(0)] [RED("("chance")] 		public CInt32 Chance { get; set;}

		[Ordinal(0)] [RED("("endWithFailure")] 		public CBool EndWithFailure { get; set;}

		public CBTTaskXMLBasedDurationDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskXMLBasedDurationDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
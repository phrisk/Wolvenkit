using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class QuestScriptParam : CVariable
	{
		[Ordinal(0)] [RED("name")] 		public CName Name { get; set;}

		[Ordinal(0)] [RED("value")] 		public CVariant Value { get; set;}

		[Ordinal(0)] [RED("softHandle")] 		public CBool SoftHandle { get; set;}

		public QuestScriptParam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new QuestScriptParam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
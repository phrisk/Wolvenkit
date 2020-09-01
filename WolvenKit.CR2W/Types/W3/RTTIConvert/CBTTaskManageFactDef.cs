using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskManageFactDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("("fact")] 		public CString Fact { get; set;}

		[Ordinal(0)] [RED("("value")] 		public CInt32 Value { get; set;}

		[Ordinal(0)] [RED("("add")] 		public CBool Add { get; set;}

		[Ordinal(0)] [RED("("validFor")] 		public CInt32 ValidFor { get; set;}

		[Ordinal(0)] [RED("("doNotCompleteAfter")] 		public CBool DoNotCompleteAfter { get; set;}

		[Ordinal(0)] [RED("("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(0)] [RED("("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("eventName")] 		public CName EventName { get; set;}

		public CBTTaskManageFactDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskManageFactDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
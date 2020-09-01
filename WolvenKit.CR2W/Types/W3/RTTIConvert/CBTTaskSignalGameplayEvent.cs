using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSignalGameplayEvent : IBehTreeTask
	{
		[Ordinal(0)] [RED("("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(0)] [RED("("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(0)] [RED("("onSuccess")] 		public CBool OnSuccess { get; set;}

		[Ordinal(0)] [RED("("onTaggedEntity")] 		public CBool OnTaggedEntity { get; set;}

		[Ordinal(0)] [RED("("tagToFind")] 		public CName TagToFind { get; set;}

		[Ordinal(0)] [RED("("eventName")] 		public CName EventName { get; set;}

		public CBTTaskSignalGameplayEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSignalGameplayEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMiscreantAttachActionTree : IAICustomActionTree
	{
		[Ordinal(0)] [RED("attachmentBone")] 		public CName AttachmentBone { get; set;}

		[Ordinal(0)] [RED("miscreantName")] 		public CName MiscreantName { get; set;}

		[Ordinal(0)] [RED("behaviorGraph")] 		public CName BehaviorGraph { get; set;}

		public CAIMiscreantAttachActionTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIMiscreantAttachActionTree(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
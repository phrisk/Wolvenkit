using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IAttachment : CObject
	{
		[Ordinal(0)] [RED("parent")] 		public CPtr<CNode> Parent { get; set;}

		[Ordinal(0)] [RED("child")] 		public CPtr<CNode> Child { get; set;}

		[Ordinal(0)] [RED("isBroken")] 		public CBool IsBroken { get; set;}

		public IAttachment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new IAttachment(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
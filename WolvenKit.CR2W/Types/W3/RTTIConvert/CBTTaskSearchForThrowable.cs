using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSearchForThrowable : IBehTreeTask
	{
		[Ordinal(0)] [RED("("range")] 		public CFloat Range { get; set;}

		[Ordinal(0)] [RED("("tag")] 		public CName Tag { get; set;}

		[Ordinal(0)] [RED("("selectedObject")] 		public CHandle<CNode> SelectedObject { get; set;}

		[Ordinal(0)] [RED("("physicalComponent")] 		public CHandle<CComponent> PhysicalComponent { get; set;}

		[Ordinal(0)] [RED("("activate")] 		public CBool Activate { get; set;}

		[Ordinal(0)] [RED("("findTime")] 		public CFloat FindTime { get; set;}

		public CBTTaskSearchForThrowable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSearchForThrowable(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskDespawnDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("callFromQuest")] 		public CBool CallFromQuest { get; set;}

		[Ordinal(0)] [RED("despawnEventName")] 		public CName DespawnEventName { get; set;}

		[Ordinal(0)] [RED("disappearfxName")] 		public CName DisappearfxName { get; set;}

		[Ordinal(0)] [RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[Ordinal(0)] [RED("destroyCooldown")] 		public CFloat DestroyCooldown { get; set;}

		public CBTTaskDespawnDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskDespawnDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeCombatTargetSelectionTaskDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("maxTargetDistance")] 		public CFloat MaxTargetDistance { get; set;}

		[Ordinal(0)] [RED("playerPriority")] 		public CInt32 PlayerPriority { get; set;}

		[Ordinal(0)] [RED("targetOnlyPlayer")] 		public CBool TargetOnlyPlayer { get; set;}

		public CBehTreeCombatTargetSelectionTaskDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeCombatTargetSelectionTaskDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
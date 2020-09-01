using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeConditionDistanceToCombatTargetDefinition : CBehTreeNodeConditionDefinition
	{
		[Ordinal(0)] [RED("("minDistance")] 		public CBehTreeValFloat MinDistance { get; set;}

		[Ordinal(0)] [RED("("maxDistance")] 		public CBehTreeValFloat MaxDistance { get; set;}

		[Ordinal(0)] [RED("("checkRotation")] 		public CBool CheckRotation { get; set;}

		public CBehTreeNodeConditionDistanceToCombatTargetDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeConditionDistanceToCombatTargetDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
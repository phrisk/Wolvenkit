using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageCombatPhasesDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("rangedCombatPhaseParameters")] 		public SCombatPhaseParameters RangedCombatPhaseParameters { get; set;}

		[Ordinal(0)] [RED("closeCombatPhaseParameters")] 		public SCombatPhaseParameters CloseCombatPhaseParameters { get; set;}

		[Ordinal(0)] [RED("nonCombatPhaseParameters")] 		public SCombatPhaseParameters NonCombatPhaseParameters { get; set;}

		[Ordinal(0)] [RED("setBehVariableName")] 		public CName SetBehVariableName { get; set;}

		public BTTaskManageCombatPhasesDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageCombatPhasesDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
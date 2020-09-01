using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondDistanceToTargetDef : IBehTreeConditionalTaskDefinition
	{
		[Ordinal(0)] [RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[Ordinal(0)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(0)] [RED("attackRange")] 		public CBool AttackRange { get; set;}

		[Ordinal(0)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(0)] [RED("predictionTime")] 		public CFloat PredictionTime { get; set;}

		public BTCondDistanceToTargetDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTCondDistanceToTargetDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
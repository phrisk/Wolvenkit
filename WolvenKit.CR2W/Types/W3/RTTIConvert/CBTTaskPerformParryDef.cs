using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPerformParryDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[Ordinal(0)] [RED("activationTimeLimitBonusHeavy")] 		public CBehTreeValFloat ActivationTimeLimitBonusHeavy { get; set;}

		[Ordinal(0)] [RED("activationTimeLimitBonusLight")] 		public CBehTreeValFloat ActivationTimeLimitBonusLight { get; set;}

		[Ordinal(0)] [RED("checkParryChance")] 		public CBool CheckParryChance { get; set;}

		[Ordinal(0)] [RED("interruptTaskToExecuteCounter")] 		public CBool InterruptTaskToExecuteCounter { get; set;}

		[Ordinal(0)] [RED("allowParryOverlap")] 		public CBool AllowParryOverlap { get; set;}

		public CBTTaskPerformParryDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPerformParryDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
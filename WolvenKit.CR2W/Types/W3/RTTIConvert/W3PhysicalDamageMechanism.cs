using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PhysicalDamageMechanism : CGameplayEntity
	{
		[Ordinal(0)] [RED("("dmgValue")] 		public CFloat DmgValue { get; set;}

		[Ordinal(0)] [RED("("hitReactionType")] 		public CEnum<EHitReactionType> HitReactionType { get; set;}

		[Ordinal(0)] [RED("("reactivationTimer")] 		public CFloat ReactivationTimer { get; set;}

		[Ordinal(0)] [RED("("animName")] 		public CName AnimName { get; set;}

		[Ordinal(0)] [RED("("shouldRewind")] 		public CBool ShouldRewind { get; set;}

		[Ordinal(0)] [RED("("isActive")] 		public CBool IsActive { get; set;}

		[Ordinal(0)] [RED("("isMoving")] 		public CBool IsMoving { get; set;}

		public W3PhysicalDamageMechanism(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3PhysicalDamageMechanism(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
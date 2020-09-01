using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_Frozen : W3ImmobilizeEffect
	{
		[Ordinal(0)] [RED("("killOnHit")] 		public CBool KillOnHit { get; set;}

		[Ordinal(0)] [RED("("bonusDamagePercents")] 		public CFloat BonusDamagePercents { get; set;}

		[Ordinal(0)] [RED("("targetWasFlying")] 		public CBool TargetWasFlying { get; set;}

		[Ordinal(0)] [RED("("pushPriority")] 		public CEnum<EInteractionPriority> PushPriority { get; set;}

		[Ordinal(0)] [RED("("wasKnockedDown")] 		public CBool WasKnockedDown { get; set;}

		public W3Effect_Frozen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Effect_Frozen(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
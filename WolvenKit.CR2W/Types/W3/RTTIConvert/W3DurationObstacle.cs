using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3DurationObstacle : CGameplayEntity
	{
		[Ordinal(0)] [RED("("lifeTimeDuration")] 		public SRangeF LifeTimeDuration { get; set;}

		[Ordinal(0)] [RED("("disappearanceEffectDuration")] 		public CFloat DisappearanceEffectDuration { get; set;}

		[Ordinal(0)] [RED("("disappearEffectName")] 		public CName DisappearEffectName { get; set;}

		[Ordinal(0)] [RED("("simplyStopEffect")] 		public CBool SimplyStopEffect { get; set;}

		public W3DurationObstacle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3DurationObstacle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
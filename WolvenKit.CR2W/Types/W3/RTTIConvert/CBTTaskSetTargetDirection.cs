using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetTargetDirection : IBehTreeTask
	{
		[Ordinal(0)] [RED("("npcPos")] 		public Vector NpcPos { get; set;}

		[Ordinal(0)] [RED("("vec")] 		public Vector Vec { get; set;}

		[Ordinal(0)] [RED("("curRot")] 		public EulerAngles CurRot { get; set;}

		[Ordinal(0)] [RED("("rot")] 		public EulerAngles Rot { get; set;}

		[Ordinal(0)] [RED("("angleDistance")] 		public CFloat AngleDistance { get; set;}

		[Ordinal(0)] [RED("("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(0)] [RED("("setRotationOnActivate")] 		public CBool SetRotationOnActivate { get; set;}

		[Ordinal(0)] [RED("("setOnAnimEvent")] 		public CBool SetOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("animationEventName")] 		public CName AnimationEventName { get; set;}

		[Ordinal(0)] [RED("("useTargetsTarget")] 		public CBool UseTargetsTarget { get; set;}

		[Ordinal(0)] [RED("("completeOnAllowBlend")] 		public CBool CompleteOnAllowBlend { get; set;}

		public CBTTaskSetTargetDirection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSetTargetDirection(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
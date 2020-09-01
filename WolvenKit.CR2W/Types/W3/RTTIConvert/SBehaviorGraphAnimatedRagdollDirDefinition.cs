using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorGraphAnimatedRagdollDirDefinition : CVariable
	{
		[Ordinal(0)] [RED("("dirIndexValue")] 		public CFloat DirIndexValue { get; set;}

		[Ordinal(0)] [RED("("relativeAngle")] 		public CFloat RelativeAngle { get; set;}

		[Ordinal(0)] [RED("("applyAngleToMovement")] 		public CFloat ApplyAngleToMovement { get; set;}

		[Ordinal(0)] [RED("("replacements", 2,0)] 		public CArray<SBehaviorGraphAnimatedRagdollDirReplacement> Replacements { get; set;}

		public SBehaviorGraphAnimatedRagdollDirDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorGraphAnimatedRagdollDirDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
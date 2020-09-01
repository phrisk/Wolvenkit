using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorConstraintPullStirrupToLegData : CVariable
	{
		[Ordinal(0)] [RED("("stirrupBoneName")] 		public CName StirrupBoneName { get; set;}

		[Ordinal(0)] [RED("("stirrupContactPoint")] 		public Vector StirrupContactPoint { get; set;}

		[Ordinal(0)] [RED("("footBoneName")] 		public CName FootBoneName { get; set;}

		[Ordinal(0)] [RED("("footContactPoint")] 		public Vector FootContactPoint { get; set;}

		[Ordinal(0)] [RED("("toeBoneName")] 		public CName ToeBoneName { get; set;}

		[Ordinal(0)] [RED("("toeAlignStirrupSideDir")] 		public Vector ToeAlignStirrupSideDir { get; set;}

		[Ordinal(0)] [RED("("toeAlignStirrupRotationAxisDir")] 		public Vector ToeAlignStirrupRotationAxisDir { get; set;}

		public SBehaviorConstraintPullStirrupToLegData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorConstraintPullStirrupToLegData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
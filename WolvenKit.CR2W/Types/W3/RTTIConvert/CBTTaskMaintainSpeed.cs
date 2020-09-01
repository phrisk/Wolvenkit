using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskMaintainSpeed : IBehTreeTask
	{
		[Ordinal(0)] [RED("("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[Ordinal(0)] [RED("("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[Ordinal(0)] [RED("("manageFlySpeed")] 		public CBool ManageFlySpeed { get; set;}

		[Ordinal(0)] [RED("("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(0)] [RED("("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(0)] [RED("("speedDecay")] 		public CBool SpeedDecay { get; set;}

		[Ordinal(0)] [RED("("speedDecayOnDeactivate")] 		public CBool SpeedDecayOnDeactivate { get; set;}

		[Ordinal(0)] [RED("("overrideForThisTask")] 		public CBool OverrideForThisTask { get; set;}

		[Ordinal(0)] [RED("("decayAfter")] 		public CFloat DecayAfter { get; set;}

		[Ordinal(0)] [RED("("previousSpeed")] 		public CFloat PreviousSpeed { get; set;}

		public CBTTaskMaintainSpeed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskMaintainSpeed(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
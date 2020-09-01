using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAnimationTrajectoryPlayerToken : CVariable
	{
		[Ordinal(0)] [RED("isValid")] 		public CBool IsValid { get; set;}

		[Ordinal(0)] [RED("pointWS")] 		public Vector PointWS { get; set;}

		[Ordinal(0)] [RED("syncPointMS")] 		public Vector SyncPointMS { get; set;}

		[Ordinal(0)] [RED("timeFactor")] 		public CFloat TimeFactor { get; set;}

		[Ordinal(0)] [RED("syncPointDuration")] 		public CFloat SyncPointDuration { get; set;}

		[Ordinal(0)] [RED("blendIn")] 		public CFloat BlendIn { get; set;}

		[Ordinal(0)] [RED("blendOut")] 		public CFloat BlendOut { get; set;}

		[Ordinal(0)] [RED("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(0)] [RED("syncTime")] 		public CFloat SyncTime { get; set;}

		public SAnimationTrajectoryPlayerToken(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAnimationTrajectoryPlayerToken(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
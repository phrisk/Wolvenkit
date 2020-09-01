using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFlyToActionTree : IFlightActionTree
	{
		[Ordinal(0)] [RED("("acceptDistance")] 		public CFloat AcceptDistance { get; set;}

		[Ordinal(0)] [RED("("targetTag")] 		public CName TargetTag { get; set;}

		[Ordinal(0)] [RED("("rotateBeforeTakeOff")] 		public CBool RotateBeforeTakeOff { get; set;}

		[Ordinal(0)] [RED("("landAtTargetLocation")] 		public CBool LandAtTargetLocation { get; set;}

		[Ordinal(0)] [RED("("landingForwardOffset")] 		public CFloat LandingForwardOffset { get; set;}

		public CFlyToActionTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFlyToActionTree(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
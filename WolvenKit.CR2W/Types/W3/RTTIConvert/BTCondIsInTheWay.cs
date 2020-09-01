using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondIsInTheWay : IBehTreeTask
	{
		[Ordinal(0)] [RED("origin")] 		public CEnum<ETargetName> Origin { get; set;}

		[Ordinal(0)] [RED("obstacle")] 		public CEnum<ETargetName> Obstacle { get; set;}

		[Ordinal(0)] [RED("destination")] 		public CEnum<ETargetName> Destination { get; set;}

		[Ordinal(0)] [RED("returnIfInvalid")] 		public CBool ReturnIfInvalid { get; set;}

		[Ordinal(0)] [RED("requiredDistanceFromLine")] 		public CFloat RequiredDistanceFromLine { get; set;}

		public BTCondIsInTheWay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTCondIsInTheWay(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
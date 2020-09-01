using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAICiriSnowballFightActionTree : IAICustomActionTree
	{
		[Ordinal(0)] [RED("minDistFromTargetToPerformTeleport")] 		public CFloat MinDistFromTargetToPerformTeleport { get; set;}

		[Ordinal(0)] [RED("delayBetweenThrows")] 		public CFloat DelayBetweenThrows { get; set;}

		[Ordinal(0)] [RED("teleportPointTag")] 		public CName TeleportPointTag { get; set;}

		public CAICiriSnowballFightActionTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAICiriSnowballFightActionTree(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
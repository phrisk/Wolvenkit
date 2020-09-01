using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskRiderSetFollowSideBySideActionOnHorse : IBehTreeTask
	{
		[Ordinal(0)] [RED("horseFollowSideBySideAction")] 		public CHandle<CAIFollowSideBySideAction> HorseFollowSideBySideAction { get; set;}

		[Ordinal(0)] [RED("riderData")] 		public CHandle<CAIStorageRiderData> RiderData { get; set;}

		public CBTTaskRiderSetFollowSideBySideActionOnHorse(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskRiderSetFollowSideBySideActionOnHorse(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
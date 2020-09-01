using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskRidingManagerVehicleMount : IBehTreeTask
	{
		[Ordinal(0)] [RED("("mountType")] 		public CName MountType { get; set;}

		[Ordinal(0)] [RED("("riderData")] 		public CHandle<CAIStorageRiderData> RiderData { get; set;}

		[Ordinal(0)] [RED("("attachSlot")] 		public CName AttachSlot { get; set;}

		public CBTTaskRidingManagerVehicleMount(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskRidingManagerVehicleMount(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
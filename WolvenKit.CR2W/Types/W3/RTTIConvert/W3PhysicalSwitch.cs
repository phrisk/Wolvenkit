using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PhysicalSwitch : W3Switch
	{
		[Ordinal(0)] [RED("("switchOnAnimationType")] 		public CEnum<PhysicalSwitchAnimationType> SwitchOnAnimationType { get; set;}

		[Ordinal(0)] [RED("("switchOffAnimationType")] 		public CEnum<PhysicalSwitchAnimationType> SwitchOffAnimationType { get; set;}

		[Ordinal(0)] [RED("("showActorAnimation")] 		public CBool ShowActorAnimation { get; set;}

		public W3PhysicalSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3PhysicalSwitch(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
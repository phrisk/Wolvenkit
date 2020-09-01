using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TripwireSwitch : W3PhysicalSwitch
	{
		[Ordinal(0)] [RED("("autoSwitchOnLeave")] 		public CBool AutoSwitchOnLeave { get; set;}

		[Ordinal(0)] [RED("("entities", 2,0)] 		public CArray<CHandle<CEntity>> Entities { get; set;}

		[Ordinal(0)] [RED("("delayedTurnOffEntity")] 		public CHandle<CEntity> DelayedTurnOffEntity { get; set;}

		[Ordinal(0)] [RED("("delayedTurnOnEntity")] 		public CHandle<CEntity> DelayedTurnOnEntity { get; set;}

		[Ordinal(0)] [RED("("connectedTrapClueTag")] 		public CName ConnectedTrapClueTag { get; set;}

		public W3TripwireSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TripwireSwitch(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
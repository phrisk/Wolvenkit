using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3HorseManager : CPeristentEntity
	{
		[Ordinal(0)] [RED("("inv")] 		public CHandle<CInventoryComponent> Inv { get; set;}

		[Ordinal(0)] [RED("("horseAbilities", 2,0)] 		public CArray<CName> HorseAbilities { get; set;}

		[Ordinal(0)] [RED("("itemSlots", 2,0)] 		public CArray<SItemUniqueId> ItemSlots { get; set;}

		[Ordinal(0)] [RED("("wasSpawned")] 		public CBool WasSpawned { get; set;}

		[Ordinal(0)] [RED("("horseMode")] 		public CEnum<EHorseMode> HorseMode { get; set;}

		public W3HorseManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3HorseManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
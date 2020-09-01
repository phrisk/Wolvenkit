using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAttackEventData : CVariable
	{
		[Ordinal(0)] [RED("animData")] 		public CPreAttackEventData AnimData { get; set;}

		[Ordinal(0)] [RED("weaponId")] 		public SItemUniqueId WeaponId { get; set;}

		[Ordinal(0)] [RED("parriedBy", 2,0)] 		public CArray<CHandle<CActor>> ParriedBy { get; set;}

		public SAttackEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAttackEventData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskReactionToGiantWeaponMonitorDef : IBehTreeConditionalTaskDefinition
	{
		[Ordinal(0)] [RED("effectResourceName")] 		public CName EffectResourceName { get; set;}

		[Ordinal(0)] [RED("playFxOnEffectEntity")] 		public CName PlayFxOnEffectEntity { get; set;}

		[Ordinal(0)] [RED("spawnZOffset")] 		public CFloat SpawnZOffset { get; set;}

		public CBTTaskReactionToGiantWeaponMonitorDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskReactionToGiantWeaponMonitorDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
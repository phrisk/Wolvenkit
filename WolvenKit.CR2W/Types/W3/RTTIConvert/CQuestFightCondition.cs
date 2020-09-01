using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestFightCondition : IQuestCondition
	{
		[Ordinal(0)] [RED("tag")] 		public CName Tag { get; set;}

		[Ordinal(0)] [RED("attackerTag")] 		public CName AttackerTag { get; set;}

		[Ordinal(0)] [RED("referenceValue")] 		public CInt32 ReferenceValue { get; set;}

		[Ordinal(0)] [RED("damageMode")] 		public CEnum<EQueryFightMode> DamageMode { get; set;}

		public CQuestFightCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestFightCondition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
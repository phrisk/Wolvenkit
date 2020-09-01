using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IQuestCombatManagerBaseBlock : CQuestGraphBlock
	{
		[Ordinal(0)] [RED("("npcTags")] 		public TagList NpcTags { get; set;}

		[Ordinal(0)] [RED("("overrideGuardArea")] 		public CBool OverrideGuardArea { get; set;}

		[Ordinal(0)] [RED("("guardAreaTag")] 		public CName GuardAreaTag { get; set;}

		[Ordinal(0)] [RED("("pursuitAreaTag")] 		public CName PursuitAreaTag { get; set;}

		[Ordinal(0)] [RED("("pursuitRange")] 		public CFloat PursuitRange { get; set;}

		public IQuestCombatManagerBaseBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new IQuestCombatManagerBaseBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
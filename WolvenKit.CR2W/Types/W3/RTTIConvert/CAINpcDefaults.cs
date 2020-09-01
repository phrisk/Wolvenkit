using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcDefaults : CAIDefaults
	{
		[Ordinal(0)] [RED("npcGroupType")] 		public CHandle<CAINPCGroupTypeRedefinition> NpcGroupType { get; set;}

		[Ordinal(0)] [RED("combatTree")] 		public CHandle<CAINpcCombat> CombatTree { get; set;}

		[Ordinal(0)] [RED("idleTree")] 		public CHandle<CAIIdleTree> IdleTree { get; set;}

		[Ordinal(0)] [RED("deathTree")] 		public CHandle<CAIDeathTree> DeathTree { get; set;}

		[Ordinal(0)] [RED("reactionTree")] 		public CHandle<CAINpcReactionsTree> ReactionTree { get; set;}

		[Ordinal(0)] [RED("softReactionTree")] 		public CHandle<CAISoftReactionTree> SoftReactionTree { get; set;}

		[Ordinal(0)] [RED("hasDrinkingMinigame")] 		public CBool HasDrinkingMinigame { get; set;}

		[Ordinal(0)] [RED("morphInCombat")] 		public CBool MorphInCombat { get; set;}

		[Ordinal(0)] [RED("tempNpcGroupType")] 		public CEnum<ENPCGroupType> TempNpcGroupType { get; set;}

		public CAINpcDefaults(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAINpcDefaults(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
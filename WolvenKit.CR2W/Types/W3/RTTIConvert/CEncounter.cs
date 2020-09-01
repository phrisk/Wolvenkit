using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEncounter : CGameplayEntity
	{
		[Ordinal(0)] [RED("("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(0)] [RED("("ignoreAreaTrigger")] 		public CBool IgnoreAreaTrigger { get; set;}

		[Ordinal(0)] [RED("("fullRespawnScheduled")] 		public CBool FullRespawnScheduled { get; set;}

		[Ordinal(0)] [RED("("spawnTree")] 		public CPtr<ISpawnTreeBranch> SpawnTree { get; set;}

		[Ordinal(0)] [RED("("creatureDefinition", 2,0)] 		public CArray<CPtr<CEncounterCreatureDefinition>> CreatureDefinition { get; set;}

		[Ordinal(0)] [RED("("encounterParameters")] 		public CHandle<CEncounterParameters> EncounterParameters { get; set;}

		[Ordinal(0)] [RED("("spawnArea")] 		public EntityHandle SpawnArea { get; set;}

		[Ordinal(0)] [RED("("fullRespawnDelay")] 		public GameTime FullRespawnDelay { get; set;}

		[Ordinal(0)] [RED("("isFullRespawnTimeInGameTime")] 		public CBool IsFullRespawnTimeInGameTime { get; set;}

		[Ordinal(0)] [RED("("fullRespawnTime")] 		public GameTime FullRespawnTime { get; set;}

		[Ordinal(0)] [RED("("wasRaining")] 		public CBool WasRaining { get; set;}

		[Ordinal(0)] [RED("("conditionRetestTimeout")] 		public CFloat ConditionRetestTimeout { get; set;}

		[Ordinal(0)] [RED("("defaultImmediateDespawnConfiguration")] 		public SSpawnTreeDespawnConfiguration DefaultImmediateDespawnConfiguration { get; set;}

		[Ordinal(0)] [RED("("spawnTreeType")] 		public CEnum<ESpawnTreeType> SpawnTreeType { get; set;}

		[Ordinal(0)] [RED("("dataManager")] 		public CHandle<CEncounterDataManager> DataManager { get; set;}

		[Ordinal(0)] [RED("("ownerTasksToPerformOnLeaveEncounter", 2,0)] 		public CArray<SOwnerEncounterTaskParams> OwnerTasksToPerformOnLeaveEncounter { get; set;}

		[Ordinal(0)] [RED("("externalTasksToPerformOnLeaveEncounter", 2,0)] 		public CArray<SExternalEncounterTaskParams> ExternalTasksToPerformOnLeaveEncounter { get; set;}

		[Ordinal(0)] [RED("("isUpdating")] 		public CBool IsUpdating { get; set;}

		public CEncounter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEncounter(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
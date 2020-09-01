using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFlyingSwarmGroup : CVariable
	{
		[Ordinal(0)] [RED("("groupId")] 		public CFlyingGroupId GroupId { get; set;}

		[Ordinal(0)] [RED("("groupCenter")] 		public Vector GroupCenter { get; set;}

		[Ordinal(0)] [RED("("targetPosition")] 		public Vector TargetPosition { get; set;}

		[Ordinal(0)] [RED("("currentGroupState")] 		public CName CurrentGroupState { get; set;}

		[Ordinal(0)] [RED("("boidCount")] 		public CInt32 BoidCount { get; set;}

		[Ordinal(0)] [RED("("toSpawnCount")] 		public CInt32 ToSpawnCount { get; set;}

		[Ordinal(0)] [RED("("spawnPoiType")] 		public CName SpawnPoiType { get; set;}

		[Ordinal(0)] [RED("("toDespawnCount")] 		public CInt32 ToDespawnCount { get; set;}

		[Ordinal(0)] [RED("("despawnPoiType")] 		public CName DespawnPoiType { get; set;}

		[Ordinal(0)] [RED("("changeGroupState")] 		public CName ChangeGroupState { get; set;}

		public CFlyingSwarmGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFlyingSwarmGroup(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
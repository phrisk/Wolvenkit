using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskSpawnEntitiesAttackDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(0)] [RED("eventName")] 		public CName EventName { get; set;}

		[Ordinal(0)] [RED("numberOfEntities")] 		public CInt32 NumberOfEntities { get; set;}

		[Ordinal(0)] [RED("timeBetweenSpawn")] 		public CFloat TimeBetweenSpawn { get; set;}

		[Ordinal(0)] [RED("minDistFromTarget")] 		public CFloat MinDistFromTarget { get; set;}

		[Ordinal(0)] [RED("maxDistFromTarget")] 		public CFloat MaxDistFromTarget { get; set;}

		[Ordinal(0)] [RED("minDistFromEachOther")] 		public CFloat MinDistFromEachOther { get; set;}

		[Ordinal(0)] [RED("initialDelay")] 		public CFloat InitialDelay { get; set;}

		[Ordinal(0)] [RED("behVariableToSetOnEnd")] 		public CName BehVariableToSetOnEnd { get; set;}

		[Ordinal(0)] [RED("checkDistanceOfNpcToTarget")] 		public CBool CheckDistanceOfNpcToTarget { get; set;}

		[Ordinal(0)] [RED("spawnEntitiesAroundOwner")] 		public CBool SpawnEntitiesAroundOwner { get; set;}

		public BTTaskSpawnEntitiesAttackDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskSpawnEntitiesAttackDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
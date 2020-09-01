using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBaseCreatureEntry : ISpawnTreeLeafNode
	{
		[Ordinal(0)] [RED("("initializers", 2,0)] 		public CArray<CHandle<ISpawnTreeInitializer>> Initializers { get; set;}

		[Ordinal(0)] [RED("("quantityMin")] 		public CInt32 QuantityMin { get; set;}

		[Ordinal(0)] [RED("("quantityMax")] 		public CInt32 QuantityMax { get; set;}

		[Ordinal(0)] [RED("("spawnInterval")] 		public CFloat SpawnInterval { get; set;}

		[Ordinal(0)] [RED("("waveDelay")] 		public CFloat WaveDelay { get; set;}

		[Ordinal(0)] [RED("("waveCounterHitAtDeathRatio")] 		public CFloat WaveCounterHitAtDeathRatio { get; set;}

		[Ordinal(0)] [RED("("randomizeRotation")] 		public CBool RandomizeRotation { get; set;}

		[Ordinal(0)] [RED("("group")] 		public CInt32 Group { get; set;}

		[Ordinal(0)] [RED("("baseSpawner")] 		public CSpawnTreeWaypointSpawner BaseSpawner { get; set;}

		[Ordinal(0)] [RED("("recalculateDelay")] 		public GameTime RecalculateDelay { get; set;}

		public CBaseCreatureEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBaseCreatureEntry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
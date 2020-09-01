using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskToadBackProjectiles : CBTTaskProjectileAttackWithPrepare
	{
		[Ordinal(0)] [RED("("minDistFromTarget")] 		public CFloat MinDistFromTarget { get; set;}

		[Ordinal(0)] [RED("("maxDistFromTarget")] 		public CFloat MaxDistFromTarget { get; set;}

		[Ordinal(0)] [RED("("range")] 		public CFloat Range { get; set;}

		[Ordinal(0)] [RED("("animEvent", 2,0)] 		public CArray<CName> AnimEvent { get; set;}

		[Ordinal(0)] [RED("("boneNames", 2,0)] 		public CArray<CName> BoneNames { get; set;}

		[Ordinal(0)] [RED("("projectilesShot")] 		public CBool ProjectilesShot { get; set;}

		[Ordinal(0)] [RED("("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		public CBTTaskToadBackProjectiles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskToadBackProjectiles(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
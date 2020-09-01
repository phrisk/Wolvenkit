using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskLeshyRootAttack : CBTTaskAttack
	{
		[Ordinal(0)] [RED("loopTime")] 		public CFloat LoopTime { get; set;}

		[Ordinal(0)] [RED("attackRange")] 		public CFloat AttackRange { get; set;}

		[Ordinal(0)] [RED("dodgeable")] 		public CFloat Dodgeable { get; set;}

		[Ordinal(0)] [RED("projEntity")] 		public CHandle<CEntityTemplate> ProjEntity { get; set;}

		[Ordinal(0)] [RED("collisionGroups", 2,0)] 		public CArray<CName> CollisionGroups { get; set;}

		public CBTTaskLeshyRootAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskLeshyRootAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
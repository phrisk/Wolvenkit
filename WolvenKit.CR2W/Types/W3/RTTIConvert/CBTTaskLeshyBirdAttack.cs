using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskLeshyBirdAttack : CBTTaskSwarm
	{
		[Ordinal(0)] [RED("loopTime")] 		public CFloat LoopTime { get; set;}

		[Ordinal(0)] [RED("attackRange")] 		public CFloat AttackRange { get; set;}

		[Ordinal(0)] [RED("time")] 		public CFloat Time { get; set;}

		[Ordinal(0)] [RED("startingTime")] 		public CFloat StartingTime { get; set;}

		[Ordinal(0)] [RED("attackGroupID")] 		public CFlyingGroupId AttackGroupID { get; set;}

		[Ordinal(0)] [RED("activeSwarm")] 		public CBool ActiveSwarm { get; set;}

		[Ordinal(0)] [RED("projEntity")] 		public CHandle<CEntityTemplate> ProjEntity { get; set;}

		[Ordinal(0)] [RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[Ordinal(0)] [RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		public CBTTaskLeshyBirdAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskLeshyBirdAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
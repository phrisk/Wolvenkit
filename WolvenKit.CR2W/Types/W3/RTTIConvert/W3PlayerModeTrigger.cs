using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PlayerModeTrigger : CGameplayEntity
	{
		[Ordinal(0)] [RED("("isEnabled")] 		public CBool IsEnabled { get; set;}

		[Ordinal(0)] [RED("("isActive")] 		public CBool IsActive { get; set;}

		[Ordinal(0)] [RED("("isPlayerInside")] 		public CBool IsPlayerInside { get; set;}

		[Ordinal(0)] [RED("("playerMode")] 		public CEnum<EPlayerMode> PlayerMode { get; set;}

		public W3PlayerModeTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3PlayerModeTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
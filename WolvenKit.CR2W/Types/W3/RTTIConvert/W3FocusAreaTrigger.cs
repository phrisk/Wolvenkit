using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3FocusAreaTrigger : CGameplayEntity
	{
		[Ordinal(0)] [RED("("rumbleIntensityModifier")] 		public CFloat RumbleIntensityModifier { get; set;}

		[Ordinal(0)] [RED("("isDisabled")] 		public CBool IsDisabled { get; set;}

		[Ordinal(0)] [RED("("intensity")] 		public CFloat Intensity { get; set;}

		[Ordinal(0)] [RED("("isActive")] 		public CBool IsActive { get; set;}

		[Ordinal(0)] [RED("("linkedClues", 2,0)] 		public CArray<EntityHandle> LinkedClues { get; set;}

		[Ordinal(0)] [RED("("linkedCluesTags", 2,0)] 		public CArray<CName> LinkedCluesTags { get; set;}

		public W3FocusAreaTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3FocusAreaTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
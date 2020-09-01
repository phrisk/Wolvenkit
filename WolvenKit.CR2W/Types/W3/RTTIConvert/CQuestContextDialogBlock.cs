using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestContextDialogBlock : CQuestGraphBlock
	{
		[Ordinal(0)] [RED("scene")] 		public CSoft<CStoryScene> Scene { get; set;}

		[Ordinal(0)] [RED("targetScene")] 		public CSoft<CStoryScene> TargetScene { get; set;}

		public CQuestContextDialogBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestContextDialogBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
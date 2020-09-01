using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardInteractiveLookAt : CEntity
	{
		[Ordinal(0)] [RED("("lookAtDirector")] 		public CHandle<CModStoryBoardLookAtDirector> LookAtDirector { get; set;}

		[Ordinal(0)] [RED("("actor")] 		public CHandle<CModStoryBoardActor> Actor { get; set;}

		[Ordinal(0)] [RED("("lookAt")] 		public SStoryBoardLookAtSettings LookAt { get; set;}

		[Ordinal(0)] [RED("("isInteractiveMode")] 		public CBool IsInteractiveMode { get; set;}

		[Ordinal(0)] [RED("("stepRotSize")] 		public CFloat StepRotSize { get; set;}

		public CModStoryBoardInteractiveLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardInteractiveLookAt(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
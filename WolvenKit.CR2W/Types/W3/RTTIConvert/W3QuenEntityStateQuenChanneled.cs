using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuenEntityStateQuenChanneled : W3SignEntityStateChanneling
	{
		[Ordinal(0)] [RED("("HEALING_FACTOR")] 		public CFloat HEALING_FACTOR { get; set;}

		[Ordinal(0)] [RED("("HAXXOR_LeavingState")] 		public CBool HAXXOR_LeavingState { get; set;}

		public W3QuenEntityStateQuenChanneled(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuenEntityStateQuenChanneled(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
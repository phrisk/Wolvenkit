using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFloePiece : CScriptedDestroyableComponent
	{
		[Ordinal(0)] [RED("("totalTime")] 		public CFloat TotalTime { get; set;}

		[Ordinal(0)] [RED("("currPosition")] 		public Vector CurrPosition { get; set;}

		public CFloePiece(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFloePiece(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
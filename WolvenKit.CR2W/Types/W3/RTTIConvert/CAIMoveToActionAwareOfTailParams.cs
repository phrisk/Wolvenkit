using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMoveToActionAwareOfTailParams : CAIMoveToParams
	{
		[Ordinal(0)] [RED("tailTag")] 		public CName TailTag { get; set;}

		[Ordinal(0)] [RED("startMovementDistance")] 		public CFloat StartMovementDistance { get; set;}

		[Ordinal(0)] [RED("stopDistance")] 		public CFloat StopDistance { get; set;}

		public CAIMoveToActionAwareOfTailParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIMoveToActionAwareOfTailParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
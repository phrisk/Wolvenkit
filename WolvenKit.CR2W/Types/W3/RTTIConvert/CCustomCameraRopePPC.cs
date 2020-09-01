using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCustomCameraRopePPC : ICustomCameraPivotPositionController
	{
		[Ordinal(0)] [RED("("dampFactor")] 		public CFloat DampFactor { get; set;}

		[Ordinal(0)] [RED("("smoothZ")] 		public CFloat SmoothZ { get; set;}

		[Ordinal(0)] [RED("("ropeLength")] 		public CFloat RopeLength { get; set;}

		public CCustomCameraRopePPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCustomCameraRopePPC(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
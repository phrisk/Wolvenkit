using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMapPathInstance : CVariable
	{
		[Ordinal(0)] [RED("("id")] 		public CInt32 Id { get; set;}

		[Ordinal(0)] [RED("("position")] 		public Vector Position { get; set;}

		[Ordinal(0)] [RED("("splinePoints", 2,0)] 		public CArray<Vector> SplinePoints { get; set;}

		[Ordinal(0)] [RED("("color")] 		public CInt32 Color { get; set;}

		[Ordinal(0)] [RED("("lineWidth")] 		public CFloat LineWidth { get; set;}

		[Ordinal(0)] [RED("("isAddedToMinimap")] 		public CBool IsAddedToMinimap { get; set;}

		public SMapPathInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMapPathInstance(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
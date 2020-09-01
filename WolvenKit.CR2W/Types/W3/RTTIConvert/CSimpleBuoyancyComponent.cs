using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSimpleBuoyancyComponent : CComponent
	{
		[Ordinal(0)] [RED("waterOffset")] 		public CFloat WaterOffset { get; set;}

		[Ordinal(0)] [RED("linearDamping")] 		public CFloat LinearDamping { get; set;}

		[Ordinal(0)] [RED("pointFront")] 		public Vector PointFront { get; set;}

		[Ordinal(0)] [RED("pointBack")] 		public Vector PointBack { get; set;}

		[Ordinal(0)] [RED("pointLeft")] 		public Vector PointLeft { get; set;}

		[Ordinal(0)] [RED("pointRight")] 		public Vector PointRight { get; set;}

		public CSimpleBuoyancyComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSimpleBuoyancyComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
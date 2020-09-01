using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Bird : CGameplayEntity
	{
		[Ordinal(0)] [RED("("flyingAppearanceName")] 		public CName FlyingAppearanceName { get; set;}

		[Ordinal(0)] [RED("("destroyDistance")] 		public CFloat DestroyDistance { get; set;}

		[Ordinal(0)] [RED("("flyCurves", 2,0)] 		public CArray<CName> FlyCurves { get; set;}

		[Ordinal(0)] [RED("("manager")] 		public CHandle<CBirdsManager> Manager { get; set;}

		public W3Bird(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Bird(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CLayerGroup : ISerializable
	{
		[Ordinal(0)] [RED("name")] 		public CString Name { get; set;}

		[Ordinal(0)] [RED("depotPath")] 		public CString DepotPath { get; set;}

		[Ordinal(0)] [RED("absolutePath")] 		public CString AbsolutePath { get; set;}

		[Ordinal(0)] [RED("isVisibleOnStart")] 		public CBool IsVisibleOnStart { get; set;}

		[Ordinal(0)] [RED("systemGroup")] 		public CBool SystemGroup { get; set;}

		[Ordinal(0)] [RED("hasEmbeddedLayerInfos")] 		public CBool HasEmbeddedLayerInfos { get; set;}

		[Ordinal(0)] [RED("idHash")] 		public CUInt64 IdHash { get; set;}

		public CLayerGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CLayerGroup(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
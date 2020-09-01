using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SItemChangedData : CVariable
	{
		[Ordinal(0)] [RED("("itemName")] 		public CName ItemName { get; set;}

		[Ordinal(0)] [RED("("quantity")] 		public CInt32 Quantity { get; set;}

		[Ordinal(0)] [RED("("ids", 2,0)] 		public CArray<SItemUniqueId> Ids { get; set;}

		[Ordinal(0)] [RED("("informGui")] 		public CBool InformGui { get; set;}

		public SItemChangedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SItemChangedData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
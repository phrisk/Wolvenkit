using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalItem : CJournalContainer
	{
		[Ordinal(0)] [RED("("item")] 		public CName Item { get; set;}

		[Ordinal(0)] [RED("("image")] 		public CString Image { get; set;}

		[Ordinal(0)] [RED("("description")] 		public LocalizedString Description { get; set;}

		public CJournalItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CJournalItem(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
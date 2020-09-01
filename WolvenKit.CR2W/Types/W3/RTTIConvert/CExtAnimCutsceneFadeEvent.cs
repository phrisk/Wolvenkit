using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimCutsceneFadeEvent : CExtAnimEvent
	{
		[Ordinal(0)] [RED("("in")] 		public CBool In { get; set;}

		[Ordinal(0)] [RED("("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(0)] [RED("("color")] 		public CColor Color { get; set;}

		public CExtAnimCutsceneFadeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExtAnimCutsceneFadeEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
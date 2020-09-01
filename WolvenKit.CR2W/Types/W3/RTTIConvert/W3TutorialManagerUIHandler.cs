using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandler : CObject
	{
		[Ordinal(0)] [RED("("listeners", 2,0)] 		public CArray<SUITutorial> Listeners { get; set;}

		[Ordinal(0)] [RED("("lastOpenedMenu")] 		public CName LastOpenedMenu { get; set;}

		[Ordinal(0)] [RED("("isMenuOpened")] 		public CBool IsMenuOpened { get; set;}

		[Ordinal(0)] [RED("("postponedUnregisteredMenu")] 		public CName PostponedUnregisteredMenu { get; set;}

		public W3TutorialManagerUIHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandler(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
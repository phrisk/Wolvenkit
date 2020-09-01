using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4GlossaryStorybookMenu : CR4ListBaseMenu
	{
		[Ordinal(0)] [RED("("allEntries", 2,0)] 		public CArray<CHandle<CJournalStoryBookChapter>> AllEntries { get; set;}

		[Ordinal(0)] [RED("("guiManager")] 		public CHandle<CR4GuiManager> GuiManager { get; set;}

		[Ordinal(0)] [RED("("bMovieIsPlaying")] 		public CBool BMovieIsPlaying { get; set;}

		[Ordinal(0)] [RED("("m_fxSetTitle")] 		public CHandle<CScriptedFlashFunction> M_fxSetTitle { get; set;}

		[Ordinal(0)] [RED("("m_fxSetText")] 		public CHandle<CScriptedFlashFunction> M_fxSetText { get; set;}

		[Ordinal(0)] [RED("("m_fxShowModules")] 		public CHandle<CScriptedFlashFunction> M_fxShowModules { get; set;}

		public CR4GlossaryStorybookMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4GlossaryStorybookMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
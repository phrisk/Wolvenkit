using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4JournalQuestMenu : CR4ListBaseMenu
	{
		[Ordinal(0)] [RED("("allQuests", 2,0)] 		public CArray<CHandle<CJournalQuest>> AllQuests { get; set;}

		[Ordinal(0)] [RED("("currentObjectives", 2,0)] 		public CArray<CHandle<CJournalQuestObjective>> CurrentObjectives { get; set;}

		[Ordinal(0)] [RED("("initialTrackedQuest")] 		public CHandle<CJournalQuest> InitialTrackedQuest { get; set;}

		[Ordinal(0)] [RED("("bDisplayCompleted")] 		public CBool BDisplayCompleted { get; set;}

		[Ordinal(0)] [RED("("m_initSelection")] 		public CBool M_initSelection { get; set;}

		[Ordinal(0)] [RED("("lastSelectedQuestTag")] 		public CName LastSelectedQuestTag { get; set;}

		[Ordinal(0)] [RED("("m_fxSetTrackedQuest")] 		public CHandle<CScriptedFlashFunction> M_fxSetTrackedQuest { get; set;}

		[Ordinal(0)] [RED("("m_fxSetTrackedObj")] 		public CHandle<CScriptedFlashFunction> M_fxSetTrackedObj { get; set;}

		[Ordinal(0)] [RED("("m_fxSetTitle")] 		public CHandle<CScriptedFlashFunction> M_fxSetTitle { get; set;}

		[Ordinal(0)] [RED("("m_fxSetText")] 		public CHandle<CScriptedFlashFunction> M_fxSetText { get; set;}

		[Ordinal(0)] [RED("("m_fxSetExpansionTexture")] 		public CHandle<CScriptedFlashFunction> M_fxSetExpansionTexture { get; set;}

		[Ordinal(0)] [RED("("m_fxUpdateExpansionIcon")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateExpansionIcon { get; set;}

		public CR4JournalQuestMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4JournalQuestMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
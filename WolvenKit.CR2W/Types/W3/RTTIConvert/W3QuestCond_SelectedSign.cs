using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_SelectedSign : CQuestScriptedCondition
	{
		[Ordinal(0)] [RED("("signType")] 		public CEnum<ESignType> SignType { get; set;}

		[Ordinal(0)] [RED("("isFulfilled")] 		public CBool IsFulfilled { get; set;}

		[Ordinal(0)] [RED("("listener")] 		public CHandle<W3QuestCond_SelectedSign_Listener> Listener { get; set;}

		[Ordinal(0)] [RED("("factsNames", 2,0)] 		public CArray<CString> FactsNames { get; set;}

		public W3QuestCond_SelectedSign(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_SelectedSign(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
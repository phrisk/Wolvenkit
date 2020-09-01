using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleHorsePanicBar : CR4HudModuleBase
	{
		[Ordinal(0)] [RED("("m_fxSetPanicSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetPanicSFF { get; set;}

		[Ordinal(0)] [RED("("_panic")] 		public CFloat _panic { get; set;}

		[Ordinal(0)] [RED("("horseMounted")] 		public CBool HorseMounted { get; set;}

		[Ordinal(0)] [RED("("elementShown")] 		public CBool ElementShown { get; set;}

		public CR4HudModuleHorsePanicBar(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleHorsePanicBar(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
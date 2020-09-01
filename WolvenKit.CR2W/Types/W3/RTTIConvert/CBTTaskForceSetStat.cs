using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskForceSetStat : IBehTreeTask
	{
		[Ordinal(0)] [RED("("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(0)] [RED("("percent")] 		public CInt32 Percent { get; set;}

		[Ordinal(0)] [RED("("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(0)] [RED("("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		public CBTTaskForceSetStat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskForceSetStat(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
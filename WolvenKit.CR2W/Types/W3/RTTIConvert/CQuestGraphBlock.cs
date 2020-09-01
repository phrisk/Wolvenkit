using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestGraphBlock : CGraphBlock
	{
		[Ordinal(0)] [RED("name")] 		public CString Name { get; set;}

		[Ordinal(0)] [RED("comment")] 		public CString Comment { get; set;}

		[Ordinal(0)] [RED("forceKeepLoadingScreen")] 		public CBool ForceKeepLoadingScreen { get; set;}

		[Ordinal(0)] [RED("guid")] 		public CGUID Guid { get; set;}

		[Ordinal(0)] [RED("cachedConnections", 2,0)] 		public CArray<SCachedConnections> CachedConnections { get; set;}

		[Ordinal(0)] [RED("hasPatchOutput")] 		public CBool HasPatchOutput { get; set;}

		[Ordinal(0)] [RED("hasTerminationInput")] 		public CBool HasTerminationInput { get; set;}

		public CQuestGraphBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestGraphBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
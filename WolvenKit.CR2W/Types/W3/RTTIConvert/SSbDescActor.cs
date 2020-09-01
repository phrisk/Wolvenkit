using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSbDescActor : CVariable
	{
		[Ordinal(0)] [RED("("uId")] 		public CString UId { get; set;}

		[Ordinal(0)] [RED("("repoActorId")] 		public CString RepoActorId { get; set;}

		[Ordinal(0)] [RED("("template")] 		public CString Template { get; set;}

		[Ordinal(0)] [RED("("appearance")] 		public CString Appearance { get; set;}

		[Ordinal(0)] [RED("("isPlayer")] 		public CBool IsPlayer { get; set;}

		public SSbDescActor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSbDescActor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
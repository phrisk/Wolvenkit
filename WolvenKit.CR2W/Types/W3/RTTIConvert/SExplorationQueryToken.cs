using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SExplorationQueryToken : CVariable
	{
		[Ordinal(0)] [RED("("valid")] 		public CBool Valid { get; set;}

		[Ordinal(0)] [RED("("type")] 		public CEnum<EExplorationType> Type { get; set;}

		[Ordinal(0)] [RED("("pointOnEdge")] 		public Vector PointOnEdge { get; set;}

		[Ordinal(0)] [RED("("normal")] 		public Vector Normal { get; set;}

		[Ordinal(0)] [RED("("usesHands")] 		public CBool UsesHands { get; set;}

		public SExplorationQueryToken(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SExplorationQueryToken(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
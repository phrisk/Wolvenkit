using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphRandomValueNode : CBehaviorGraphValueNode
	{
		[Ordinal(0)] [RED("value")] 		public CFloat Value { get; set;}

		[Ordinal(0)] [RED("randDefaultValue")] 		public CBool RandDefaultValue { get; set;}

		[Ordinal(0)] [RED("rand")] 		public CBool Rand { get; set;}

		[Ordinal(0)] [RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[Ordinal(0)] [RED("min")] 		public CFloat Min { get; set;}

		[Ordinal(0)] [RED("max")] 		public CFloat Max { get; set;}

		public CBehaviorGraphRandomValueNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphRandomValueNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
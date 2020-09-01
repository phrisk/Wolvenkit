using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicGainNode : CBehaviorGraphBaseMimicNode
	{
		[Ordinal(0)] [RED("("gain")] 		public CFloat Gain { get; set;}

		[Ordinal(0)] [RED("("min")] 		public CFloat Min { get; set;}

		[Ordinal(0)] [RED("("max")] 		public CFloat Max { get; set;}

		[Ordinal(0)] [RED("("cachedGainValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedGainValueNode { get; set;}

		public CBehaviorGraphMimicGainNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphMimicGainNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
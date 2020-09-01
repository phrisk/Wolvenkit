using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeExplorationQueueRegisterDefinition : IBehTreeNodeExplorationQueueDecoratorDefinition
	{
		[Ordinal(0)] [RED("timePriority")] 		public CFloat TimePriority { get; set;}

		[Ordinal(0)] [RED("distancePriority")] 		public CFloat DistancePriority { get; set;}

		[Ordinal(0)] [RED("maxTime")] 		public CFloat MaxTime { get; set;}

		[Ordinal(0)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		public CBehTreeNodeExplorationQueueRegisterDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeExplorationQueueRegisterDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
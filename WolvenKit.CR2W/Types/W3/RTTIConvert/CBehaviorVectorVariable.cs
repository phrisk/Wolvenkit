using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorVectorVariable : CBaseBehaviorVariable
	{
		[Ordinal(0)] [RED("value")] 		public Vector Value { get; set;}

		[Ordinal(0)] [RED("defaultValue")] 		public Vector DefaultValue { get; set;}

		[Ordinal(0)] [RED("minValue")] 		public Vector MinValue { get; set;}

		[Ordinal(0)] [RED("maxValue")] 		public Vector MaxValue { get; set;}

		[Ordinal(0)] [RED("space")] 		public CEnum<EVariableSpace> Space { get; set;}

		[Ordinal(0)] [RED("type")] 		public CEnum<EVectorVariableType> Type { get; set;}

		[Ordinal(0)] [RED("shouldBeSyncedBetweenGraphs")] 		public CBool ShouldBeSyncedBetweenGraphs { get; set;}

		public CBehaviorVectorVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorVectorVariable(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
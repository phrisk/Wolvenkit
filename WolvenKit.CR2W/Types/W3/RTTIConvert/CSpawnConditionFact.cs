using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnConditionFact : ISpawnCondition
	{
		[Ordinal(0)] [RED("fact")] 		public CString Fact { get; set;}

		[Ordinal(0)] [RED("value")] 		public CInt32 Value { get; set;}

		[Ordinal(0)] [RED("compare")] 		public CEnum<ECompareFunc> Compare { get; set;}

		public CSpawnConditionFact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSpawnConditionFact(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
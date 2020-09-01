using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CInternalVariableStateTransitionCondition : IBehaviorStateTransitionCondition
	{
		[Ordinal(0)] [RED("variableName")] 		public CName VariableName { get; set;}

		[Ordinal(0)] [RED("compareValue")] 		public CFloat CompareValue { get; set;}

		[Ordinal(0)] [RED("compareFunc")] 		public CEnum<ECompareFunc> CompareFunc { get; set;}

		public CInternalVariableStateTransitionCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CInternalVariableStateTransitionCondition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
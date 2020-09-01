using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetBehVarDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("("behVarName")] 		public CBehTreeValCName BehVarName { get; set;}

		[Ordinal(0)] [RED("("behVarValue")] 		public CBehTreeValFloat BehVarValue { get; set;}

		[Ordinal(0)] [RED("("inAllBehGraphs")] 		public CBool InAllBehGraphs { get; set;}

		[Ordinal(0)] [RED("("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(0)] [RED("("onSuccess")] 		public CBool OnSuccess { get; set;}

		public CBTTaskSetBehVarDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSetBehVarDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
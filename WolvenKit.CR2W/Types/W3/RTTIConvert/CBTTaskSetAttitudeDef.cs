using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetAttitudeDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("("towardsActionTarget")] 		public CBool TowardsActionTarget { get; set;}

		[Ordinal(0)] [RED("("gameplayEventName")] 		public CBehTreeValCName GameplayEventName { get; set;}

		[Ordinal(0)] [RED("("attitude")] 		public CEnum<EAIAttitude> Attitude { get; set;}

		public CBTTaskSetAttitudeDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSetAttitudeDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeCombatTicketRequestDefinition : IBehTreeNodeCombatTicketDecoratorBaseDefinition
	{
		[Ordinal(0)] [RED("ticketRequestValidTime")] 		public CFloat TicketRequestValidTime { get; set;}

		[Ordinal(0)] [RED("requestOnCompletion")] 		public CBool RequestOnCompletion { get; set;}

		[Ordinal(0)] [RED("requestOnInterruption")] 		public CBool RequestOnInterruption { get; set;}

		[Ordinal(0)] [RED("requestWhileActive")] 		public CBool RequestWhileActive { get; set;}

		public CBehTreeNodeCombatTicketRequestDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeCombatTicketRequestDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TakedownGrapplePreyEvents : LocomotionTakedownEvents
	{
		[Ordinal(0)]  [RED("isGrappleReactionVOPlayed")] public CBool IsGrappleReactionVOPlayed { get; set; }

		public TakedownGrapplePreyEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

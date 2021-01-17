using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CoderControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(0)]  [RED("providedAuthorizationLevel")] public CEnum<ESecurityAccessLevel> ProvidedAuthorizationLevel { get; set; }

		public CoderControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
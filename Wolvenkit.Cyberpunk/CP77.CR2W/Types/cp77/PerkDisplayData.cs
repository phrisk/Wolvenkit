using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayData : BasePerkDisplayData
	{
		[Ordinal(0)]  [RED("area")] public CEnum<gamedataPerkArea> Area { get; set; }
		[Ordinal(1)]  [RED("type")] public CEnum<gamedataPerkType> Type { get; set; }

		public PerkDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

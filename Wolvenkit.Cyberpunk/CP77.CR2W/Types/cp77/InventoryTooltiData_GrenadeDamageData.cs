using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryTooltiData_GrenadeDamageData : IScriptable
	{
		[Ordinal(0)]  [RED("statType")] public CEnum<gamedataStatType> StatType { get; set; }
		[Ordinal(1)]  [RED("value")] public CFloat Value { get; set; }

		public InventoryTooltiData_GrenadeDamageData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

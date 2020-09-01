using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskChance : IBehTreeTask
	{
		[Ordinal(0)] [RED("ifNot")] 		public CBool IfNot { get; set;}

		[Ordinal(0)] [RED("chance")] 		public CInt32 Chance { get; set;}

		[Ordinal(0)] [RED("frequency")] 		public CFloat Frequency { get; set;}

		[Ordinal(0)] [RED("scaleWithNumberOfOpponents")] 		public CBool ScaleWithNumberOfOpponents { get; set;}

		[Ordinal(0)] [RED("chancePerOpponent")] 		public CInt32 ChancePerOpponent { get; set;}

		[Ordinal(0)] [RED("lastRollTime")] 		public CFloat LastRollTime { get; set;}

		[Ordinal(0)] [RED("lastRollResult")] 		public CBool LastRollResult { get; set;}

		public CBTTaskChance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskChance(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
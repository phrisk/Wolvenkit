using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimCutsceneWindEvent : CExtAnimCutsceneDurationEvent
	{
		[Ordinal(0)] [RED("("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(0)] [RED("("factor")] 		public CFloat Factor { get; set;}

		[Ordinal(0)] [RED("("useWeightCurve")] 		public CBool UseWeightCurve { get; set;}

		[Ordinal(0)] [RED("("weightCurve")] 		public SCurveData WeightCurve { get; set;}

		public CExtAnimCutsceneWindEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExtAnimCutsceneWindEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
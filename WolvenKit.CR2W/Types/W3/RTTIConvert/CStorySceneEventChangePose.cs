using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventChangePose : CStorySceneEventAnimClip
	{
		[Ordinal(0)] [RED("("stateName")] 		public CName StateName { get; set;}

		[Ordinal(0)] [RED("("status")] 		public CName Status { get; set;}

		[Ordinal(0)] [RED("("emotionalState")] 		public CName EmotionalState { get; set;}

		[Ordinal(0)] [RED("("poseName")] 		public CName PoseName { get; set;}

		[Ordinal(0)] [RED("("transitionAnimation")] 		public CName TransitionAnimation { get; set;}

		[Ordinal(0)] [RED("("useMotionExtraction")] 		public CBool UseMotionExtraction { get; set;}

		[Ordinal(0)] [RED("("forceBodyIdleAnimation")] 		public CName ForceBodyIdleAnimation { get; set;}

		[Ordinal(0)] [RED("("useWeightCurve")] 		public CBool UseWeightCurve { get; set;}

		[Ordinal(0)] [RED("("weightCurve")] 		public SCurveData WeightCurve { get; set;}

		[Ordinal(0)] [RED("("resetCloth")] 		public CEnum<EDialogResetClothAndDanglesType> ResetCloth { get; set;}

		public CStorySceneEventChangePose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventChangePose(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
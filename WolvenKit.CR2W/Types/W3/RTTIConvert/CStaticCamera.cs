using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStaticCamera : CCamera
	{
		[Ordinal(0)] [RED("("solver")] 		public CEnum<ECameraSolver> Solver { get; set;}

		[Ordinal(0)] [RED("("activationDuration")] 		public CFloat ActivationDuration { get; set;}

		[Ordinal(0)] [RED("("deactivationDuration")] 		public CFloat DeactivationDuration { get; set;}

		[Ordinal(0)] [RED("("timeout")] 		public CFloat Timeout { get; set;}

		[Ordinal(0)] [RED("("zoom")] 		public CFloat Zoom { get; set;}

		[Ordinal(0)] [RED("("fov")] 		public CFloat Fov { get; set;}

		[Ordinal(0)] [RED("("animState")] 		public CInt32 AnimState { get; set;}

		[Ordinal(0)] [RED("("guiEffect")] 		public CInt32 GuiEffect { get; set;}

		[Ordinal(0)] [RED("("blockPlayer")] 		public CBool BlockPlayer { get; set;}

		[Ordinal(0)] [RED("("resetPlayerCamera")] 		public CBool ResetPlayerCamera { get; set;}

		[Ordinal(0)] [RED("("fadeStartDuration")] 		public CFloat FadeStartDuration { get; set;}

		[Ordinal(0)] [RED("("fadeStartColor")] 		public CColor FadeStartColor { get; set;}

		[Ordinal(0)] [RED("("isFadeStartFadeIn")] 		public CBool IsFadeStartFadeIn { get; set;}

		[Ordinal(0)] [RED("("fadeEndDuration")] 		public CFloat FadeEndDuration { get; set;}

		[Ordinal(0)] [RED("("fadeEndColor")] 		public CColor FadeEndColor { get; set;}

		[Ordinal(0)] [RED("("isFadeEndFadeIn")] 		public CBool IsFadeEndFadeIn { get; set;}

		public CStaticCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStaticCamera(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
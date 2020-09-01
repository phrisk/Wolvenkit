using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PlayerStateAimThrow : CR4PlayerStateExtendedMovable
	{
		[Ordinal(0)] [RED("camera")] 		public CHandle<CCustomCamera> Camera { get; set;}

		[Ordinal(0)] [RED("fovVel")] 		public CFloat FovVel { get; set;}

		[Ordinal(0)] [RED("initialPitch")] 		public CFloat InitialPitch { get; set;}

		[Ordinal(0)] [RED("cachedHorTimeout")] 		public CFloat CachedHorTimeout { get; set;}

		[Ordinal(0)] [RED("cachedVerTimeout")] 		public CFloat CachedVerTimeout { get; set;}

		[Ordinal(0)] [RED("prevState")] 		public CName PrevState { get; set;}

		[Ordinal(0)] [RED("followTarget")] 		public CBool FollowTarget { get; set;}

		[Ordinal(0)] [RED("followPitch")] 		public CFloat FollowPitch { get; set;}

		[Ordinal(0)] [RED("isRotating")] 		public CBool IsRotating { get; set;}

		public CR4PlayerStateAimThrow(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4PlayerStateAimThrow(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
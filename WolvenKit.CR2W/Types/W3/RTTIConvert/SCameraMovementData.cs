using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCameraMovementData : CVariable
	{
		[Ordinal(0)] [RED("("camera")] 		public CHandle<CCustomCamera> Camera { get; set;}

		[Ordinal(0)] [RED("("pivotPositionController")] 		public CHandle<ICustomCameraPivotPositionController> PivotPositionController { get; set;}

		[Ordinal(0)] [RED("("pivotRotationController")] 		public CHandle<ICustomCameraPivotRotationController> PivotRotationController { get; set;}

		[Ordinal(0)] [RED("("pivotDistanceController")] 		public CHandle<ICustomCameraPivotDistanceController> PivotDistanceController { get; set;}

		[Ordinal(0)] [RED("("pivotPositionValue")] 		public Vector PivotPositionValue { get; set;}

		[Ordinal(0)] [RED("("pivotPositionVelocity")] 		public Vector PivotPositionVelocity { get; set;}

		[Ordinal(0)] [RED("("pivotRotationValue")] 		public EulerAngles PivotRotationValue { get; set;}

		[Ordinal(0)] [RED("("pivotRotationVelocity")] 		public EulerAngles PivotRotationVelocity { get; set;}

		[Ordinal(0)] [RED("("pivotDistanceValue")] 		public CFloat PivotDistanceValue { get; set;}

		[Ordinal(0)] [RED("("pivotDistanceVelocity")] 		public CFloat PivotDistanceVelocity { get; set;}

		[Ordinal(0)] [RED("("cameraLocalSpaceOffset")] 		public Vector CameraLocalSpaceOffset { get; set;}

		[Ordinal(0)] [RED("("cameraLocalSpaceOffsetVel")] 		public Vector CameraLocalSpaceOffsetVel { get; set;}

		[Ordinal(0)] [RED("("cameraOffset")] 		public Vector CameraOffset { get; set;}

		public SCameraMovementData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCameraMovementData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
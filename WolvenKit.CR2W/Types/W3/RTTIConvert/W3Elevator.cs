using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Elevator : CGameplayEntity
	{
		[Ordinal(0)] [RED("("appearanceOnTop")] 		public CString AppearanceOnTop { get; set;}

		[Ordinal(0)] [RED("("appearanceOnGround")] 		public CString AppearanceOnGround { get; set;}

		[Ordinal(0)] [RED("("speed")] 		public CFloat Speed { get; set;}

		[Ordinal(0)] [RED("("currentHeight")] 		public CFloat CurrentHeight { get; set;}

		[Ordinal(0)] [RED("("targetNodeHeight")] 		public CFloat TargetNodeHeight { get; set;}

		[Ordinal(0)] [RED("("currentSpeed")] 		public CFloat CurrentSpeed { get; set;}

		[Ordinal(0)] [RED("("initialSpeed")] 		public CFloat InitialSpeed { get; set;}

		[Ordinal(0)] [RED("("isOnTop")] 		public CBool IsOnTop { get; set;}

		[Ordinal(0)] [RED("("movementStarted")] 		public CBool MovementStarted { get; set;}

		[Ordinal(0)] [RED("("onTopPosChecked")] 		public CBool OnTopPosChecked { get; set;}

		[Ordinal(0)] [RED("("initialHeight")] 		public CFloat InitialHeight { get; set;}

		[Ordinal(0)] [RED("("pos")] 		public Vector Pos { get; set;}

		[Ordinal(0)] [RED("("onTopPos")] 		public Vector OnTopPos { get; set;}

		[Ordinal(0)] [RED("("heightDifference")] 		public CFloat HeightDifference { get; set;}

		[Ordinal(0)] [RED("("goingUp")] 		public CBool GoingUp { get; set;}

		[Ordinal(0)] [RED("("playerOnElevator")] 		public CBool PlayerOnElevator { get; set;}

		[Ordinal(0)] [RED("("playerAttached")] 		public CBool PlayerAttached { get; set;}

		[Ordinal(0)] [RED("("deniedAreaCreated")] 		public CBool DeniedAreaCreated { get; set;}

		[Ordinal(0)] [RED("("blockedActions", 2,0)] 		public CArray<CEnum<EInputActionBlock>> BlockedActions { get; set;}

		[Ordinal(0)] [RED("("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(0)] [RED("("deniedArea1")] 		public CHandle<CEntity> DeniedArea1 { get; set;}

		[Ordinal(0)] [RED("("deniedArea2")] 		public CHandle<CEntity> DeniedArea2 { get; set;}

		[Ordinal(0)] [RED("("deniedArea3")] 		public CHandle<CEntity> DeniedArea3 { get; set;}

		public W3Elevator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Elevator(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
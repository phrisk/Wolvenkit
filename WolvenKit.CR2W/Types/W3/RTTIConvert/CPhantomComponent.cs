using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPhantomComponent : CComponent
	{
		[Ordinal(0)] [RED("("collisionGroupName")] 		public CName CollisionGroupName { get; set;}

		[Ordinal(0)] [RED("("triggeringCollisionGroupNames", 2,0)] 		public CArray<CName> TriggeringCollisionGroupNames { get; set;}

		[Ordinal(0)] [RED("("shapeType")] 		public CEnum<EPhantomShape> ShapeType { get; set;}

		[Ordinal(0)] [RED("("shapeDimensions")] 		public Vector ShapeDimensions { get; set;}

		[Ordinal(0)] [RED("("onTriggerEnteredScriptEvent")] 		public CName OnTriggerEnteredScriptEvent { get; set;}

		[Ordinal(0)] [RED("("onTriggerExitedScriptEvent")] 		public CName OnTriggerExitedScriptEvent { get; set;}

		[Ordinal(0)] [RED("("eventsCalledOnComponent")] 		public CBool EventsCalledOnComponent { get; set;}

		[Ordinal(0)] [RED("("useInQueries")] 		public CBool UseInQueries { get; set;}

		[Ordinal(0)] [RED("("meshCollision")] 		public CHandle<CMesh> MeshCollision { get; set;}

		public CPhantomComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPhantomComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
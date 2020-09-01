using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXDefinition : CObject
	{
		[Ordinal(0)] [RED("trackGroups", 2,0)] 		public CArray<CPtr<CFXTrackGroup>> TrackGroups { get; set;}

		[Ordinal(0)] [RED("length")] 		public CFloat Length { get; set;}

		[Ordinal(0)] [RED("loopStart")] 		public CFloat LoopStart { get; set;}

		[Ordinal(0)] [RED("loopEnd")] 		public CFloat LoopEnd { get; set;}

		[Ordinal(0)] [RED("name")] 		public CName Name { get; set;}

		[Ordinal(0)] [RED("animationName")] 		public CName AnimationName { get; set;}

		[Ordinal(0)] [RED("showDistance")] 		public CFloat ShowDistance { get; set;}

		[Ordinal(0)] [RED("stayInMemory")] 		public CBool StayInMemory { get; set;}

		[Ordinal(0)] [RED("isLooped")] 		public CBool IsLooped { get; set;}

		[Ordinal(0)] [RED("randomStart")] 		public CBool RandomStart { get; set;}

		public CFXDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFXDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStorySceneSpotLightProperties : CVariable
	{
		[Ordinal(0)] [RED("("innerAngle")] 		public CFloat InnerAngle { get; set;}

		[Ordinal(0)] [RED("("outerAngle")] 		public CFloat OuterAngle { get; set;}

		[Ordinal(0)] [RED("("softness")] 		public CFloat Softness { get; set;}

		public SStorySceneSpotLightProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStorySceneSpotLightProperties(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
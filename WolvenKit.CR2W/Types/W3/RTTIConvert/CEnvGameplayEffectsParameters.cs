using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvGameplayEffectsParameters : CVariable
	{
		[Ordinal(0)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(0)] [RED("catEffectBrightnessMultiply")] 		public SSimpleCurve CatEffectBrightnessMultiply { get; set;}

		[Ordinal(0)] [RED("behaviorAnimationMultiplier")] 		public SSimpleCurve BehaviorAnimationMultiplier { get; set;}

		[Ordinal(0)] [RED("specularityMultiplier")] 		public SSimpleCurve SpecularityMultiplier { get; set;}

		[Ordinal(0)] [RED("glossinessMultiplier")] 		public SSimpleCurve GlossinessMultiplier { get; set;}

		public CEnvGameplayEffectsParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvGameplayEffectsParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
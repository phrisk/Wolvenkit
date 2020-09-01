using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEffectInfo : CVariable
	{
		[Ordinal(0)] [RED("("effectType")] 		public CEnum<EEffectType> EffectType { get; set;}

		[Ordinal(0)] [RED("("effectDuration")] 		public CFloat EffectDuration { get; set;}

		[Ordinal(0)] [RED("("effectAbilityName")] 		public CName EffectAbilityName { get; set;}

		[Ordinal(0)] [RED("("customFXName")] 		public CName CustomFXName { get; set;}

		[Ordinal(0)] [RED("("effectCustomValue")] 		public SAbilityAttributeValue EffectCustomValue { get; set;}

		[Ordinal(0)] [RED("("effectCustomParam")] 		public CHandle<W3BuffCustomParams> EffectCustomParam { get; set;}

		[Ordinal(0)] [RED("("applyChance")] 		public CFloat ApplyChance { get; set;}

		public SEffectInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SEffectInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
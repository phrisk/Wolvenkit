using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageMistForm : CBTTaskPlayAnimationEventDecorator
	{
		[Ordinal(0)] [RED("manageMistFormOnAnimEvents")] 		public CBool ManageMistFormOnAnimEvents { get; set;}

		[Ordinal(0)] [RED("enableOnActivate")] 		public CBool EnableOnActivate { get; set;}

		[Ordinal(0)] [RED("enableOnMain")] 		public CBool EnableOnMain { get; set;}

		[Ordinal(0)] [RED("disableOnDeactivate")] 		public CBool DisableOnDeactivate { get; set;}

		[Ordinal(0)] [RED("affectVisibility")] 		public CBool AffectVisibility { get; set;}

		[Ordinal(0)] [RED("affectGameplayVisibility")] 		public CBool AffectGameplayVisibility { get; set;}

		[Ordinal(0)] [RED("affectCollision")] 		public CBool AffectCollision { get; set;}

		[Ordinal(0)] [RED("affectHitAnims")] 		public CBool AffectHitAnims { get; set;}

		[Ordinal(0)] [RED("affectImmortality")] 		public CBool AffectImmortality { get; set;}

		[Ordinal(0)] [RED("delayExecutionInMain")] 		public CFloat DelayExecutionInMain { get; set;}

		[Ordinal(0)] [RED("appearanceOnActivate")] 		public CName AppearanceOnActivate { get; set;}

		[Ordinal(0)] [RED("appearanceOnMain")] 		public CName AppearanceOnMain { get; set;}

		[Ordinal(0)] [RED("restoreAppearanceOnDeactivate")] 		public CBool RestoreAppearanceOnDeactivate { get; set;}

		[Ordinal(0)] [RED("appearanceOnDeactivate")] 		public CName AppearanceOnDeactivate { get; set;}

		[Ordinal(0)] [RED("previousAppearanceName")] 		public CName PreviousAppearanceName { get; set;}

		public BTTaskManageMistForm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageMistForm(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
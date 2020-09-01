using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardAssetWorkMode : CModSbListViewWorkMode
	{
		[Ordinal(0)] [RED("("storyboard")] 		public CHandle<CModStoryBoard> Storyboard { get; set;}

		[Ordinal(0)] [RED("("shotViewer")] 		public CHandle<CModStoryBoardShotViewer> ShotViewer { get; set;}

		[Ordinal(0)] [RED("("assetManager")] 		public CHandle<CModStoryBoardAssetManager> AssetManager { get; set;}

		[Ordinal(0)] [RED("("idlePoseManager")] 		public CHandle<CModStoryBoardIdlePoseListsManager> IdlePoseManager { get; set;}

		[Ordinal(0)] [RED("("animDirector")] 		public CHandle<CModStoryBoardAnimationDirector> AnimDirector { get; set;}

		public CModStoryBoardAssetWorkMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardAssetWorkMode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
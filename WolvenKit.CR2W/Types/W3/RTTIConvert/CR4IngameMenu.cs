using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4IngameMenu : CR4MenuBase
	{
		[Ordinal(0)] [RED("("mInGameConfigWrapper")] 		public CHandle<CInGameConfigWrapper> MInGameConfigWrapper { get; set;}

		[Ordinal(0)] [RED("("inGameConfigBufferedWrapper")] 		public CHandle<CInGameConfigBufferedWrapper> InGameConfigBufferedWrapper { get; set;}

		[Ordinal(0)] [RED("("currentNewGameConfig")] 		public newGameConfig CurrentNewGameConfig { get; set;}

		[Ordinal(0)] [RED("("m_fxNavigateBack")] 		public CHandle<CScriptedFlashFunction> M_fxNavigateBack { get; set;}

		[Ordinal(0)] [RED("("m_fxSetIsMainMenu")] 		public CHandle<CScriptedFlashFunction> M_fxSetIsMainMenu { get; set;}

		[Ordinal(0)] [RED("("m_fxSetCurrentUsername")] 		public CHandle<CScriptedFlashFunction> M_fxSetCurrentUsername { get; set;}

		[Ordinal(0)] [RED("("m_fxSetVersion")] 		public CHandle<CScriptedFlashFunction> M_fxSetVersion { get; set;}

		[Ordinal(0)] [RED("("m_fxShowHelp")] 		public CHandle<CScriptedFlashFunction> M_fxShowHelp { get; set;}

		[Ordinal(0)] [RED("("m_fxSetVisible")] 		public CHandle<CScriptedFlashFunction> M_fxSetVisible { get; set;}

		[Ordinal(0)] [RED("("m_fxSetPanelMode")] 		public CHandle<CScriptedFlashFunction> M_fxSetPanelMode { get; set;}

		[Ordinal(0)] [RED("("m_fxRemoveOption")] 		public CHandle<CScriptedFlashFunction> M_fxRemoveOption { get; set;}

		[Ordinal(0)] [RED("("m_fxSetGameLogoLanguage")] 		public CHandle<CScriptedFlashFunction> M_fxSetGameLogoLanguage { get; set;}

		[Ordinal(0)] [RED("("m_fxUpdateOptionValue")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateOptionValue { get; set;}

		[Ordinal(0)] [RED("("m_fxUpdateInputFeedback")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateInputFeedback { get; set;}

		[Ordinal(0)] [RED("("m_fxOnSaveScreenshotRdy")] 		public CHandle<CScriptedFlashFunction> M_fxOnSaveScreenshotRdy { get; set;}

		[Ordinal(0)] [RED("("m_fxSetIgnoreInput")] 		public CHandle<CScriptedFlashFunction> M_fxSetIgnoreInput { get; set;}

		[Ordinal(0)] [RED("("m_fxForceEnterCurEntry")] 		public CHandle<CScriptedFlashFunction> M_fxForceEnterCurEntry { get; set;}

		[Ordinal(0)] [RED("("m_fxForceBackgroundVis")] 		public CHandle<CScriptedFlashFunction> M_fxForceBackgroundVis { get; set;}

		[Ordinal(0)] [RED("("m_fxSetHardwareCursorOn")] 		public CHandle<CScriptedFlashFunction> M_fxSetHardwareCursorOn { get; set;}

		[Ordinal(0)] [RED("("m_fxSetExpansionText")] 		public CHandle<CScriptedFlashFunction> M_fxSetExpansionText { get; set;}

		[Ordinal(0)] [RED("("m_fxUpdateAnchorsAspectRatio")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateAnchorsAspectRatio { get; set;}

		[Ordinal(0)] [RED("("loadConfPopup")] 		public CHandle<W3ApplyLoadConfirmation> LoadConfPopup { get; set;}

		[Ordinal(0)] [RED("("saveConfPopup")] 		public CHandle<W3SaveGameConfirmation> SaveConfPopup { get; set;}

		[Ordinal(0)] [RED("("newGameConfPopup")] 		public CHandle<W3NewGameConfirmation> NewGameConfPopup { get; set;}

		[Ordinal(0)] [RED("("actionConfPopup")] 		public CHandle<W3ActionConfirmation> ActionConfPopup { get; set;}

		[Ordinal(0)] [RED("("deleteConfPopup")] 		public CHandle<W3DeleteSaveConf> DeleteConfPopup { get; set;}

		[Ordinal(0)] [RED("("diffChangeConfPopup")] 		public CHandle<W3DifficultyChangeConfirmation> DiffChangeConfPopup { get; set;}

		[Ordinal(0)] [RED("("isShowingSaveList")] 		public CBool IsShowingSaveList { get; set;}

		[Ordinal(0)] [RED("("isShowingLoadList")] 		public CBool IsShowingLoadList { get; set;}

		[Ordinal(0)] [RED("("smartKeybindingEnabled")] 		public CBool SmartKeybindingEnabled { get; set;}

		[Ordinal(0)] [RED("("m_structureCreator")] 		public CHandle<IngameMenuStructureCreator> M_structureCreator { get; set;}

		[Ordinal(0)] [RED("("isInLoadselector")] 		public CBool IsInLoadselector { get; set;}

		[Ordinal(0)] [RED("("swapAcceptCancelChanged")] 		public CBool SwapAcceptCancelChanged { get; set;}

		[Ordinal(0)] [RED("("alternativeRadialInputChanged")] 		public CBool AlternativeRadialInputChanged { get; set;}

		[Ordinal(0)] [RED("("EnableUberMovement")] 		public CBool EnableUberMovement { get; set;}

		[Ordinal(0)] [RED("("shouldRefreshKinect")] 		public CBool ShouldRefreshKinect { get; set;}

		[Ordinal(0)] [RED("("isMainMenu")] 		public CBool IsMainMenu { get; set;}

		[Ordinal(0)] [RED("("managingPause")] 		public CBool ManagingPause { get; set;}

		[Ordinal(0)] [RED("("updateInputDeviceRequired")] 		public CBool UpdateInputDeviceRequired { get; set;}

		[Ordinal(0)] [RED("("hasChangedOption")] 		public CBool HasChangedOption { get; set;}

		[Ordinal(0)] [RED("("ignoreInput")] 		public CBool IgnoreInput { get; set;}

		[Ordinal(0)] [RED("("disableAccountPicker")] 		public CBool DisableAccountPicker { get; set;}

		[Ordinal(0)] [RED("("lastSetTag")] 		public CInt32 LastSetTag { get; set;}

		[Ordinal(0)] [RED("("currentLangValue")] 		public CString CurrentLangValue { get; set;}

		[Ordinal(0)] [RED("("lastUsedLangValue")] 		public CString LastUsedLangValue { get; set;}

		[Ordinal(0)] [RED("("currentSpeechLang")] 		public CString CurrentSpeechLang { get; set;}

		[Ordinal(0)] [RED("("lastUsedSpeechLang")] 		public CString LastUsedSpeechLang { get; set;}

		[Ordinal(0)] [RED("("languageName")] 		public CString LanguageName { get; set;}

		[Ordinal(0)] [RED("("panelMode")] 		public CBool PanelMode { get; set;}

		[Ordinal(0)] [RED("("lastSetDifficulty")] 		public CInt32 LastSetDifficulty { get; set;}

		public CR4IngameMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4IngameMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
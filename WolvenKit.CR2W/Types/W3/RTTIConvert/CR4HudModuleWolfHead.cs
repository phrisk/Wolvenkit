using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleWolfHead : CR4HudModuleBase
	{
		[Ordinal(0)] [RED("("m_fxSetVitality")] 		public CHandle<CScriptedFlashFunction> M_fxSetVitality { get; set;}

		[Ordinal(0)] [RED("("m_fxSetStamina")] 		public CHandle<CScriptedFlashFunction> M_fxSetStamina { get; set;}

		[Ordinal(0)] [RED("("m_fxSetToxicity")] 		public CHandle<CScriptedFlashFunction> M_fxSetToxicity { get; set;}

		[Ordinal(0)] [RED("("m_fxSetExperience")] 		public CHandle<CScriptedFlashFunction> M_fxSetExperience { get; set;}

		[Ordinal(0)] [RED("("m_fxSetLockedToxicity")] 		public CHandle<CScriptedFlashFunction> M_fxSetLockedToxicity { get; set;}

		[Ordinal(0)] [RED("("m_fxSetDeadlyToxicity")] 		public CHandle<CScriptedFlashFunction> M_fxSetDeadlyToxicity { get; set;}

		[Ordinal(0)] [RED("("m_fxShowStaminaNeeded")] 		public CHandle<CScriptedFlashFunction> M_fxShowStaminaNeeded { get; set;}

		[Ordinal(0)] [RED("("m_fxSwitchWolfActivation")] 		public CHandle<CScriptedFlashFunction> M_fxSwitchWolfActivation { get; set;}

		[Ordinal(0)] [RED("("m_fxSetSignIconSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetSignIconSFF { get; set;}

		[Ordinal(0)] [RED("("m_fxSetSignTextSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetSignTextSFF { get; set;}

		[Ordinal(0)] [RED("("m_fxSetFocusPointsSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetFocusPointsSFF { get; set;}

		[Ordinal(0)] [RED("("m_fxSetFocusProgressSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetFocusProgressSFF { get; set;}

		[Ordinal(0)] [RED("("m_fxLockFocusPointsSFF")] 		public CHandle<CScriptedFlashFunction> M_fxLockFocusPointsSFF { get; set;}

		[Ordinal(0)] [RED("("m_fxSetCiriAsMainCharacter")] 		public CHandle<CScriptedFlashFunction> M_fxSetCiriAsMainCharacter { get; set;}

		[Ordinal(0)] [RED("("m_fxSetCoatOfArms")] 		public CHandle<CScriptedFlashFunction> M_fxSetCoatOfArms { get; set;}

		[Ordinal(0)] [RED("("m_fxSetShowNewLevelIndicator")] 		public CHandle<CScriptedFlashFunction> M_fxSetShowNewLevelIndicator { get; set;}

		[Ordinal(0)] [RED("("m_fxSetAlwaysDisplayed")] 		public CHandle<CScriptedFlashFunction> M_fxSetAlwaysDisplayed { get; set;}

		[Ordinal(0)] [RED("("m_fxshowMutationFeedback")] 		public CHandle<CScriptedFlashFunction> M_fxshowMutationFeedback { get; set;}

		[Ordinal(0)] [RED("("m_LastVitality")] 		public CFloat M_LastVitality { get; set;}

		[Ordinal(0)] [RED("("m_LastMaxVitality")] 		public CFloat M_LastMaxVitality { get; set;}

		[Ordinal(0)] [RED("("m_LastStamina")] 		public CFloat M_LastStamina { get; set;}

		[Ordinal(0)] [RED("("m_LastMaxStamina")] 		public CFloat M_LastMaxStamina { get; set;}

		[Ordinal(0)] [RED("("m_LastExperience")] 		public CFloat M_LastExperience { get; set;}

		[Ordinal(0)] [RED("("m_LastMaxExperience")] 		public CFloat M_LastMaxExperience { get; set;}

		[Ordinal(0)] [RED("("m_LastToxicity")] 		public CFloat M_LastToxicity { get; set;}

		[Ordinal(0)] [RED("("m_LastLockedToxicity")] 		public CFloat M_LastLockedToxicity { get; set;}

		[Ordinal(0)] [RED("("m_LastMaxToxicity")] 		public CFloat M_LastMaxToxicity { get; set;}

		[Ordinal(0)] [RED("("m_bLastDeadlyToxicity")] 		public CBool M_bLastDeadlyToxicity { get; set;}

		[Ordinal(0)] [RED("("m_medallionActivated")] 		public CBool M_medallionActivated { get; set;}

		[Ordinal(0)] [RED("("m_oveloadedIconVisible")] 		public CBool M_oveloadedIconVisible { get; set;}

		[Ordinal(0)] [RED("("m_focusPoints")] 		public CInt32 M_focusPoints { get; set;}

		[Ordinal(0)] [RED("("m_focusProgress")] 		public CFloat M_focusProgress { get; set;}

		[Ordinal(0)] [RED("("m_iCurrentPositiveEffectsSize")] 		public CInt32 M_iCurrentPositiveEffectsSize { get; set;}

		[Ordinal(0)] [RED("("m_iCurrentNegativeEffectsSize")] 		public CInt32 M_iCurrentNegativeEffectsSize { get; set;}

		[Ordinal(0)] [RED("("m_signIconName")] 		public CString M_signIconName { get; set;}

		[Ordinal(0)] [RED("("m_CurrentSelectedSign")] 		public CEnum<ESignType> M_CurrentSelectedSign { get; set;}

		[Ordinal(0)] [RED("("m_IsPlayerCiri")] 		public CBool M_IsPlayerCiri { get; set;}

		[Ordinal(0)] [RED("("m_curToxicity")] 		public CFloat M_curToxicity { get; set;}

		[Ordinal(0)] [RED("("m_lockedToxicity")] 		public CFloat M_lockedToxicity { get; set;}

		[Ordinal(0)] [RED("("m_curVitality")] 		public CFloat M_curVitality { get; set;}

		[Ordinal(0)] [RED("("m_maxVitality")] 		public CFloat M_maxVitality { get; set;}

		[Ordinal(0)] [RED("("playStaminaSoundCue")] 		public CBool PlayStaminaSoundCue { get; set;}

		public CR4HudModuleWolfHead(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleWolfHead(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
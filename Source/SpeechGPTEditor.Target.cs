// Author: Lucas Vilas-Boas
// Year: 2022
// Repo: 

using UnrealBuildTool;
using System.Collections.Generic;

public class SpeechGPTEditorTarget : TargetRules
{
	public SpeechGPTEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.AddRange(new[] { "SpeechGPT" });
	}
}

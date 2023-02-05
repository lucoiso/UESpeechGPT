// Author: Lucas Vilas-Boas
// Year: 2023
// Repo: https://github.com/lucoiso/UESpeechGPT

using UnrealBuildTool;
using System.Collections.Generic;

public class SpeechGPTTarget : TargetRules
{
	public SpeechGPTTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.AddRange(new[] { "SpeechGPT" });
	}
}

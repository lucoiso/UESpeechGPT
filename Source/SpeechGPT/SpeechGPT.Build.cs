// Author: Lucas Vilas-Boas
// Year: 2023
// Repo: https://github.com/lucoiso/UESpeechGPT

using UnrealBuildTool;

public class SpeechGPT : ModuleRules
{
	public SpeechGPT(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		CppStandard = CppStandardVersion.Cpp17;

		PublicDependencyModuleNames.AddRange(new[]
		{
			"Core",
		});

		PrivateDependencyModuleNames.AddRange(new[]
		{
			"Engine",
			"CoreUObject",
			"InputCore"
		});
	}
}

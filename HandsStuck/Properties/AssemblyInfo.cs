using MelonLoader;
using System.Reflection;
using System.Runtime.InteropServices;

#region MelonLoader

[assembly: MelonInfo(typeof(HandsStuck.HandsStuck), "HandsStuck", HandsStuck.HandsStuck.Version, "HAHOOS", "https://thunderstore.io/c/bonelab/p/HAHOOS/HandsStuck")]
[assembly: MelonGame("Stress Level Zero", "BONELAB")]
[assembly: MelonColor(0, 191, 35, 0)]

#endregion MelonLoader

#region General

[assembly: AssemblyTitle("Fixes the controller tracking bug in newer versions of SteamVR")]
[assembly: AssemblyDescription("Fixes the controller tracking bug in newer versions of SteamVR")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("HAHOOS")]
[assembly: AssemblyProduct("HandsStuck")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyVersion(HandsStuck.HandsStuck.Version)]
[assembly: AssemblyFileVersion(HandsStuck.HandsStuck.Version)]
[assembly: AssemblyInformationalVersion(HandsStuck.HandsStuck.Version)]

#endregion General

#region Other

[assembly: ComVisible(false)]
[assembly: Guid("5293f777-bfbf-4a4d-a006-95a2fc2670c3")]

#endregion Other
using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(RainRemover.BuildInfo.Description)]
[assembly: AssemblyDescription(RainRemover.BuildInfo.Description)]
[assembly: AssemblyCompany(RainRemover.BuildInfo.Company)]
[assembly: AssemblyProduct(RainRemover.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + RainRemover.BuildInfo.Author)]
[assembly: AssemblyTrademark(RainRemover.BuildInfo.Company)]
[assembly: AssemblyVersion(RainRemover.BuildInfo.Version)]
[assembly: AssemblyFileVersion(RainRemover.BuildInfo.Version)]
[assembly: MelonInfo(typeof(RainRemover.RainRemover), RainRemover.BuildInfo.Name, RainRemover.BuildInfo.Version, RainRemover.BuildInfo.Author, RainRemover.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]
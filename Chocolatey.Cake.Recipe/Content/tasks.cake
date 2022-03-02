public class BuildTasks
{
    public CakeTaskBuilder InspectCodeTask { get; set; }
    public CakeTaskBuilder CreateIssuesReportTask { get; set; }
    public CakeTaskBuilder AnalyzeTask { get; set; }
    public CakeTaskBuilder UploadArtifactsTask { get; set; }
    public CakeTaskBuilder CleanTask { get; set; }
    public CakeTaskBuilder DotNetCoreCleanTask { get; set; }
    public CakeTaskBuilder RestoreTask { get; set; }
    public CakeTaskBuilder DotNetCoreRestoreTask { get; set; }
    public CakeTaskBuilder BuildTask { get; set; }
    public CakeTaskBuilder DotNetCoreBuildTask { get; set; }
    public CakeTaskBuilder DotNetCorePackTask { get; set; }
    public CakeTaskBuilder DotNetCorePublishTask { get; set; }
    public CakeTaskBuilder PackageTask { get; set; }
    public CakeTaskBuilder DefaultTask { get; set; }
    public CakeTaskBuilder ContinuousIntegrationTask { get; set; }
    public CakeTaskBuilder PreviewTask { get; set; }
    public CakeTaskBuilder PublishDocsTask { get; set; }
    public CakeTaskBuilder CopyNuspecFolder { get; set; }
    public CakeTaskBuilder CreateChocolateyPackagesTask { get; set; }
    public CakeTaskBuilder CreateNuGetPackagesTask { get; set; }
    public CakeTaskBuilder PublishPreReleasePackagesTask { get; set; }
    public CakeTaskBuilder PublishReleasePackagesTask { get; set; }
    public CakeTaskBuilder InstallReportUnitTask { get; set; }
    public CakeTaskBuilder ObfuscateAssembliesTask { get; set; }
    public CakeTaskBuilder SignPowerShellScriptsTask { get; set; }
    public CakeTaskBuilder SignAssembliesTask { get; set; }
    public CakeTaskBuilder ConfigurationBuilderTask { get; set; }
    public CakeTaskBuilder GenerateFriendlyTestReportTask { get; set; }
    public CakeTaskBuilder GenerateLocalCoverageReportTask { get; set; }
    public CakeTaskBuilder ReportCodeCoverageMetricsTask { get; set; }
    public CakeTaskBuilder IntegrationTestTask { get;set; }
    public CakeTaskBuilder DotNetCoreTestTask { get; set; }
    public CakeTaskBuilder InstallOpenCoverTask { get; set; }
    public CakeTaskBuilder TestNUnitTask { get; set; }
    public CakeTaskBuilder TestxUnitTask { get; set; }
    public CakeTaskBuilder TestTask { get; set; }
    public CakeTaskBuilder InstallReportGeneratorTask { get; set; }
    public CakeTaskBuilder ReportMessagesToCi {get; set; }
    public CakeTaskBuilder StrongNameSignerTask { get; set; }
    public CakeTaskBuilder InstallSNRemoveTask { get; set; }
    public CakeTaskBuilder ChangeStrongNameSignatures { get; set; }

    // GitReleaseManager Tasks
    public CakeTaskBuilder ReleaseNotesTask { get; set; }
    public CakeTaskBuilder CreateReleaseNotesTask { get; set; }
    public CakeTaskBuilder ExportReleaseNotesTask { get; set; }
    public CakeTaskBuilder PublishGitHubReleaseTask { get; set; }
    public CakeTaskBuilder LabelsTask { get; set; }
    public CakeTaskBuilder CreateDefaultLabelsTask { get; set; }

    // Transifex Tasks
    public CakeTaskBuilder TransifexPullTranslations { get; set; }
    public CakeTaskBuilder TransifexPushSourceResource { get; set; }
    public CakeTaskBuilder TransifexPushTranslations { get; set; }
    public CakeTaskBuilder TransifexSetupTask { get; set; }
}
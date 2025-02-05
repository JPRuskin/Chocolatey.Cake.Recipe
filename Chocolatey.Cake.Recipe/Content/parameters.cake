public enum BranchType
{
    Unknown,
    HotFix,
    Release,
    Develop,
    Master
}

public static class BuildParameters
{
    public static BranchType BranchType { get; private set; }
    public static PlatformFamily BuildAgentOperatingSystem { get; private set; }
    public static string BuildCounter { get; private set; }
    public static IBuildProvider BuildProvider { get; private set; }
    public static Cake.Core.Configuration.ICakeConfiguration CakeConfiguration { get; private set; }
    public static bool CanRunGitReleaseManager { get { return !string.IsNullOrEmpty(BuildParameters.GitHub.Token); } }
    public static string CertificateAlgorithm { get; private set; }
    public static string CertificateFilePath { get; private set; }
    public static string CertificatePassword { get; private set; }
    public static string CertificateSubjectName { get; private set; }
    public static string CertificateTimestampUrl { get; private set; }
    public static string Configuration { get; private set; }
    public static string DeploymentEnvironment { get; private set; }
    public static string DevelopBranchName { get; private set; }
    public static bool ForceContinuousIntegration { get; private set; }
    public static FilePath FullReleaseNotesFilePath { get; private set; }
    public static Func<FilePathCollection> GetFilesToObfuscate { get; private set; }
    public static Func<FilePathCollection> GetFilesToSign { get; private set; }
    public static Func<List<ILMergeConfig>> GetILMergeConfigs { get; private set; }
    public static Func<FilePathCollection> GetMsisToSign { get; private set; }
    public static Func<FilePathCollection> GetProjectsToPack { get; private set; }
    public static Func<FilePathCollection> GetScriptsToSign { get; private set; }
    public static GitHubCredentials GitHub { get; private set; }
    public static FilePath IntegrationTestScriptPath { get; private set; }
    public static bool IsDotNetBuild { get; set; }
    public static bool IsLocalBuild { get; private set; }
    public static bool IsPullRequest { get; private set; }
    public static bool IsRepositoryHostedOnGitHub { get; private set; }
    public static bool IsRunningOnGitHubActions { get; private set; }
    public static bool IsRunningOnTeamCity { get; private set; }
    public static bool IsTagged { get; private set; }
    public static string MasterBranchName { get; private set; }
    public static FilePath MilestoneReleaseNotesFilePath { get; private set; }
    public static ICollection<string> NuGetSources { get; private set; }
    public static bool ObfuscateAssembly { get; private set; }
    public static List<PackageSourceData> PackageSources { get; private set; }
    public static BuildPaths Paths { get; private set; }
    public static bool PreferDotNetGlobalToolUsage { get; private set; }
    public static string PreReleaseLabelFilePath { get; private set; }
    public static bool PrepareLocalRelease { get; set; }
    public static bool ProductClsCompliant { get; private set; }
    public static string ProductCompany { get; private set; }
    public static bool ProductComVisible { get; private set; }
    public static string ProductCopyright { get; private set; }
    public static ICollection<AssemblyInfoCustomAttribute> ProductCustomAttributes { get; private set; }
    public static string ProductDescription { get; private set; }
    public static string ProductName { get; private set; }
    public static string ProductTrademark { get; private set; }
    public static string RepositoryName { get; private set; }
    public static string RepositoryOwner { get; private set; }
    public static string ResharperSettingsFileName { get; private set; }
    public static DirectoryPath RestorePackagesDirectory { get; private set; }
    public static DirectoryPath RootDirectoryPath { get; private set; }
    public static bool ShouldAuthenticodeSignMsis { get; private set; }
    public static bool ShouldAuthenticodeSignOutputAssemblies { get; private set; }
    public static bool ShouldAuthenticodeSignPowerShellScripts { get; private set; }
    public static bool ShouldBuildMsi { get; private set; }
    public static bool ShouldBuildNuGetSourcePackage { get; private set; }
    public static bool ShouldDownloadFullReleaseNotes { get; private set; }
    public static bool ShouldDownloadMilestoneReleaseNotes { get; private set; }
    public static bool ShouldGenerateSolutionVersionCSharpFile { get; private set; }
    public static bool ShouldObfuscateOutputAssemblies { get; private set; }
    public static bool ShouldPublishAwsLambdas { get; private set; }
    public static bool ShouldPublishPreReleasePackages { get; private set; }
    public static bool ShouldPublishReleasePackages { get; private set; }
    public static bool ShouldReportCodeCoverageMetrics { get; private set; }
    public static bool ShouldReportUnitTestResults { get; private set; }
    public static bool ShouldRunChocolatey { get; private set; }
    public static bool ShouldRunDotNetPack { get; private set; }
    public static bool ShouldRunDotNetTest { get; private set; }
    public static bool ShouldRunGitReleaseManager { get; private set; }
    public static bool ShouldRunGitVersion { get; private set; }
    public static bool ShouldRunILMerge { get; private set; }
    public static bool ShouldRunInspectCode { get; private set; }
    public static bool ShouldRunNuGet { get; private set; }
    public static bool ShouldRunNUnit { get; private set; }
    public static bool ShouldRunOpenCover { get; private set; }
    public static bool ShouldRunReportGenerator { get; private set; }
    public static bool ShouldRunReportUnit { get; private set; }
    public static bool ShouldRunTransifex { get; set; }
    public static bool ShouldRunxUnit { get; private set; }
    public static bool ShouldStrongNameOutputAssemblies { get; private set; }
    public static bool ShouldStrongNameSignDependentAssemblies { get; private set; }
    public static DirectoryPath SolutionDirectoryPath { get; private set; }
    public static FilePath SolutionFilePath { get; private set; }
    public static DirectoryPath SourceDirectoryPath { get; private set; }
    public static string StrongNameDependentAssembliesInputPath { get; private set; }
    public static string StrongNameKeyPath { get; private set; }
    public static string Target { get; private set; }
    public static BuildTasks Tasks { get; set; }
    public static string TestAssemblyFilePattern { get; private set; }
    public static string TestAssemblyProjectPattern { get; private set; }
    public static DirectoryPath TestDirectoryPath { get; private set; }
    public static string TestExecutionType { get; private set; }
    public static string Title { get; private set; }
    public static TransifexCredentials Transifex { get; private set; }
    public static TransifexMode TransifexPullMode { get; private set; }
    public static int TransifexPullPercentage { get; private set; }
    public static bool TreatWarningsAsErrors { get; set; }
    public static bool UseChocolateyGuiStrongNameKey { get; private set; }
    public static BuildVersion Version { get; private set; }

    static BuildParameters()
    {
        Tasks = new BuildTasks();
    }

    public static void SetBuildVersion(BuildVersion version)
    {
        Version  = version;
    }

    public static void SetBuildPaths(BuildPaths paths)
    {
        Paths = paths;
    }

    public static void PrintParameters(ICakeContext context)
    {
        if (context == null)
        {
            throw new ArgumentNullException("context");
        }

        context.Information("Printing Build Parameters...");
        context.Information("------------------------------------------------------------------------------------------");
        context.Information("BranchType: {0}", BranchType);
        context.Information("BranchName: {0}", BuildProvider.Repository.Branch);
        context.Information("BuildAgentOperatingSystem: {0}", BuildAgentOperatingSystem);
        context.Information("BuildCounter: {0}", BuildCounter);
        context.Information("BuildDirectoryPath: {0}", context.MakeAbsolute(Paths.Directories.Build));
        context.Information("BuildProviderRepositoryName: {0}", BuildProvider.Repository.Name);
        context.Information("Configuration: {0}", Configuration);
        context.Information("ForceContinuousIntegration: {0}", ForceContinuousIntegration);
        context.Information("IsLocalBuild: {0}", IsLocalBuild);
        context.Information("IsPullRequest: {0}", IsPullRequest);
        context.Information("IsTagged: {0}", IsTagged);
        context.Information("NuGetSources: {0}", string.Join(", ", NuGetSources));
        context.Information("ObfuscateAssembly: {0}", ObfuscateAssembly);
        context.Information("PreferDotNetGlobalToolUsage: {0}", PreferDotNetGlobalToolUsage);
        context.Information("PrepareLocalRelease: {0}", BuildParameters.PrepareLocalRelease);
        context.Information("ProductName: {0}", ProductName);
        context.Information("ProductDescription: {0}", ProductDescription);
        context.Information("ProductCopyright: {0}", ProductCopyright);
        context.Information("ProductComVisible: {0}", ProductComVisible);
        context.Information("ProductClsCompliant: {0}", ProductClsCompliant);
        context.Information("ProductCompany: {0}", ProductCompany);

        if (ProductCustomAttributes != null)
        {
            context.Information("ProductCustomAttributes: {0}", string.Join(", ", ProductCustomAttributes));
        }
        else
        {
            context.Information("ProductCustomAttributes: No Product Custom Attributes being used");
        }

        context.Information("ProductTrademark: {0}", ProductTrademark);

        context.Information("RepositoryName: {0}", RepositoryName);
        context.Information("RepositoryOwner: {0}", RepositoryOwner);
        context.Information("RestorePackagesDirectory: {0}", RestorePackagesDirectory);
        context.Information("ShouldAuthenticodeSignMsis: {0}", BuildParameters.ShouldAuthenticodeSignMsis);
        context.Information("ShouldAuthenticodeSignOutputAssemblies: {0}", BuildParameters.ShouldAuthenticodeSignOutputAssemblies);
        context.Information("ShouldAuthenticodeSignPowerShellScripts: {0}", BuildParameters.ShouldAuthenticodeSignPowerShellScripts);
        context.Information("ShouldBuildMsi: {0}", BuildParameters.ShouldBuildMsi);
        context.Information("ShouldBuildNuGetSourcePackage: {0}", BuildParameters.ShouldBuildNuGetSourcePackage);
        context.Information("ShouldDownloadFullReleaseNotes: {0}", BuildParameters.ShouldDownloadFullReleaseNotes);
        context.Information("ShouldDownloadMilestoneReleaseNotes: {0}", BuildParameters.ShouldDownloadMilestoneReleaseNotes);
        context.Information("ShouldGenerateSolutionVersionCSharpFile: {0}", BuildParameters.ShouldGenerateSolutionVersionCSharpFile);
        context.Information("ShouldObfuscateOutputAssemblies: {0}", BuildParameters.ShouldObfuscateOutputAssemblies);
        context.Information("ShouldPublishAwsLambdas: {0}", BuildParameters.ShouldPublishAwsLambdas);
        context.Information("ShouldPublishPreReleasePackages: {0}", BuildParameters.ShouldPublishPreReleasePackages);
        context.Information("ShouldPublishReleasePackages: {0}", BuildParameters.ShouldPublishReleasePackages);
        context.Information("ShouldReportCodeCoverageMetrics: {0}", BuildParameters.ShouldReportCodeCoverageMetrics);
        context.Information("ShouldReportUnitTestResults: {0}", BuildParameters.ShouldReportUnitTestResults);
        context.Information("ShouldRunChocolatey: {0}", BuildParameters.ShouldRunChocolatey);
        context.Information("ShouldRunDotNetPack: {0}", BuildParameters.ShouldRunDotNetPack);
        context.Information("ShouldRunDotNetTest: {0}", BuildParameters.ShouldRunDotNetTest);
        context.Information("ShouldRunGitReleaseManager: {0}", BuildParameters.ShouldRunGitReleaseManager);
        context.Information("ShouldRunGitVersion: {0}", BuildParameters.ShouldRunGitVersion);
        context.Information("ShouldRunILMerge: {0}", BuildParameters.ShouldRunILMerge);
        context.Information("ShouldRunInspectCode: {0}", BuildParameters.ShouldRunInspectCode);
        context.Information("ShouldRunNuGet: {0}", BuildParameters.ShouldRunNuGet);
        context.Information("ShouldRunNUnit: {0}", BuildParameters.ShouldRunNUnit);
        context.Information("ShouldRunOpenCover: {0}", BuildParameters.ShouldRunOpenCover);
        context.Information("ShouldRunReportGenerator: {0}", BuildParameters.ShouldRunReportGenerator);
        context.Information("ShouldRunReportUnit: {0}", BuildParameters.ShouldRunReportUnit);
        context.Information("ShouldRunTransifex: {0}", BuildParameters.ShouldRunTransifex);
        context.Information("ShouldRunxUnit: {0}", BuildParameters.ShouldRunxUnit);
        context.Information("ShouldStrongNameOutputAssemblies: {0}", BuildParameters.ShouldStrongNameOutputAssemblies);
        context.Information("ShouldStrongNameSignDependentAssemblies: {0}", BuildParameters.ShouldStrongNameSignDependentAssemblies);
        context.Information("SolutionFilePath: {0}", context.MakeAbsolute((FilePath)SolutionFilePath));
        context.Information("SolutionDirectoryPath: {0}", context.MakeAbsolute((DirectoryPath)SolutionDirectoryPath));
        context.Information("SourceDirectoryPath: {0}", context.MakeAbsolute(SourceDirectoryPath));
        context.Information("StrongNameDependentAssembliesInputPath: {0}", StrongNameDependentAssembliesInputPath);
        context.Information("Target: {0}", Target);
        context.Information("TestAssemblyFilePattern: {0}", TestAssemblyFilePattern);
        context.Information("TestAssemblyProjectPattern: {0}", TestAssemblyProjectPattern);
        context.Information("TestExecutionType: {0}", TestExecutionType);

        if (ShouldRunTransifex)
        {
            context.Information("TransifexPullMode: {0}", TransifexPullMode);
            context.Information("TransifexPullPercentage: {0}", TransifexPullPercentage);
        }

        context.Information("TreatWarningsAsErrors: {0}", TreatWarningsAsErrors);
        context.Information("UseChocolateyGuiStrongNameKey: {0}", UseChocolateyGuiStrongNameKey);

        context.Information("------------------------------------------------------------------------------------------");
    }

    public static void SetParameters(
        ICakeContext context,
        BuildSystem buildSystem,
        DirectoryPath sourceDirectoryPath,
        string title,
        string certificateSubjectName = null,
        string developBranchName = "develop",
        FilePath fullReleaseNotesFilePath = null,
        Func<FilePathCollection> getFilesToObfuscate = null,
        Func<FilePathCollection> getFilesToSign = null,
        Func<List<ILMergeConfig>> getILMergeConfigs = null,
        Func<FilePathCollection> getMsisToSign = null,
        Func<FilePathCollection> getProjectsToPack = null,
        Func<FilePathCollection> getScriptsToSign = null,
        string integrationTestScriptPath = null,
        string masterBranchName = "master",
        FilePath milestoneReleaseNotesFilePath = null,
        ICollection<string> nuGetSources = null,
        bool obfuscateAssembly = false,
        List<PackageSourceData> packageSourceDatas = null,
        bool preferDotNetGlobalToolUsage = false,
        string preReleaseLabelFilePath = null,
        bool productClsCompliant = false,
        string productCompany = null,
        bool productComVisible = false,
        string productCopyright = null,
        ICollection<AssemblyInfoCustomAttribute> productCustomAttributes = null,
        string productDescription = null,
        string productName = null,
        string productTrademark = null,
        string repositoryName = null,
        string repositoryOwner = null,
        string resharperSettingsFileName = null,
        DirectoryPath restorePackagesDirectory = null,
        DirectoryPath rootDirectoryPath = null,
        bool shouldAuthenticodeSignMsis = true,
        bool shouldAuthenticodeSignOutputAssemblies = true,
        bool shouldAuthenticodeSignPowerShellScripts = true,
        bool shouldBuildMsi = false,
        bool shouldBuildNuGetSourcePackage = false,
        bool shouldDownloadFullReleaseNotes = false,
        bool shouldDownloadMilestoneReleaseNotes = false,
        bool shouldGenerateSolutionVersionCSharpFile = true,
        bool shouldObfuscateOutputAssemblies = true,
        bool shouldPublishAwsLambdas = true,
        bool shouldPublishPreReleasePackages = true,
        bool shouldPublishReleasePackages = true,
        bool shouldReportCodeCoverageMetrics = true,
        bool shouldReportUnitTestResults = true,
        bool shouldRunChocolatey = true,
        bool shouldRunDotNetPack = false,
        bool shouldRunDotNetTest = true,
        bool shouldRunGitReleaseManager = false,
        bool shouldRunGitVersion = true,
        bool shouldRunILMerge = true,
        bool shouldRunInspectCode = true,
        bool shouldRunNuGet = true,
        bool shouldRunNUnit = true,
        bool shouldRunOpenCover = true,
        bool shouldRunReportGenerator = true,
        bool shouldRunReportUnit = true,
        bool? shouldRunTransifex = null,
        bool shouldRunxUnit = true,
        bool shouldStrongNameOutputAssemblies = true,
        bool shouldStrongNameSignDependentAssemblies = true,
        DirectoryPath solutionDirectoryPath = null,
        FilePath solutionFilePath = null,
        string strongNameDependentAssembliesInputPath = null,
        string testAssemblyFilePattern = null,
        string testAssemblyProjectPattern = null,
        DirectoryPath testDirectoryPath = null,
        TransifexMode transifexPullMode = TransifexMode.OnlyTranslated,
        int transifexPullPercentage = 60,
        bool treatWarningsAsErrors = true,
        bool useChocolateyGuiStrongNameKey = false
        )
    {
        if (context == null)
        {
            throw new ArgumentNullException("context");
        }

        if (buildSystem == null)
        {
            throw new ArgumentNullException("buildSystem");
        }

        if (sourceDirectoryPath == null)
        {
            throw new ArgumentNullException("sourceDirectoryPath");
        }

        if (string.IsNullOrEmpty(title))
        {
            throw new ArgumentNullException("title");
        }

        // These properties are used to define other values, so have to be set first, which is why
        // they are not in alphabetical order like the others.
        BuildProvider = GetBuildProvider(context, buildSystem);
        RootDirectoryPath = rootDirectoryPath ?? context.MakeAbsolute(context.Environment.WorkingDirectory);

        BuildAgentOperatingSystem = context.Environment.Platform.Family;
        BuildCounter = context.Argument("buildCounter", BuildProvider.Build.Number);
        CakeConfiguration = context.GetConfiguration();
        CertificateAlgorithm = context.EnvironmentVariable("CERT_ALGORITHM") ?? "Sha256";
        CertificateFilePath = context.EnvironmentVariable("CHOCOLATEY_OFFICIAL_CERT") ?? "";
        CertificatePassword = context.EnvironmentVariable("CHOCOLATEY_OFFICIAL_CERT_PASSWORD") ?? "";
        CertificateSubjectName = certificateSubjectName ?? "Chocolatey Software, Inc.";
        CertificateTimestampUrl = context.EnvironmentVariable("CERT_TIMESTAMP_URL") ?? "http://timestamp.digicert.com";
        Configuration = context.Argument("configuration", "Release");
        DeploymentEnvironment = context.Argument("environment", "Release");
        DevelopBranchName = developBranchName;
        ForceContinuousIntegration = context.Argument("forceContinuousIntegration", false);
        FullReleaseNotesFilePath = fullReleaseNotesFilePath ?? RootDirectoryPath.CombineWithFilePath("ReleaseNotes.md");
        GetFilesToObfuscate = getFilesToObfuscate;
        GetFilesToSign = getFilesToSign;
        GetILMergeConfigs = getILMergeConfigs;
        GetMsisToSign = getMsisToSign;
        GetProjectsToPack = getProjectsToPack;
        GetScriptsToSign = getScriptsToSign;
        GitHub = GetGitHubCredentials(context);
        IntegrationTestScriptPath = integrationTestScriptPath ?? context.MakeAbsolute((FilePath)"test.cake");
        IsLocalBuild = buildSystem.IsLocalBuild;
        IsPullRequest = BuildProvider.PullRequest.IsPullRequest;
        IsRunningOnGitHubActions = BuildProvider.Type == BuildProviderType.GitHubActions;
        IsRunningOnTeamCity = BuildProvider.Type == BuildProviderType.TeamCity;
        IsTagged = BuildProvider.Repository.Tag.IsTag;
        MasterBranchName = masterBranchName;
        MilestoneReleaseNotesFilePath = milestoneReleaseNotesFilePath ?? RootDirectoryPath.CombineWithFilePath("CHANGELOG.md");
        NuGetSources = nuGetSources;
        ObfuscateAssembly = obfuscateAssembly;
        PreferDotNetGlobalToolUsage = preferDotNetGlobalToolUsage;
        PrepareLocalRelease = context.Argument("prepareLocalRelease", false);
        PreReleaseLabelFilePath = preReleaseLabelFilePath ?? ".build_pre_release_label";
        ProductClsCompliant = productClsCompliant;
        ProductCompany = productCompany ?? "Chocolatey Software, Inc.";
        ProductComVisible = productComVisible;
        ProductCopyright = productCopyright ?? "Copyright not provided";
        ProductCustomAttributes = productCustomAttributes;
        ProductDescription = productDescription ?? "Description not provided";
        ProductName = productName ?? "Name not provided";
        ProductTrademark = productTrademark ?? "Chocolatey - Chocolatey Software, Inc.";
        RepositoryName = repositoryName ?? title;
        RepositoryOwner = repositoryOwner ?? string.Empty;
        ResharperSettingsFileName = resharperSettingsFileName ?? string.Format("{0}.sln.DotSettings", title);
        RestorePackagesDirectory = restorePackagesDirectory;
        ShouldAuthenticodeSignMsis = shouldAuthenticodeSignMsis;
        ShouldAuthenticodeSignOutputAssemblies = shouldAuthenticodeSignOutputAssemblies;
        ShouldAuthenticodeSignPowerShellScripts = shouldAuthenticodeSignPowerShellScripts;
        ShouldBuildMsi = shouldBuildMsi;
        ShouldBuildNuGetSourcePackage = shouldBuildNuGetSourcePackage;
        ShouldDownloadFullReleaseNotes = shouldDownloadFullReleaseNotes;
        ShouldDownloadMilestoneReleaseNotes = shouldDownloadMilestoneReleaseNotes;
        ShouldGenerateSolutionVersionCSharpFile = shouldGenerateSolutionVersionCSharpFile;
        ShouldObfuscateOutputAssemblies = shouldObfuscateOutputAssemblies;
        ShouldPublishAwsLambdas = shouldPublishAwsLambdas;
        ShouldPublishPreReleasePackages = shouldPublishPreReleasePackages;
        ShouldPublishReleasePackages = shouldPublishReleasePackages;
        ShouldReportCodeCoverageMetrics = shouldReportCodeCoverageMetrics;
        ShouldReportUnitTestResults = shouldReportUnitTestResults;
        ShouldRunChocolatey = shouldRunChocolatey;
        ShouldRunDotNetPack = shouldRunDotNetPack;
        ShouldRunDotNetTest = shouldRunDotNetTest;
        ShouldRunGitReleaseManager = shouldRunGitReleaseManager;
        ShouldRunGitVersion = shouldRunGitVersion;
        ShouldRunILMerge = shouldRunILMerge;
        ShouldRunInspectCode = shouldRunInspectCode;
        ShouldRunNuGet = shouldRunNuGet;
        ShouldRunNUnit = shouldRunNUnit;
        ShouldRunOpenCover = shouldRunOpenCover;

        if (context.HasArgument("shouldRunOpenCover"))
        {
            ShouldRunOpenCover = context.Argument<bool>("shouldRunOpenCover");
        }

        ShouldRunReportGenerator = shouldRunReportGenerator;
        ShouldRunReportUnit = shouldRunReportUnit;
        ShouldRunTransifex = shouldRunTransifex ?? TransifexIsConfiguredForRepository(context);
        ShouldRunxUnit = shouldRunxUnit;
        ShouldStrongNameOutputAssemblies = shouldStrongNameOutputAssemblies;
        ShouldStrongNameSignDependentAssemblies = shouldStrongNameSignDependentAssemblies;
        SolutionDirectoryPath = solutionDirectoryPath ?? sourceDirectoryPath.Combine(title);
        SolutionFilePath = solutionFilePath ?? sourceDirectoryPath.CombineWithFilePath(title + ".sln");
        SourceDirectoryPath = sourceDirectoryPath;
        StrongNameDependentAssembliesInputPath = strongNameDependentAssembliesInputPath ?? sourceDirectoryPath.Combine("packages").FullPath;
        Target = context.Argument("target", "Default");
        TestDirectoryPath = testDirectoryPath ?? sourceDirectoryPath;
        TestExecutionType = context.Argument("testExecutionType", "unit").ToLowerInvariant();
        Title = title;
        Transifex = GetTransifexCredentials(context);
        TransifexPullMode = transifexPullMode;
        TransifexPullPercentage = transifexPullPercentage;
        TreatWarningsAsErrors = treatWarningsAsErrors;
        UseChocolateyGuiStrongNameKey = useChocolateyGuiStrongNameKey;

        SetBuildPaths(BuildPaths.GetPaths());

        var branchName = BuildProvider.Repository.Branch;
        if (StringComparer.OrdinalIgnoreCase.Equals(masterBranchName, branchName))
        {
            BranchType = BranchType.Master;
        }
        else if (StringComparer.OrdinalIgnoreCase.Equals(developBranchName, branchName))
        {
            BranchType = BranchType.Develop;
        }
        else if (branchName.StartsWith("release", StringComparison.OrdinalIgnoreCase))
        {
            BranchType = BranchType.Release;
        }
        else if (branchName.StartsWith("hotfix", StringComparison.OrdinalIgnoreCase))
        {
            BranchType = BranchType.HotFix;
        }
        else
        {
            BranchType = BranchType.Unknown;
        }

        if (nuGetSources == null)
        {
            var primaryNuGetSource = context.EnvironmentVariable("PRIMARY_NUGET_SOURCE");

            if (!string.IsNullOrEmpty(primaryNuGetSource))
            {
                NuGetSources = new []{
                    primaryNuGetSource
                };

                context.Information("NuGet Sources configured using primary NuGet Source.");
            }
            else
            {
                var nuGetDevRestoreNuGetSource = context.EnvironmentVariable("NUGETDEVRESTORE_SOURCE");

                var devNuGetSources = new List<string>
                {
                    "https://www.nuget.org/api/v2/",
                    "https://api.nuget.org/v3/index.json"
                };

                if (!string.IsNullOrEmpty(nuGetDevRestoreNuGetSource))
                {
                    context.Information("Adding source to default values: {0}", nuGetDevRestoreNuGetSource);
                    devNuGetSources.Add(nuGetDevRestoreNuGetSource);
                }

                NuGetSources = devNuGetSources;

                context.Information("NuGet Sources configured using default values.");
            }
        }

        if (packageSourceDatas?.Any() ?? false)
        {
            context.Information("Setting Package Sources to passed in variable...");
            PackageSources = packageSourceDatas;
        }
        else
        {
            PackageSources = new List<PackageSourceData>();

            var defaultPushSourceUrl = context.EnvironmentVariable(Environment.DefaultPushSourceUrlVariable);
            context.Information("defaultPushSourceUrl: {0}", defaultPushSourceUrl);
            if (!string.IsNullOrEmpty(defaultPushSourceUrl))
            {
                context.Information("Adding Default Package Source Datas...");
                var defaultPushSourceUrlParts = Environment.DefaultPushSourceUrlVariable.Split('_');
                PackageSources.Add(new PackageSourceData(context, defaultPushSourceUrlParts[0], defaultPushSourceUrl));
                PackageSources.Add(new PackageSourceData(context, defaultPushSourceUrlParts[0], defaultPushSourceUrl, FeedType.Chocolatey));
                PackageSources.Add(new PackageSourceData(context, defaultPushSourceUrlParts[0], defaultPushSourceUrl, FeedType.NuGet, false));
                PackageSources.Add(new PackageSourceData(context, defaultPushSourceUrlParts[0], defaultPushSourceUrl, FeedType.Chocolatey, false));
            }
        }

        if (ShouldStrongNameOutputAssemblies || ShouldStrongNameSignDependentAssemblies)
        {
            var officialStrongNameKey = context.EnvironmentVariable("CHOCOLATEY_OFFICIAL_KEY");
            var localUnofficialStrongNameKey = RootDirectoryPath.CombineWithFilePath("chocolatey.snk").FullPath;

            if (UseChocolateyGuiStrongNameKey)
            {
                context.Information("Switching to Chocolatey GUI Strong Name Key selection...");
                officialStrongNameKey = context.EnvironmentVariable("CHOCOLATEYGUI_OFFICIAL_KEY");
                localUnofficialStrongNameKey = RootDirectoryPath.CombineWithFilePath("chocolateygui.snk").FullPath;
            }

            if (Configuration == "ReleaseOfficial" && !string.IsNullOrWhiteSpace(officialStrongNameKey) && context.FileExists(officialStrongNameKey))
            {
                context.Information("Using Official Strong Name Key...");
                StrongNameKeyPath = officialStrongNameKey;
            }
            else if (context.FileExists(localUnofficialStrongNameKey))
            {
                context.Information("Using local Unofficial Strong Name Key...");
                StrongNameKeyPath = localUnofficialStrongNameKey;
            }
            else
            {
                context.Information("Creating new unofficial Strong Name Key...");

                var newChocolateyUnofficialKey = context.MakeAbsolute(new FilePath(string.Format("{0}.unofficial.snk", title)));

                // If the file already exists, don't re-create it
                if (!context.FileExists(newChocolateyUnofficialKey))
                {
                    context.StrongNameCreate(newChocolateyUnofficialKey);
                }

                StrongNameKeyPath = newChocolateyUnofficialKey.FullPath;
            }
        }

        if (TestExecutionType == "unit")
        {
            TestAssemblyFilePattern = testAssemblyFilePattern ?? "/**/*[tT]ests.dll";
            TestAssemblyProjectPattern = testAssemblyProjectPattern ?? "/**/*[tT]ests.csproj";
        }
        else if (TestExecutionType == "integration")
        {
            TestAssemblyFilePattern = testAssemblyFilePattern ?? "/**/*[tT]ests.[iI]ntegration.dll";
            TestAssemblyProjectPattern = testAssemblyProjectPattern ?? "/**/*[tT]ests.[iI]ntegration.csproj";
        }
        else if (TestExecutionType == "all")
        {
            TestAssemblyFilePattern = testAssemblyFilePattern ?? "/**/*{[tT]ests|[tT]ests.[iI]ntegration}.dll";
            TestAssemblyProjectPattern = testAssemblyProjectPattern ?? "/**/*{[tT]ests|[tT]ests.[iI]ntegration}.csproj";
        }
    }
}

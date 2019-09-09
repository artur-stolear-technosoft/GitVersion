using System.Collections.Generic;
using GitVersion.Configuration;
using GitVersion.Helpers;
using GitVersion.OutputFormatters;

namespace GitVersion
{
    public class Arguments
    {
        public Authentication Authentication = new Authentication();

        public Config OverrideConfig = new Config();
        public bool HasOverrideConfig;
        public ConfigFileLocator ConfigFileLocator = ConfigFileLocator.GetLocator();

        public string TargetPath;

        public string TargetUrl;
        public string TargetBranch;
        public string CommitId;
        public string DynamicRepositoryLocation;

        public bool Init;
        public bool Diag;
        public bool IsVersion;
        public bool IsHelp;
        public string LogFilePath;
        public string ShowVariable;

        public OutputType Output = OutputType.Json;

        public string Proj;
        public string ProjArgs;
        public string Exec;
        public string ExecArgs;

        public bool UpdateAssemblyInfo;
        public ISet<string> UpdateAssemblyInfoFileName = new HashSet<string>();
        public bool EnsureAssemblyInfo;

        public bool UpdateWixVersionFile;

        public bool ShowConfig;
        public bool NoFetch;
        public bool NoCache;
        public bool NoNormalize;

        public VerbosityLevel Verbosity = VerbosityLevel.Info;

        public void AddAssemblyInfoFileName(string fileName)
        {
            UpdateAssemblyInfoFileName.Add(fileName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FlubuCore.Octopus
{
    public class OctopusCreateReleaseTask : OctopusBaseTask<OctopusCreateReleaseTask>
    {
        protected override string Description { get; set; }

        public OctopusCreateReleaseTask(string project)
        {
            ExecutablePath = "Octo";
            WithArguments("create-release");
            WithArgumentsValueRequired("--project", project);
        }

        public OctopusCreateReleaseTask DefaultPackageVersion(string version)
        {
            WithArgumentsValueRequired("--defaultpackageversion", version);
            return this;
        }

        public OctopusCreateReleaseTask Version(string version)
        {
            WithArgumentsValueRequired("--version", version);
            return this;
        }

        public OctopusCreateReleaseTask Channel(string channel)
        {
            WithArgumentsValueRequired("--channel", channel);
            return this;
        }

        public OctopusCreateReleaseTask Package(string package)
        {
            WithArgumentsValueRequired("--package", package);
            return this;
        }

        public OctopusCreateReleaseTask PackagesFolder(string folder)
        {
            WithArgumentsValueRequired("--packagesFolder", folder);
            return this;
        }

        public OctopusCreateReleaseTask ReleaseNotes(string releaseNotes)
        {
            WithArgumentsValueRequired("--releasenotes", releaseNotes);
            return this;
        }

        public OctopusCreateReleaseTask ReleaseNotesFile(string file)
        {
            WithArgumentsValueRequired("--releasenotesfile", file);
            return this;
        }

        public OctopusCreateReleaseTask IgnoreExisting()
        {
            WithArguments("--ignoreexisting");
            return this;
        }

        public OctopusCreateReleaseTask IgnoreChannelRules()
        {
            WithArguments("--ignorechannelrules");
            return this;
        }

        public OctopusCreateReleaseTask PackagePrerelease(string value)
        {
            WithArgumentsValueRequired("--packageprerelease", value);
            return this;
        }

        public OctopusCreateReleaseTask WhatIf()
        {
            WithArguments("--whatif");
            return this;
        }

        /// <summary>
        /// Whether to force downloading of already installed packages
        /// </summary>
        /// <returns></returns>
        public OctopusCreateReleaseTask ForcePackageDownload()
        {
            WithArguments("--forcepackagedownload");
            return this;
        }

        public OctopusCreateReleaseTask WaitForDeployment()
        {
            WithArguments("--waitfordeployment ");
            return this;
        }

        public OctopusCreateReleaseTask DeploymentTimeout(string value)
        {
            WithArgumentsValueRequired("--deploymenttimeout", value);
            return this;
        }

        public OctopusCreateReleaseTask CancelOnTimeout()
        {
            WithArguments("--cancelontimeout ");
            return this;
        }

        public OctopusCreateReleaseTask DeploymentChecksSleepCycle(string value)
        {
            WithArguments("--deploymentchecksleepcycle", value);
            return this;
        }

        public OctopusCreateReleaseTask SpecificMachines(string machine)
        {
            WithArgumentsValueRequired("--specificmachines", machine);
            return this;
        }

        public OctopusCreateReleaseTask Force()
        {
            WithArguments("--force");
            return this;
        }

        public OctopusCreateReleaseTask Skip(string stepName)
        {
            WithArgumentsValueRequired("--skip", stepName);
            return this;
        }

        public OctopusCreateReleaseTask NoRawLog()
        {
            WithArguments("--norawlog");
            return this;
        }

        public OctopusCreateReleaseTask RawLogFilename(string filePath)
        {
            WithArgumentsValueRequired("--rawlogfile", filePath);
            return this;
        }

        public OctopusCreateReleaseTask Variable(string variable)
        {
            WithArgumentsValueRequired("--variable", variable);
            return this;
        }

        public OctopusCreateReleaseTask DeployAt(string value)
        {
            WithArgumentsValueRequired("-deployat", value);
            return this;
        }

        public OctopusCreateReleaseTask Tenant(string value)
        {
            WithArgumentsValueRequired("--tenant", value);
            return this;
        }

        public OctopusCreateReleaseTask TenantTag(string value)
        {
            WithArgumentsValueRequired("--tenanttag", value);
            return this;
        }

        public OctopusCreateReleaseTask DeployTo(string enviroment)
        {
            WithArgumentsValueRequired("-deployto", enviroment);
            return this;
        }
    }
}

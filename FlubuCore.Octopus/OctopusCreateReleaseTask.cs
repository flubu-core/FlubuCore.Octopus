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

        /// <summary>
        ///  Default version number of all packages to use for this release.
        /// Override per-package using --package.
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask DefaultPackageVersion(string version)
        {
            WithArgumentsValueRequired("--defaultpackageversion", version);
            return this;
        }

        /// <summary>
        /// Release number to use for the new release.
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask Version(string version)
        {
            WithArgumentsValueRequired("--version", version);
            return this;
        }

        /// <summary>
        /// Channel to use for the new release. Omit this argument to automatically select the best channel.
        /// </summary>
        /// <param name="channel"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask Channel(string channel)
        {
            WithArgumentsValueRequired("--channel", channel);
            return this;
        }

        /// <summary>
        /// Version number to use for a package in the release. Format: StepName:Version or PackageID:Version
        /// or StepName:PackageName:Version. StepName, PackageID, and PackageName can be replaced with an asterisk.
        /// </summary>
        /// <param name="package"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask Package(string package)
        {
            WithArgumentsValueRequired("--package", package);
            return this;
        }

        /// <summary>
        /// A folder containing NuGet packages from which we should get versions.
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask PackagesFolder(string folder)
        {
            WithArgumentsValueRequired("--packagesFolder", folder);
            return this;
        }

        /// <summary>
        /// Release Notes for the new release. Styling with Markdown is supported.
        /// </summary>
        /// <param name="releaseNotes"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask ReleaseNotes(string releaseNotes)
        {
            WithArgumentsValueRequired("--releasenotes", releaseNotes);
            return this;
        }

        /// <summary>
        ///  Path to a file that contains Release Notes for the new release. Supports Markdown files.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask ReleaseNotesFile(string file)
        {
            WithArgumentsValueRequired("--releasenotesfile", file);
            return this;
        }

        /// <summary>
        /// Don't create this release if there is already one with the same version number.
        /// </summary>
        /// <returns></returns>
        public OctopusCreateReleaseTask IgnoreExisting()
        {
            WithArguments("--ignoreexisting");
            return this;
        }

        /// <summary>
        /// Create the release ignoring any version rules specified by the channel.
        /// </summary>
        /// <returns></returns>
        public OctopusCreateReleaseTask IgnoreChannelRules()
        {
            WithArguments("--ignorechannelrules");
            return this;
        }

        /// <summary>
        /// Pre-release for latest version of all packages to use for this release.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask PackagePrerelease(string value)
        {
            WithArgumentsValueRequired("--packageprerelease", value);
            return this;
        }

        /// <summary>
        /// Perform a dry run but don't actually create/deploy release.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Whether to wait synchronously for deployment to finish.
        /// </summary>
        /// <returns></returns>
        public OctopusCreateReleaseTask WaitForDeployment()
        {
            WithArguments("--waitfordeployment ");
            return this;
        }

        /// <summary>
        /// Specifies maximum time (timespan format) that the console session will wait for the deployment to finish(default 00:10:00).
        /// This will not stop the deployment. Requires --waitfordeployment parameter set.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask DeploymentTimeout(string value)
        {
            WithArgumentsValueRequired("--deploymenttimeout", value);
            return this;
        }

        /// <summary>
        /// Whether to cancel the deployment if the deployment timeout is reached (flag, default false).
        /// </summary>
        /// <returns></returns>
        public OctopusCreateReleaseTask CancelOnTimeout()
        {
            WithArguments("--cancelontimeout ");
            return this;
        }

        /// <summary>
        /// Specifies how much time (timespan format) should elapse between deployment status checks (default 00:00:10)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask DeploymentChecksSleepCycle(string value)
        {
            WithArguments("--deploymentchecksleepcycle", value);
            return this;
        }

        /// <summary>
        /// A comma-separated list of machines names to target in the deployed environment.
        /// If not specified all machines in the environment will be considered.
        /// </summary>
        /// <param name="machine"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask SpecificMachines(string machine)
        {
            WithArgumentsValueRequired("--specificmachines", machine);
            return this;
        }

        /// <summary>
        ///  If a project is configured to skip packages with already-installed versions,
        ///  override this setting to force re-deployment (flag, default false).
        /// </summary>
        /// <returns></returns>
        public OctopusCreateReleaseTask Force()
        {
            WithArguments("--force");
            return this;
        }

        /// <summary>
        /// Skip a step by name
        /// </summary>
        /// <param name="stepName"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask Skip(string stepName)
        {
            WithArgumentsValueRequired("--skip", stepName);
            return this;
        }

        /// <summary>
        /// Don't print the raw log of failed tasks
        /// </summary>
        /// <returns></returns>
        public OctopusCreateReleaseTask NoRawLog()
        {
            WithArguments("--norawlog");
            return this;
        }

        /// <summary>
        /// Redirect the raw log of failed tasks to a file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask RawLogFilename(string filePath)
        {
            WithArgumentsValueRequired("--rawlogfile", filePath);
            return this;
        }

        /// <summary>
        /// Values for any prompted variables in the format Label:Value.
        /// For JSON values, embedded quotation marks should be escaped with a backslash.
        /// </summary>
        /// <param name="variable"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask Variable(string variable)
        {
            WithArgumentsValueRequired("--variable", variable);
            return this;
        }

        /// <summary>
        ///  Time at which deployment should start (scheduled deployment), specified as any valid DateTimeOffset format, and assuming the time zone is the current local time zone.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask DeployAt(string value)
        {
            WithArgumentsValueRequired("-deployat", value);
            return this;
        }

        /// <summary>
        /// Create a deployment for this tenant; specify this argument multiple times to add multiple tenants
        /// or use `*` wildcard to deploy to all  tenants who are ready for this release (according to lifecycle).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask Tenant(string value)
        {
            WithArgumentsValueRequired("--tenant", value);
            return this;
        }

        /// <summary>
        /// Create a deployment for tenants matching this tag; specify this argument multiple times
        /// to build a query/filter with multiple tags, just like you can in the user interface.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask TenantTag(string value)
        {
            WithArgumentsValueRequired("--tenanttag", value);
            return this;
        }

        /// <summary>
        ///  Environment to automatically deploy to, e.g., Production
        /// </summary>
        /// <param name="enviroment"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask DeployTo(string enviroment)
        {
            WithArgumentsValueRequired("-deployto", enviroment);
            return this;
        }
    }
}

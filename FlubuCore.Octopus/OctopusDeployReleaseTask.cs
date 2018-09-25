using System;
using System.Collections.Generic;
using System.Text;

namespace FlubuCore.Octopus
{
    public class OctopusDeployReleaseTask : OctopusBaseTask<OctopusDeployReleaseTask>
    {
        protected override string Description { get; set; }

        public OctopusDeployReleaseTask()
        {
            ExecutablePath = "Octo";
            WithArguments("deploy-release");
        }
        
        /// <summary>
        /// Whether to force downloading of already installed packages
        /// </summary>
        /// <returns></returns>
        public OctopusDeployReleaseTask ForcePackageDownload()
        {
            WithArguments("--forcepackagedownload");
            return this;
        }

        /// <summary>
        /// Whether to wait synchronously for deployment to finish.
        /// </summary>
        /// <returns></returns>
        public OctopusDeployReleaseTask WaitForDeployment()
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
        public OctopusDeployReleaseTask DeploymentTimeout(string value)
        {
            WithArgumentsValueRequired("--deploymenttimeout", value);
            return this;
        }

        /// <summary>
        /// Whether to cancel the deployment if the deployment timeout is reached (flag, default false).
        /// </summary>
        /// <returns></returns>
        public OctopusDeployReleaseTask CancelOnTimeout()
        {
            WithArguments("--cancelontimeout ");
            return this;
        }

        /// <summary>
        /// Specifies how much time (timespan format) should elapse between deployment status checks (default 00:00:10)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public OctopusDeployReleaseTask DeploymentChecksSleepCycle(string value)
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
        public OctopusDeployReleaseTask SpecificMachines(string machine)
        {
            WithArgumentsValueRequired("--specificmachines", machine);
            return this;
        }

        /// <summary>
        ///  If a project is configured to skip packages with already-installed versions,
        ///  override this setting to force re-deployment (flag, default false).
        /// </summary>
        /// <returns></returns>
        public OctopusDeployReleaseTask Force()
        {
            WithArguments("--force");
            return this;
        }

        /// <summary>
        /// Skip a step by name
        /// </summary>
        /// <param name="stepName"></param>
        /// <returns></returns>
        public OctopusDeployReleaseTask Skip(string stepName)
        {
            WithArgumentsValueRequired("--skip", stepName);
            return this;
        }

        /// <summary>
        /// Don't print the raw log of failed tasks
        /// </summary>
        /// <returns></returns>
        public OctopusDeployReleaseTask NoRawLog()
        {
            WithArguments("--norawlog");
            return this;
        }

        /// <summary>
        /// Redirect the raw log of failed tasks to a file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public OctopusDeployReleaseTask RawLogFilename(string filePath)
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
        public OctopusDeployReleaseTask Variable(string variable)
        {
            WithArgumentsValueRequired("--variable", variable);
            return this;
        }

        /// <summary>
        ///  Time at which deployment should start (scheduled deployment), specified as any valid DateTimeOffset format, and assuming the time zone is the current local time zone.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public OctopusDeployReleaseTask DeployAt(string value)
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
        public OctopusDeployReleaseTask Tenant(string value)
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
        public OctopusDeployReleaseTask TenantTag(string value)
        {
            WithArgumentsValueRequired("--tenanttag", value);
            return this;
        }

        /// <summary>
        ///  Environment to automatically deploy to, e.g., Production
        /// </summary>
        /// <param name="enviroment"></param>
        /// <returns></returns>
        public OctopusDeployReleaseTask DeployTo(string enviroment)
        {
            WithArgumentsValueRequired("-deployto", enviroment);
            return this;
        }

        /// <summary>
        /// Version number of the release to deploy. Or specify --version=latest for the latest release.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public OctopusDeployReleaseTask ReleaseNumber(string value)
        {
            WithArgumentsValueRequired("--releaseNumber", value);
            return this;
        }

        /// <summary>
        /// Channel to use when getting the release to deploy
        /// </summary>
        /// <param name="channel"></param>
        /// <returns></returns>
        public OctopusDeployReleaseTask Channel(string channel)
        {
            WithArgumentsValueRequired("--channel", channel);
            return this;
        }

        /// <summary>
        /// Overwrite the variable snapshot for the release by re-importing the variables from the project
        /// </summary>
        /// <returns></returns>
        public OctopusDeployReleaseTask UpdateVariables()
        {
            WithArguments("--updateVariables");
            return this;
        }
    }
}

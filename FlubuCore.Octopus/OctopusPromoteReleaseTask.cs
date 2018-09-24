using System;
using System.Collections.Generic;
using System.Text;

namespace FlubuCore.Octopus
{
    public class OctopusPromoteReleaseTask : OctopusBaseTask<OctopusDeployReleaseTask>
    {
        protected override string Description { get; set; }

        public OctopusPromoteReleaseTask(string project, string deployFrom, string deployTo)
        {
            ExecutablePath = "Octo";
            WithArguments("promote-release");
            WithArgumentsValueRequired("--project", project);
            WithArgumentsValueRequired("--from", deployFrom);
            WithArgumentsValueRequired("--to", deployTo);
        }

        public OctopusPromoteReleaseTask UpdateVariables()
        {
            WithArguments("--updateVariables");
            return this;
        }

          /// <summary>
        /// Whether to force downloading of already installed packages
        /// </summary>
        /// <returns></returns>
        public OctopusPromoteReleaseTask ForcePackageDownload()
        {
            WithArguments("--forcepackagedownload");
            return this;
        }

        public OctopusPromoteReleaseTask WaitForDeployment()
        {
            WithArguments("--waitfordeployment ");
            return this;
        }

        public OctopusPromoteReleaseTask DeploymentTimeout(string value)
        {
            WithArgumentsValueRequired("--deploymenttimeout", value);
            return this;
        }

        public OctopusPromoteReleaseTask CancelOnTimeout()
        {
            WithArguments("--cancelontimeout ");
            return this;
        }

        public OctopusPromoteReleaseTask DeploymentChecksSleepCycle(string value)
        {
            WithArguments("--deploymentchecksleepcycle", value);
            return this;
        }

        public OctopusPromoteReleaseTask SpecificMachines(string machine)
        {
            WithArgumentsValueRequired("--specificmachines", machine);
            return this;
        }

        public OctopusPromoteReleaseTask Force()
        {
            WithArguments("--force");
            return this;
        }

        public OctopusPromoteReleaseTask Skip(string stepName)
        {
            WithArgumentsValueRequired("--skip", stepName);
            return this;
        }

        public OctopusPromoteReleaseTask NoRawLog()
        {
            WithArguments("--norawlog");
            return this;
        }

        public OctopusPromoteReleaseTask RawLogFilename(string filePath)
        {
            WithArgumentsValueRequired("--rawlogfile", filePath);
            return this;
        }

        public OctopusPromoteReleaseTask Variable(string variable)
        {
            WithArgumentsValueRequired("--variable", variable);
            return this;
        }

        public OctopusPromoteReleaseTask DeployAt(string value)
        {
            WithArgumentsValueRequired("-deployat", value);
            return this;
        }

        public OctopusPromoteReleaseTask Tenant(string value)
        {
            WithArgumentsValueRequired("--tenant", value);
            return this;
        }

        public OctopusPromoteReleaseTask TenantTag(string value)
        {
            WithArgumentsValueRequired("--tenanttag", value);
            return this;
        }
    }
}

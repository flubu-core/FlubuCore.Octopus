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

        public OctopusDeployReleaseTask WaitForDeployment()
        {
            WithArguments("--waitfordeployment ");
            return this;
        }

        public OctopusDeployReleaseTask DeploymentTimeout(string value)
        {
            WithArgumentsValueRequired("--deploymenttimeout", value);
            return this;
        }

        public OctopusDeployReleaseTask CancelOnTimeout()
        {
            WithArguments("--cancelontimeout ");
            return this;
        }

        public OctopusDeployReleaseTask DeploymentChecksSleepCycle(string value)
        {
            WithArguments("--deploymentchecksleepcycle", value);
            return this;
        }

        public OctopusDeployReleaseTask SpecificMachines(string machine)
        {
            WithArgumentsValueRequired("--specificmachines", machine);
            return this;
        }

        public OctopusDeployReleaseTask Force()
        {
            WithArguments("--force");
            return this;
        }

        public OctopusDeployReleaseTask Skip(string stepName)
        {
            WithArgumentsValueRequired("--skip", stepName);
            return this;
        }

        public OctopusDeployReleaseTask NoRawLog()
        {
            WithArguments("--norawlog");
            return this;
        }

        public OctopusDeployReleaseTask RawLogFilename(string filePath)
        {
            WithArgumentsValueRequired("--rawlogfile", filePath);
            return this;
        }

        public OctopusDeployReleaseTask Variable(string variable)
        {
            WithArgumentsValueRequired("--variable", variable);
            return this;
        }

        public OctopusDeployReleaseTask DeployAt(string value)
        {
            WithArgumentsValueRequired("-deployat", value);
            return this;
        }

        public OctopusDeployReleaseTask Tenant(string value)
        {
            WithArgumentsValueRequired("--tenant", value);
            return this;
        }

        public OctopusDeployReleaseTask TenantTag(string value)
        {
            WithArgumentsValueRequired("--tenanttag", value);
            return this;
        }

        public OctopusDeployReleaseTask DeployTo(string enviroment)
        {
            WithArgumentsValueRequired("-deployto", enviroment);
            return this;
        }

        public OctopusDeployReleaseTask ReleaseNumber(string value)
        {
            WithArgumentsValueRequired("--releaseNumber", value);
            return this;
        }

        public OctopusDeployReleaseTask Channel(string channel)
        {
            WithArgumentsValueRequired("--channel", channel);
            return this;
        }

        public OctopusDeployReleaseTask UpdateVariables()
        {
            WithArguments("--updateVariables");
            return this;
        }
    }
}

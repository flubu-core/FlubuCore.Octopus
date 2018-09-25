using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Octopus
{
    public class OctopusPushTask: OctopusBaseTask<OctopusPushTask>
    {
        protected override string Description { get; set; }

        public OctopusPushTask(params string[] packageId)
        {
            ExecutablePath = "Octo";
            WithArguments("push");
            if (packageId != null && packageId.Length > 0)
            {
                foreach (var id in packageId)
                {
                    WithArguments($"--package", id);
                }
            }
        }

        /// <summary>
        /// If the package already exists in the repository, the default behavior is to reject the new package being pushed.
        /// You can pass this flag to overwrite the existing package.
        /// </summary>
        /// <returns></returns>
        public OctopusPushTask ReplaceExisting()
        {
            WithArguments("--replace-existing");
            return this;
        }

        /// <summary>
        /// utput format, only valid option is json
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public OctopusPushTask OutputFormat(string format)
        {
            WithArgumentsValueRequired("--outputFormat", format);
            return this;
        }
    }
}

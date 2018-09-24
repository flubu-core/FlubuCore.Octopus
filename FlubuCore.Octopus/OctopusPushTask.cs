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

        public OctopusPushTask ReplaceExisting()
        {
            WithArguments("--replace-existing");
            return this;
        }

        public OctopusPushTask OutputFormat(string format)
        {
            WithArgumentsValueRequired("--outputFormat", format);
            return this;
        }
    }
}

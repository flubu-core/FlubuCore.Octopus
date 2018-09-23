using System;
using System.Collections.Generic;
using System.Text;

namespace FlubuCore.Octopus
{
    public class Octopus
    {
        public OctopusPackTask Pack(string packageId)
        {
            return new OctopusPackTask(packageId);
        }
    }
}

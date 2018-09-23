using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Context.FluentInterface.Interfaces;

namespace FlubuCore.Octopus
{
    public static class OctopusExtensions
    {
        public static Octopus Octopus(this ITaskFluentInterface flubu)
        {
            return new Octopus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Octopus
{
    public class OctopusPushTask: ExternalProcessTaskBase<OctopusPushTask>
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

        public OctopusPushTask Server(string server)
        {
            WithArgumentsValueRequired("--server", server);
            return this;
        }

        public OctopusPushTask ApiKey(string apiKey)
        {
            WithArgumentsValueRequired("--apiKey", apiKey);
            return this;
        }

        public OctopusPushTask User(string user)
        {
            WithArgumentsValueRequired("--user", user);
            return this;
        }

        public OctopusPushTask Pass(string password)
        {
            WithArgumentsValueRequired("--pass", password);
            return this;
        }

        public OctopusPushTask ConfigFile(string file)
        {
            WithArgumentsValueRequired("--configFile", file);
            return this;
        }

        public OctopusPushTask Debug()
        {
            WithArguments("--debug");
            return this;
        }

        public OctopusPushTask IgnoreSslErrors()
        {
            WithArguments("--ignoreSslErrors");
            return this;
        }

        public OctopusPushTask EnableServiceMessages()
        {
            WithArguments("--enableServiceMessages");
            return this;
        }

        public OctopusPushTask Timeout(int timeout)
        {
            WithArguments("--timeout", timeout.ToString());
            return this;
        }

        public OctopusPushTask Proxy(string proxy)
        {
            WithArguments("--proxy", proxy);
            return this;
        }

        public OctopusPushTask ProxyUser(string user)
        {
            WithArgumentsValueRequired("--proxyUser", user);
            return this;
        }

        public OctopusPushTask ProxyPass(string pass)
        {
            WithArgumentsValueRequired("--proxyPass", pass);
            return this;
        }

        public OctopusPushTask OctopusPushTask(LogLevel logLevel)
        {
            WithArguments("--logLevel", logLevel.ToString().ToLowerInvariant());
            return this;
        }
    }
}

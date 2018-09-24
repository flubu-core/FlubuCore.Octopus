using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Octopus
{
    public abstract class OctopusBaseTask<TTask> : ExternalProcessTaskBase<TTask> where TTask : class, ITask
    {
        public TTask Server(string server)
        {
            WithArgumentsValueRequired("--server", server);
            return this as TTask;
        }

        public TTask ApiKey(string apiKey)
        {
            WithArgumentsValueRequired("--apiKey", apiKey);
            return this as TTask;
        }

        public TTask User(string user)
        {
            WithArgumentsValueRequired("--user", user);
            return this as TTask;
        }

        public TTask Pass(string password)
        {
            WithArgumentsValueRequired("--pass", password);
            return this as TTask;
        }

        public TTask ConfigFile(string file)
        {
            WithArgumentsValueRequired("--configFile", file);
            return this as TTask;
        }

        public TTask Debug()
        {
            WithArguments("--debug");
            return this as TTask;
        }

        public TTask IgnoreSslErrors()
        {
            WithArguments("--ignoreSslErrors");
            return this as TTask;
        }

        public TTask EnableServiceMessages()
        {
            WithArguments("--enableServiceMessages");
            return this as TTask;
        }

        public TTask Timeout(int timeout)
        {
            WithArguments("--timeout", timeout.ToString());
            return this as TTask;
        }

        public TTask Proxy(string proxy)
        {
            WithArguments("--proxy", proxy);
            return this as TTask;
        }

        public TTask ProxyUser(string user)
        {
            WithArgumentsValueRequired("--proxyUser", user);
            return this as TTask;
        }

        public TTask ProxyPass(string pass)
        {
            WithArgumentsValueRequired("--proxyPass", pass);
            return this as TTask;
        }

        public TTask LogLevel(LogLevel logLevel)
        {
            WithArguments("--logLevel", logLevel.ToString().ToLowerInvariant());
            return this as TTask;
        }

        protected override int DoExecute(ITaskContextInternal context)
        {
            if (string.IsNullOrEmpty(ExecutablePath))
            {
                ExecutablePath = "Octo";
            }

            return base.DoExecute(context);
        }
    }
}
